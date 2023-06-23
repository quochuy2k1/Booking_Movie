import React from 'react'
import { Alert, Checkbox, Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Grid, InputLabel, List, ListItem, ListItemButton, ListItemIcon, ListItemText, Slider, Snackbar, useMediaQuery, useTheme } from "@mui/material";
import { Button } from 'semantic-ui-react';

interface IProps {
    open: boolean,
    columns: number[],
    onSubmit?: (colDelete: number[]) => void,
    handlClose?: () => void
}

function valuetext(value: number) {
    return `${value}`;
}


const DeleteByColumnAction: React.FC<IProps> = (props) => {

    const theme = useTheme();
    const fullScreen = useMediaQuery(theme.breakpoints.down('md'));
    const [checked, setChecked] = React.useState<number[]>([]);

    const handleToggle = (value: number) => () => {
      const currentIndex = checked.indexOf(value);
      const newChecked = [...checked];
  
      if (currentIndex === -1) {
        newChecked.push(value);
      } else {
        newChecked.splice(currentIndex, 1);
      }
  
      setChecked(newChecked);
    };


    const handleConfirm = () => {
        props.onSubmit && props.onSubmit(checked);
        props.handlClose && props.handlClose();
    }
    return (
        <Dialog
            fullScreen={fullScreen}
            open={props.open}
            fullWidth
            onClose={props.handlClose}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title" className='text-3xl font-semibold'>
                {"Chọn dòng cần xóa"}
            </DialogTitle>
            <DialogContent>
                <DialogContentText id="alert-dialog-description">
                Cột sẽ xóa theo cột mà bạn chỉ định
                </DialogContentText>

                <Container className='flex flex-col py-5'>
                    <List sx={{ width: '100%', maxWidth: 360, bgcolor: 'background.paper' }}>
                        {props.columns.map((value) => {
                            const labelId = `checkbox-list-label-${value}`;

                            return (
                                <ListItem
                                    key={value}
                                    
                                    disablePadding
                                >
                                    <ListItemButton role={undefined} onClick={handleToggle(value)} dense>
                                        <ListItemIcon>
                                            <Checkbox
                                                edge="start"
                                                checked={checked.indexOf(value) !== -1}
                                                tabIndex={-1}
                                                disableRipple
                                                inputProps={{ 'aria-labelledby': labelId }}
                                            />
                                        </ListItemIcon>
                                        <ListItemText id={labelId} primary={`Cột ${value}`} />
                                    </ListItemButton>
                                </ListItem>
                            );
                        })}
                    </List>
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

export default DeleteByColumnAction;