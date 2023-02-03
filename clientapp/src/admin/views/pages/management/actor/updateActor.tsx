import { Alert, Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Snackbar, useMediaQuery, useTheme } from "@mui/material";
import { Editor } from "@tinymce/tinymce-react";
import React, { useEffect, useMemo, useState } from "react";
import { Button, DropdownProps, Form, Input } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../../../app/hooks";
import { Actor, UpdateActorAsync, emptyActorStatus } from "../../../../../slices/actor/actorSlice";
import { CategoryModel } from "../../../../../slices/categories/categorySlice";
import { DirectorModel } from "../../../../../slices/directors/directorSlice";
import { emptyMovieStatus } from "../../../../../slices/movie/movieSlice";
import { GetNationalitiesAsync } from "../../../../../slices/nationalities/nationalitySlice";
import DropdownComponent, { dataDropdownOption } from "../../../../ui-component/common/Dropdown/DropdownComponent";
import moment from "moment";



const AcceptedImgFileType: string = ".jpg, .png, image/*"

const AcceptedVideoFileType: string = "video/*"


const dataStatusOption: dataDropdownOption[] = [
    {
        key: 1,
        text: "Phim đang chiếu",
        value: true
    },
    {
        key: 2,
        text: "Phim sắp chiếu",
        value: false
    }
]

interface IUpdateActorProps {
    isOpen: boolean,
    setOpenUpdateActor: (open: boolean) => void,
    [k: string]: any
}

const UpdateActor: React.FC<IUpdateActorProps> = (props) => {

    const theme = useTheme();
    const dispatch = useAppDispatch();
    const fullScreen = useMediaQuery(theme.breakpoints.down('md'));
    const error = useAppSelector(state => state.actor.error);
    const status_update = useAppSelector(state => state.actor.status);

    const token = localStorage.getItem("token");
    // input variable



    const [name, setName] = useState<string>(props.name || "");
    const [height, setHeight] = useState<number>(props.height || 0);
    const [dateOfBirth, setDateOfBirth] = useState<string>(moment(props.dateOfBirth).toISOString().substring(0, 10) || "");
    const [description, setDescription] = useState<string>(props.description || "");
    const [image, setImage] = useState<File | null>(null);


    const [nationality, setNationality] = useState<string | null>(null);


    // tiny editor

    const editorRef = React.useRef<any>(null);
    // dropdown category 
    const [openUpdate, setOpenUpdate] = useState(props.isOpen);


    // 
    const nationalities = useAppSelector(state => state.nationality.nationalities);
    const status_nationalities = useAppSelector(state => state.nationality.status);
    const [dataNationalitiesOption, setDataNationalitiesOption] = useState<dataDropdownOption[] | boolean>([] as dataDropdownOption[]);




    // 
    const [messageUpdate, setMessageUpdate] = useState<string>("");
    const [open, setOpen] = React.useState(false);



    // const GetActorDetailAsync = useCallback(async () => {

    //     const result = await GetDetailMovieManager(props.id);

    //     console.log(result.data, "data option actoe update")
    //     return result;
    // }, []);

    const handleClickUpdateOpen = useMemo(() => () => {
        // setOpenUpdate(true);


        const dataNationalitiesOption: dataDropdownOption[] | boolean = [...nationalities].map(nationality => (
            {
                key: nationality.id,
                text: nationality.name,
                value: nationality.id
            }
        ));
        setDataNationalitiesOption(dataNationalitiesOption);



    }, []);




    useEffect(() => {


        if (openUpdate) {
            // dispatch(GetAllActorAsync());
            // dispatch(GetCategoriesAsync());
            dispatch(GetNationalitiesAsync());
            // dispatch(GetProducerAsync());
            // dispatch(GetDirectorAsync());
            // handleClickUpdateOpen();
            handleClickUpdateOpen();

        }


        if (status_update === "updated") {
            setMessageUpdate("Cập nhập thành công")
            setOpen(true);
            dispatch(emptyActorStatus())
        }

        else if (status_update === "failed") {
            setMessageUpdate(error);
            setOpen(true);

        }
        // console.log(props.producer, "inside useeffect")

        // console.log(props)

    }, [status_update, dispatch, handleClickUpdateOpen]);


    const handleUpdateClose = () => {
        setOpenUpdate(false);
        props.setOpenUpdateActor(false);
    };
    const handleCancelUpdate = () => {
        setOpenUpdate(false);
        props.setOpenUpdateActor(false);

    };
    const handleConfirmUpdate = () => {
        // setOpenUpdate(false);
        // console.log(props.actors.split(", "), "actors props")
        // console.log((actors && actors!.length > 0) && actors?.filter(actor => props.actors.split(", ").indexOf(actor.name) > -1).map((actor: Actor) => actor.id)
        //     , "hihi")
        dispatch(UpdateActorAsync({ id: props.id, name: name, nationality: nationality, height: height, dateOfBirth: new Date(dateOfBirth).toISOString(), description: description, image: image as File, token: token! }))
        console.log(name, height, dateOfBirth, description, image, nationality);


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
            {/* <Button icon color='blue' onClick={} labelPosition='right'>
                <Icon name='add' /> Thêm mới
            </Button> */}
            <Dialog
                fullScreen={fullScreen}
                open={openUpdate}
                onClose={handleUpdateClose}
                aria-labelledby="alert-dialog-title"
                aria-describedby="alert-dialog-description"
            >
                <DialogTitle id="alert-dialog-title" className='text-3xl font-semibold'>
                    {`Cập nhật phim "`}<span style={{ color: "#f97316" }}>{props.name}</span>{`"`}
                </DialogTitle>
                <DialogContent>
                    <DialogContentText id="alert-dialog-description">
                        Khi cập nhật bộ phim sẽ cập nhật
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
                                    value={name}
                                // onChange={(event, data) => { setName(data.value); setAlias(toLowerCaseNonAccentVietnamese(data.value)) }}

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
                                    dataOption={dataNationalitiesOption as dataDropdownOption[]}
                                    defaultValue={nationalities && nationalities.find(nationality => props.nationalityId === nationality.name)?.id}
                                    onSelectChange={HandleNationalityChange}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Editor
                                    apiKey='yillg49dt4io6vjxyvs8k26ldhgtxqnmurmteil8v2j6mljb'
                                    onInit={(evt, editor) => editorRef.current = editor}
                                    initialValue={description ? description : "<p>Nhập tiểu sử.</p>"}
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
                    <Button color='blue' onClick={handleConfirmUpdate}>Xác nhận lưu</Button>
                    <Button color='red' onClick={handleCancelUpdate} autoFocus>
                        Huỷ bỏ lưu
                    </Button>
                </DialogActions>
            </Dialog>

            <Snackbar open={open} anchorOrigin={{ horizontal: "center", vertical: "top" }} autoHideDuration={6000} onClose={handleClose}>
                <Alert onClose={handleClose} severity={error ? "error" : status_update === "updated" ? "success" : undefined} sx={{ width: '100%' }}>
                    {messageUpdate}
                </Alert>
            </Snackbar>
        </>

    )
}
export default UpdateActor;

