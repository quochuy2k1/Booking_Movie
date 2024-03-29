import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import rollupReplace from "@rollup/plugin-replace";
import path from 'path';

console.log(path.resolve(__dirname,"admin", "index.html"), "__dirname");
// https://vitejs.dev/config/
export default defineConfig({
  base: "",
  plugins: [rollupReplace({
    preventAssignment: true,
    values: {
      __DEV__: JSON.stringify(true),
      "process.env.NODE_ENV": JSON.stringify("development"),
    },
  }), react()],
  build: {
    rollupOptions: {
      // Build two separate bundles, one for each app.
      input: {
        client: path.resolve(__dirname, "index.html"),
        admin: path.resolve(__dirname,"src/admin", "index.html"),
      },
     
    },
  },
  resolve: process.env.USE_SOURCE
    ? {
      alias: {
        "@remix-run/router": path.resolve(
          __dirname,
          "../../packages/router/index.ts"
        ),
        "react-router": path.resolve(
          __dirname,
          "../../packages/react-router/index.ts"
        ),
        "react-router-dom": path.resolve(
          __dirname,
          "../../packages/react-router-dom/index.tsx"
        ),
      },
    }
    : {},
  server: {
    port: 3000,
  }
})
