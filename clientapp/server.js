import express from 'express';
import path from 'path'
import fsp from 'fs/promises'
import { createServer as createViteServer } from 'vite'

let isProduction = process.env.NODE_ENV === "production";
const __dirname = path.resolve();
async function createServer() {
    let app = express();
    /**
     * @type {import("vite").ViteDevServer}
     */
    let vite;

    if (!isProduction) {
        vite = await createViteServer({
            root: process.cwd(),
            server: { middlewareMode: true },
            appType: 'custom'
        });

        app.use(vite.middlewares);
    } else {
        app.use(require("compression")());
        app.use(express.static(path.join(__dirname, "dist")));
    }

    app.use("*", async (req, res) => {
        let url = req.originalUrl;

        // Use a separate HTML file for the "Inbox" app.
        let appDirectory = url.startsWith("/administrator") ? "src/admin" : "";
        let htmlFileToLoad;

        if (isProduction) {
            htmlFileToLoad = path.resolve("dist", appDirectory, "index.html");
        } else {
            htmlFileToLoad = path.resolve(appDirectory, "index.html");
        }

        try {
            let html = await fsp.readFile(
                path.resolve(__dirname, htmlFileToLoad),
                "utf-8"
            );

            if (!isProduction) {
                html = await vite.transformIndexHtml(req.url, html);
            }

            res.setHeader("Content-Type", "text/html");
            return res.status(200).end(html);
        } catch (error) {
            if (!isProduction) vite.ssrFixStacktrace(error);
            console.log(error.stack);
            return res.status(500).end(error.stack);
        }
    });

    return app;
}

createServer().then((app) => {
    app.listen(3000, () => {
        console.log("HTTP server is running at http://localhost:3000");
    });
});
