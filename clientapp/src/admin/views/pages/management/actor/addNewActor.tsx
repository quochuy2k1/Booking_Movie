import { Alert, Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Snackbar, useMediaQuery, useTheme } from "@mui/material";
import { Editor } from "@tinymce/tinymce-react";
import React, { useEffect, useMemo, useState } from "react";
import { Button, DropdownProps, Form, Icon, Input } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../../../app/hooks";
import { CreateNewActorAsync, emptyActorStatus } from "../../../../../slices/actor/actorSlice";
import DropdownComponent, { dataDropdownOption } from "../../../../ui-component/common/Dropdown/DropdownComponent";



const AcceptedImgFileType: string = ".jpg, .png, image/*"

const AddNewMovie: React.FC = () => {

    const theme = useTheme();
    const dispatch = useAppDispatch();
    const fullScreen = useMediaQuery(theme.breakpoints.down('md'));
    const token = localStorage.getItem("token");
    const status_create = useAppSelector(state => state.actor.status);
    const error = useAppSelector(state => state.actor.error);
    const [open, setOpen] = React.useState(false);
    const [messageCreate, setMessageCreate] = useState<string>("");
    // input variable

  
    const [name, setName] = useState<string>("");
    const [height, setHeight] = useState<number>(0);
    const [dateOfBirth, setDateOfBirth] = useState<string>("");
    const [description, setDescription] = useState<string>("");
    const [image, setImage] = useState<File | null>(null);

   
    const [nationality, setNationality] = useState<string | null>(null);


    // tiny editor

    const editorRef = React.useRef<any>(null);
    // dropdown category 
    const [openAdd, setOpenAdd] = useState(false);

  

    // 
    const nationalities = useAppSelector(state => state.nationality.nationalities);
    const status_nationalities = useAppSelector(state => state.nationality.status);
    const [dataNationalitiesOption, setDataNationalitiesOption] = useState<dataDropdownOption[]>();



    // 

    // const GetActorsAsync = useCallback(async () => {

    //     const result = await GetAllActor();
       
    // }, []);

    useEffect(() => {

       
        if (status_create === "added") {
            setMessageCreate("Thêm thành công")
            setOpen(true);
            dispatch(emptyActorStatus())
        }

        else if (status_create === "failed") {
            setMessageCreate(error);
            setOpen(true);

        }

    }, [dispatch, status_create]);

    const handleClickAddOpen = useMemo(() => () => {
        setOpenAdd(true);

        

        const dataNationalitiesOption: dataDropdownOption[] = [...nationalities].map(nationality => (
            {
                key: nationality.id,
                text: nationality.name,
                value: nationality.id
            }
        ));
        setDataNationalitiesOption(dataNationalitiesOption);

        
    }, [nationalities]);

    const handleAddClose = () => {
        setOpenAdd(false);
    };
    const handleCancelAdd = () => {
        setOpenAdd(false);
    };
    const handleConfirmAdd = () => {
        // setOpenAdd(false);
        dispatch(CreateNewActorAsync({name: name,  height: (height/100), nationality: nationality, dateOfBirth: new Date(dateOfBirth).toISOString(), description: description, image: image, token: token!  }))
        // console.log(name, height, dateOfBirth, description, image, nationality);
    };

   
    const HandleNationalityChange = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        setNationality(data.value as string);

    }


    const handleClose = (event?: React.SyntheticEvent | Event, reason?: string) => {
        if (reason === 'clickaway') {
            return;
        }

        setOpen(false);
    };



    return (
        <>
            <Button icon color='blue' onClick={handleClickAddOpen} labelPosition='right'>
                <Icon name='add' /> Thêm mới
            </Button>
            <Dialog
                fullScreen={fullScreen}
                open={openAdd}
                onClose={handleAddClose}
                aria-labelledby="alert-dialog-title"
                aria-describedby="alert-dialog-description"
            >
                <DialogTitle id="alert-dialog-title" className='text-3xl font-semibold'>
                    {"Thêm mới diễn viên"}
                </DialogTitle>
                <DialogContent>
                    <DialogContentText id="alert-dialog-description">
                        Khi thêm mới bộ diễn viên sẽ thêm mới
                    </DialogContentText>

                    {/* Input field here */}
                    <Container className='pt-5'>
                        <Form size='small'>
                            <Form.Field>
                                <Input
                                    icon='id badge'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Tên' }}
                                    labelPosition='right'
                                    placeholder='Nhập tên'
                                    onChange={(event, data) => { setName(data.value); }}

                                />
                            </Form.Field>

                           

                            <Form.Field>
                                <Input
                                    icon='time'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Chiều cao (m)', }}
                                    labelPosition='right'
                                    placeholder='Nhập chiều cao'
                                    type='number'
                                    value={height}
                                    onChange={(event, data) => { setHeight(Number.parseInt(data.value)) }}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='calendar alternate'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Ngày sinh' }}
                                    labelPosition='right'
                                    placeholder='Ngày sinh'
                                    type='date'
                                    value={dateOfBirth}
                                    onChange={(event, data) => { setDateOfBirth(data.value) }}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='file image'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Hình ảnh' }}
                                    labelPosition='right'
                                    placeholder='Hình ảnh'
                                    type='file'
                                    accept={AcceptedImgFileType}
                                    onChange={(event, data) => { setImage(event.target.files![0]); console.log(event.target.files![0], "imgage") }}
                                />
                            </Form.Field>

                            


                            <Form.Field>
                                <DropdownComponent
                                    loading={status_nationalities === "loading"}
                                    placeholder='Chọn quốc gia'
                                    selection
                                    search
                                    dataOption={dataNationalitiesOption}
                                    onSelectChange={HandleNationalityChange}
                                />
                            </Form.Field>

                           

                            <Form.Field>
                                <Editor
                                    apiKey='yillg49dt4io6vjxyvs8k26ldhgtxqnmurmteil8v2j6mljb'
                                    onInit={(evt, editor) => editorRef.current = editor}
                                    initialValue="<p>Nhập tiểu sử.</p>"
                                    init={{
                                        height: 500,
                                        menubar: false,
                                        plugins: [
                                            'advlist autolink lists link image charmap print preview anchor',
                                            'searchreplace visualblocks code fullscreen',
                                            'insertdatetime media table paste code help wordcount'
                                        ],
                                        toolbar: 'undo redo | formatselect | ' +
                                            'bold italic backcolor | alignleft aligncenter ' +
                                            'alignright alignjustify | bullist numlist outdent indent | ' +
                                            'removeformat | help',
                                        content_style: 'body { font-family:Helvetica,Arial,sans-serif; font-size:14px }'
                                    }}
                                    onEditorChange={(newText) => { setDescription(newText); }}
                                />
                            </Form.Field>


                        </Form>
                    </Container>
                </DialogContent>
                <DialogActions>
                    <Button color='blue' onClick={handleConfirmAdd}>Xác nhận lưu</Button>
                    <Button color='red' onClick={handleCancelAdd} autoFocus>
                        Huỷ bỏ lưu
                    </Button>
                </DialogActions>
            </Dialog>

            <Snackbar open={open} anchorOrigin={{ horizontal: "center", vertical: "top" }} autoHideDuration={6000} onClose={handleClose}>
                <Alert onClose={handleClose} severity={error ? "error" : status_create === "added" ? "success" : undefined} sx={{ width: '100%' }}>
                    {messageCreate}
                </Alert>
            </Snackbar>
        </>

    )
}
export default AddNewMovie;