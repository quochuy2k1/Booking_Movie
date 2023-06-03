import { Alert, AlertColor, Snackbar, SnackbarOrigin } from "@mui/material";
import React from "react";

interface IProps {
    open: boolean,
    anchorOrigin?: SnackbarOrigin,
    severity: AlertColor,
    autoHideDuration?: number,
    message: string,
    variant?: "filled" | "standard" | "outlined",
    handleClose: (event?: React.SyntheticEvent | Event, reason?: string) => void
}
const Notification: React.FC<IProps> = (props) => {

    const { open, anchorOrigin,variant, severity, autoHideDuration, message, handleClose } = props;

    return <Snackbar anchorOrigin={anchorOrigin ?? { horizontal: "center", vertical: "top" }} open={open} autoHideDuration={autoHideDuration ?? 6000} onClose={handleClose} >
        <Alert onClose={handleClose} variant={variant ?? "filled"} severity={severity} sx={{ width: '100%' }}>
           {message}
        </Alert>
    </Snackbar>
}

export default Notification;