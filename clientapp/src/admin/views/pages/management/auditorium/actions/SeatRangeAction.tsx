import React from 'react'
import { Alert, Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Grid, InputLabel, Slider, Snackbar, useMediaQuery, useTheme } from "@mui/material";
import { Button } from 'semantic-ui-react';

interface IProps {
    open: boolean,
    onSubmit?: (colRange: number, rowRange: number) => void,
    handlClose?: () => void
}

function valuetext(value: number) {
    return `${value}`;
}


const SeatRangeAction: React.FC<IProps> = (props) => {

    const theme = useTheme();
    const fullScreen = useMediaQuery(theme.breakpoints.down('md'));
    const [colRange, setColRange] = React.useState<number>(14);
    const [rowRange, setRowRange] = React.useState<number>(12);

    const handleColChange = (event: Event, newValue: number | number[]) => {
        setColRange(newValue as number);
    };
    const handleRowChange = (event: Event, newValue: number | number[]) => {
        setRowRange(newValue as number);
    };


    const handleConfirm = () => {
        props.onSubmit && props.onSubmit(colRange, rowRange);
        props.handlClose && props.handlClose();
    }
    return (
        <Dialog
            fullScreen={fullScreen}
            open={props.open}
            onClose={props.handlClose}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title" className='text-3xl font-semibold'>
                {"Chọn phạm vi dòng và cột"}
            </DialogTitle>
            <DialogContent>
                <DialogContentText id="alert-dialog-description">
                    Khi chọn ghế sẽ được hiển thị theo dòng và cột chỉ định
                </DialogContentText>

                <Container className='flex flex-col py-5'>
                    <Grid container alignItems="center" spacing={0} sx={{ margin: "0px 0px" }}>
                        <Grid item xs={12} md={4}>
                            <InputLabel sx={{ fontSize: 14, color: '#333' }}>Cột</InputLabel>
                        </Grid>
                        <Grid item xs={12} md={8}>
                            <Slider
                                getAriaLabel={() => 'Phạm vi cột'}
                                value={colRange}
                                onChange={handleColChange}
                                valueLabelDisplay="auto"
                                marks
                                min={1}
                                max={14}
                                getAriaValueText={valuetext}
                            />
                        </Grid>
                    </Grid>
                    <Grid container alignItems="center" spacing={0} sx={{ margin: "0px 0px" }}>
                        <Grid item xs={12} md={4}>
                            <InputLabel sx={{ fontSize: 14, color: '#333' }}>Dòng</InputLabel>
                        </Grid>
                        <Grid item xs={12} md={8}>
                            <Slider
                                getAriaLabel={() => 'Phạm vi dòng'}
                                value={rowRange}
                                onChange={handleRowChange}
                                valueLabelDisplay="auto"
                                marks
                                min={1}
                                max={23}
                                getAriaValueText={valuetext}
                            />
                        </Grid>
                    </Grid>
                </Container>
            </DialogContent>
            <DialogActions>
                <Button color='blue' onClick={handleConfirm} autoFocus>Xác nhận lưu</Button>
                <Button color='red' onClick={props.handlClose} >
                    Huỷ bỏ lưu
                </Button>
            </DialogActions>
        </Dialog>
    )
}

export default SeatRangeAction;