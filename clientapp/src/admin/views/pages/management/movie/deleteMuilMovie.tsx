import { Alert, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Snackbar } from "@mui/material"
import { useGridApiContext } from "@mui/x-data-grid";
import { GridApiCommunity } from "@mui/x-data-grid/models/api/gridApiCommunity";
import React from "react";
import { Button, Icon } from "semantic-ui-react"
import { useAppDispatch } from "../../../../../app/hooks";
import { DeleteMovieAsync } from "../../../../../slices/movie/movieSlice";


interface IDeleteMuilMovieProps {
    id: number[],
}


const DeleteMuilMovie: React.FC<IDeleteMuilMovieProps> = ({ id }) => {
    const dispatch = useAppDispatch();
    const [openDel, setOpenDel] = React.useState(false);

    const token = localStorage.getItem("token");

    const handleClickDelOpen = () => {
        if (id.length === 0) {
            setOpen(true);
        }
        else setOpenDel(true);
    };

    const handleDelClose = () => {
        setOpenDel(false);
    };
    const handleDelCancel = () => {
        setOpenDel(false);
    };

    const [open, setOpen] = React.useState(false);


    const handleClose = (event?: React.SyntheticEvent | Event, reason?: string) => {
        if (reason === 'clickaway') {
            return;
        }

        setOpen(false);
    };
    const handleDelConfirm = () => {

        if (id.length > 0) {
            dispatch(DeleteMovieAsync({id, token: token!}));
            setOpenDel(false);
        }
        

    };

    return (
        <>
            <Button icon color='red' onClick={handleClickDelOpen} labelPosition='right'>
                <Icon name='delete' /> Xoá nhiều
            </Button>

            <Dialog
                open={openDel}
                onClose={handleDelClose}
                aria-labelledby="alert-dialog-title"
                aria-describedby="alert-dialog-description"
            >
                <DialogTitle id="alert-dialog-title" className='text-xl font-bold'>
                    {"Bạn có thực sự muốn xoá?"}
                </DialogTitle>
                <DialogContent>
                    <DialogContentText id="alert-dialog-description" className='text-lg'>
                        Hàng bạn muốn xoá là
                    </DialogContentText>
                </DialogContent>
                <DialogActions>
                    <Button color='red' onClick={handleDelCancel}>Huỷ bỏ xoá</Button>
                    <Button color='blue' onClick={handleDelConfirm} autoFocus>
                        Xác nhận xoá
                    </Button>
                </DialogActions>
            </Dialog>

            <Snackbar anchorOrigin={{horizontal: "center", vertical: "top"}} open={open} autoHideDuration={6000} onClose={handleClose} >
                <Alert onClose={handleClose} variant="filled" severity="error" sx={{ width: '100%' }}>
                    Vui lòng chọn dòng cần xoá.
                </Alert>
            </Snackbar>
        </>


    )
}

export default DeleteMuilMovie;