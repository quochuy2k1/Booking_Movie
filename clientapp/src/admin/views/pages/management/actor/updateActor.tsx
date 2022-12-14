import { Alert, Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Snackbar, useMediaQuery, useTheme } from "@mui/material";
import { GridSelectionModel } from "@mui/x-data-grid";
import { Editor } from "@tinymce/tinymce-react";
import moment from "moment";
import React, { useCallback, useEffect, useMemo, useState } from "react";
import { async } from "rxjs";
import { Button, DropdownProps, Form, Icon, Input } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../../../app/hooks";
import { GetAllActor } from "../../../../../services/actor.service";
import { GetCasts, GetDetailMovie, GetMovieCategories, GetMovieDirectors } from "../../../../../services/movie.service";
import { Actor, GetAllActorAsync } from "../../../../../slices/actor/actorSlice";
import { CategoryModel, GetCategoriesAsync } from "../../../../../slices/categories/categorySlice";
import { DirectorModel, GetDirectorAsync } from "../../../../../slices/directors/directorSlice";
import { CreateNewMovieAsync, emptyMovieStatus, UpdateMovieAsync } from "../../../../../slices/movie/movieSlice";
import { GetNationalitiesAsync } from "../../../../../slices/nationalities/nationalitySlice";
import { GetProducerAsync, ProducerModel } from "../../../../../slices/producers/producerSlice";
import DropdownComponent, { dataDropdownOption } from "../../../../ui-component/common/Dropdown/DropdownComponent";
import { toLowerCaseNonAccentVietnamese } from "../../../../utils/NonAccentVietnamese";



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

interface IUpdateMovieProps {
    isOpen: boolean,
    setOpenUpdateMovie: (open: boolean) => void,
    [k: string]: any
}

const UpdateMovie: React.FC<IUpdateMovieProps> = (props) => {

    const theme = useTheme();
    const dispatch = useAppDispatch();
    const fullScreen = useMediaQuery(theme.breakpoints.down('md'));
    const error = useAppSelector(state => state.movie.error);
    const status_update = useAppSelector(state => state.movie.status);

    const token = localStorage.getItem("token");
    // input variable


    const [name, setName] = useState<string>(props.name);
    const [duration, setDuration] = useState<number>(props.duration);
    const [releaseDate, setReleaseDate] = useState<string>(moment(props.releaseDate).toISOString().substring(0, 10));
    const [content, setContent] = useState<string>(props.content);
    const [status, setStatus] = useState<boolean>(false);
    const [image, setImage] = useState<File | string | null>(null);

    
    const [nationality, setNationality] = useState<string | null>(null);


    // tiny editor

    const editorRef = React.useRef<any>(null);
    // dropdown category 
    const [openUpdate, setOpenUpdate] = useState(props.isOpen);

    const categories = useAppSelector(state => state.category.categories);
    const status_categories = useAppSelector(state => state.category.status); 
    const [dataCategoriesOption, setDataCategoriesOption] = useState<dataDropdownOption[] | boolean>([] as dataDropdownOption[]);

    // 
    const nationalities = useAppSelector(state => state.nationality.nationalities);
    const status_nationalities = useAppSelector(state => state.nationality.status);
    const [dataNationalitiesOption, setDataNationalitiesOption] = useState<dataDropdownOption[] | boolean>([] as dataDropdownOption[]);


    // 
    const producers = useAppSelector(state => state.producer.producers);
    const status_producers = useAppSelector(state => state.producer.status);
    const [dataProducersOption, setDataProducersOption] = useState<dataDropdownOption[] | boolean>([] as dataDropdownOption[]);

    // 
    const directors = useAppSelector(state => state.director.directors);
    const status_directors = useAppSelector(state => state.director.status);
    const [dataDirectorsOption, setDataDirectorsOption] = useState<dataDropdownOption[] | boolean>([] as dataDropdownOption[]);

    // 

    const actors = useAppSelector(state => state.actor.actors);
    const statusActors = useAppSelector(state => state.actor.status);
    const [dataActorsOption, setDataActorsOption] = useState<dataDropdownOption[] | boolean>([] as dataDropdownOption[]);

    // 
    const [messageUpdate, setMessageUpdate] = useState<string>("");
    const [open, setOpen] = React.useState(false);

    //
    const GetActorsAsync = useCallback(async () => {

        const result = await GetAllActor();
        return result;
    }, []);

    // const GetActorDetailAsync = useCallback(async () => {

    //     const result = await GetDetailMovieManager(props.id);

    //     console.log(result.data, "data option actoe update")
    //     return result;
    // }, []);

    const handleClickUpdateOpen = useMemo(() => () => {
        // setOpenUpdate(true);

        const dataActorsOption:  dataDropdownOption[] | boolean =  [...actors].map(actor => (
            {
                key: actor.id,
                text: actor.name,
                value: actor.id
            }
        ))

        setDataActorsOption(dataActorsOption);

        const dataCategoriesOption: dataDropdownOption[] | boolean =  [...categories].map(category => (
            {
                key: category.id,
                text: category.name,
                value: category.id
            }
        ));
        setDataCategoriesOption(dataCategoriesOption);

        const dataProducersOption: dataDropdownOption[] | boolean =  [...producers].map(producer => (
            {
                key: producer.id,
                text: producer.name,
                value: producer.id
            }
        ));
        setDataProducersOption(dataProducersOption);

        const dataDirectorsOption: dataDropdownOption[] | boolean =  [...directors].map(director => (
            {
                key: director.id,
                text: director.name,
                value: director.id
            }
        ));
        setDataDirectorsOption(dataDirectorsOption);

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
            // dispatch(GetNationalitiesAsync());
            // dispatch(GetProducerAsync());
            // dispatch(GetDirectorAsync());
            // handleClickUpdateOpen();
            handleClickUpdateOpen();

        }


        if (status_update === "updated") {
            setMessageUpdate("Cập nhập thành công")
            setOpen(true);
            dispatch(emptyMovieStatus())
        }

        else if (status_update === "failed") {
            setMessageUpdate(error);
            setOpen(true);

        }
        console.log(props.producer, "inside useeffect")



    }, [ status_update, dispatch, handleClickUpdateOpen ]);

    
    const handleUpdateClose = () => {
        setOpenUpdate(false);
        props.setOpenUpdateMovie(false);
    };
    const handleCancelUpdate = () => {
        setOpenUpdate(false);
        props.setOpenUpdateMovie(false);

    };
    const handleConfirmUpdate = () => {
        // setOpenUpdate(false);
        console.log(props.actors.split(", "), "actors props")
        console.log((actors && actors!.length > 0) && actors?.filter(actor => props.actors.split(", ").indexOf(actor.name) > -1).map((actor: Actor) => actor.id)
            , "hihi")
        // dispatch(UpdateMovieAsync({ id: props.id, name: name, alias: alias, duration, releaseDate: new Date(releaseDate).toISOString(), content, status, imageBackground: imgBackground! as File, imagePreview: imgPreview! as File, videoTrailer: videoTrailer! as File, producer: producer!, nationality: nationality!, categoryId: category!, directorId: director!, actorId: actor!, token: token! }))
        // console.log(name, duration, releaseDate, content, status, imgPreview, imgBackground, videoTrailer, actor, director, producer, nationality, category, content);

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
                    {`Cập nhật phim "`}<span style={{color: "#f97316"}}>{props.name}</span>{`"`}
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
                                    icon='amilia'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Bí danh (Alias)' }}
                                    labelPosition='right'
                                    placeholder='Nhập bí danh'
                                    // value={alias}
                                    // onChange={(event, data) => { setAlias(data.value) }}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='time'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Thời lượng (phút)', }}
                                    labelPosition='right'
                                    placeholder='Nhập thời lượng'
                                    type='number'
                                    value={duration}
                                    onChange={(event, data) => { setDuration(Number.parseInt(data.value)) }}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='calendar alternate'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Ngày công chiếu' }}
                                    labelPosition='right'
                                    placeholder='Ngày công chiếu'
                                    type='date'
                                    value={releaseDate}
                                    onChange={(event, data) => { setReleaseDate(data.value) }}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='file image'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Hình review' }}
                                    labelPosition='right'
                                    placeholder='Hình review'
                                    type='file'
                                    accept={AcceptedImgFileType}
                                    // onChange={(event, data) => { setImgPreview(event.target.files![0]); console.log(event.target.files![0], "imgage") }}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='file image'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Hình background' }}
                                    labelPosition='right'
                                    placeholder='Hình background'
                                    accept={AcceptedImgFileType}
                                    type='file'
                                    // onChange={(event, data) => setImgBackground(event.target.files![0])}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='file video'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Video trailer' }}
                                    labelPosition='right'
                                    placeholder='Video trailer'
                                    type='file'
                                    accept={AcceptedVideoFileType}
                                    // onChange={(event, data) => setVideoTrailer(event.target.files![0])}
                                />
                            </Form.Field>

                            <Form.Field>
                                <DropdownComponent
                                    loading={status_categories === "loading"}
                                    placeholder='Chọn danh mục phim'
                                    multiple
                                    selection
                                    search
                                    dataOption={dataCategoriesOption as dataDropdownOption[]}

                                    defaultValue={categories && categories.filter(category => props.categories.split(", ").indexOf(category.name) > -1).map((category: CategoryModel) => category.id)}
                                    // onSelectChange={HandleCategoryChange}
                                />
                            </Form.Field>


                            <Form.Field>
                                <DropdownComponent
                                    loading={statusActors === "loading"}
                                    placeholder='Chọn diễn viên'
                                    multiple
                                    selection
                                    search
                                    dataOption={dataActorsOption as dataDropdownOption[]}

                                    defaultValue={actors && actors.filter(actor => props.actors.split(", ").indexOf(actor.name) > -1).map((actor: Actor) => actor.id)}
                                    // onSelectChange={HandleActorChange}
                                />
                            </Form.Field>

                            <Form.Field>
                                <DropdownComponent
                                    loading={status_directors === "loading"}
                                    placeholder='Chọn đạo diễn'
                                    multiple
                                    selection
                                    search
                                    dataOption={dataDirectorsOption as dataDropdownOption[]}

                                    defaultValue={directors && directors.filter(director => props.directors.split(", ").indexOf(director.name) > -1).map((director: DirectorModel) => director.id)}
                                    // onSelectChange={HandleDirectorChange}
                                />
                            </Form.Field>
                            <Form.Field>
                                <DropdownComponent
                                    loading={status_producers === "loading"}
                                    placeholder='Chọn nhà sản xuất'
                                    selection
                                    search
                                    dataOption={dataProducersOption as dataDropdownOption[]}

                                    defaultValue={producers && producers.find(producer => props.producer === producer.name)?.id}
                                    // onSelectChange={HandleProducerChange}
                                />
                            </Form.Field>


                            <Form.Field>
                                <DropdownComponent
                                    loading={status_nationalities === "loading"}
                                    placeholder='Chọn quốc gia'
                                    selection
                                    search
                                    dataOption={dataNationalitiesOption as dataDropdownOption[]}

                                    defaultValue={nationalities && nationalities.find(nationality => props.nationality === nationality.name)?.id}
                                    onSelectChange={HandleNationalityChange}
                                />
                            </Form.Field>

                            <Form.Field>
                                <DropdownComponent
                                    placeholder='Trạng thái'
                                    selection
                                    dataOption={dataStatusOption}
                                    defaultValue={props.status}
                                    onSelectChange={(event, data) => setStatus(data.value as boolean)}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Editor
                                    apiKey='yillg49dt4io6vjxyvs8k26ldhgtxqnmurmteil8v2j6mljb'
                                    onInit={(evt, editor) => editorRef.current = editor}
                                    initialValue={content ? content : "<p>Nhập nội dung phim.</p>"}
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
                                    onEditorChange={(newText) => { setContent(newText); }}
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
export default UpdateMovie;

