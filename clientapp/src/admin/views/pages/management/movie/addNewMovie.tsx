import { Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, useMediaQuery, useTheme } from "@mui/material";
import { Editor } from "@tinymce/tinymce-react";
import React, { useCallback, useEffect, useMemo, useState } from "react";
import { Button, DropdownProps, Form, Icon, Input } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../../../app/hooks";
import { GetAllActor } from "../../../../../services/actor.service";
import { Actor } from "../../../../../slices/actor/actorSlice";
import { GetCategoriesAsync } from "../../../../../slices/categories/categorySlice";
import { GetDirectorAsync } from "../../../../../slices/directors/directorSlice";
import { CreateNewMovieAsync } from "../../../../../slices/movie/movieSlice";
import { GetNationalitiesAsync } from "../../../../../slices/nationalities/nationalitySlice";
import { GetProducerAsync } from "../../../../../slices/producers/producerSlice";
import DropdownComponent, { dataDropdownOption } from "../../../../ui-component/common/Dropdown/DropdownComponent";


function toLowerCaseNonAccentVietnamese(str: string) {
    str = str.toLowerCase();

    str = str.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g, "a");
    str = str.replace(/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g, "e");
    str = str.replace(/ì|í|ị|ỉ|ĩ/g, "i");
    str = str.replace(/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g, "o");
    str = str.replace(/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g, "u");
    str = str.replace(/ỳ|ý|ỵ|ỷ|ỹ/g, "y");
    str = str.replace(/đ/g, "d");
    // Some system encode vietnamese combining accent as individual utf-8 characters
    str = str.replace(/\u0300|\u0301|\u0303|\u0309|\u0323/g, ""); // Huyền sắc hỏi ngã nặng 
    str = str.replace(/\u02C6|\u0306|\u031B/g, ""); // Â, Ê, Ă, Ơ, Ư
    return str.replaceAll(" ", "_");
}

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

const AddNewMovie: React.FC = () => {

    const theme = useTheme();
    const dispatch = useAppDispatch();
    const fullScreen = useMediaQuery(theme.breakpoints.down('md'));

    // input variable

    const [alias, setAlias] = useState<string>("");
    const [name, setName] = useState<string>("");
    const [duration, setDuration] = useState<number>(0);
    const [releaseDate, setReleaseDate] = useState<string>("");
    const [content, setContent] = useState<string>("");
    const [status, setStatus] = useState<boolean>(false);
    const [imgPreview, setImgPreview] = useState<File | null>(null);
    const [imgBackground, setImgBackground] = useState<File | null>(null);
    const [videoTrailer, setVideoTrailer] = useState<File | null>(null);

    const [producer, setProducer] = useState<string | null>(null);
    const [nationality, setNationality] = useState<string | null>(null);

    const [actor, setActor] = useState<string[] | undefined>(undefined);
    const [director, setDirector] = useState<string[] | undefined>(undefined);
    const [category, setCategory] = useState<string[] | undefined>(undefined);

    // tiny editor

    const editorRef = React.useRef<any>(null);
    // dropdown category 
    const [openAdd, setOpenAdd] = useState(false);

    const categories = useAppSelector(state => state.category.categories);
    const status_categories = useAppSelector(state => state.category.status);
    const [dataCategoriesOption, setDataCategoriesOption] = useState<dataDropdownOption[]>();

    // 
    const nationalities = useAppSelector(state => state.nationality.nationalities);
    const status_nationalities = useAppSelector(state => state.nationality.status);
    const [dataNationalitiesOption, setDataNationalitiesOption] = useState<dataDropdownOption[]>();


    // 
    const producers = useAppSelector(state => state.producer.producers);
    const status_producers = useAppSelector(state => state.producer.status);
    const [dataProducersOption, setDataProducersOption] = useState<dataDropdownOption[]>();

    // 
    const directors = useAppSelector(state => state.director.directors);
    const status_directors = useAppSelector(state => state.director.status);
    const [dataDirectorsOption, setDataDirectorsOption] = useState<dataDropdownOption[]>();

    // 
    const [actors, setActors] = useState<Actor[]>();
    const [statusActors, setStatusActors] = useState<string>("loading");
    const [dataActorsOption, setDataActorsOption] = useState<dataDropdownOption[]>();

    // 

    const GetActorsAsync = useCallback(async () => {

        const result = await GetAllActor();
        setActors(result.data);
        setStatusActors("idle")
    }, []);

    useEffect(() => {

        dispatch(GetCategoriesAsync());
        dispatch(GetNationalitiesAsync());
        dispatch(GetProducerAsync());
        dispatch(GetDirectorAsync());
        GetActorsAsync();


    }, [dispatch, GetActorsAsync]);

    const handleClickAddOpen = useMemo(() => () => {
        setOpenAdd(true);

        const dataCategoriesOption: dataDropdownOption[] = [...categories].map(category => (
            {
                key: category.id,
                text: category.name,
                value: category.id
            }
        ));
        setDataCategoriesOption(dataCategoriesOption);

        const dataProducersOption: dataDropdownOption[] = [...producers].map(producer => (
            {
                key: producer.id,
                text: producer.name,
                value: producer.id
            }
        ));
        setDataProducersOption(dataProducersOption);

        const dataDirectorsOption: dataDropdownOption[] = [...directors].map(director => (
            {
                key: director.id,
                text: director.name,
                value: director.id
            }
        ));
        setDataDirectorsOption(dataDirectorsOption);

        const dataNationalitiesOption: dataDropdownOption[] = [...nationalities].map(nationality => (
            {
                key: nationality.id,
                text: nationality.name,
                value: nationality.id
            }
        ));
        setDataNationalitiesOption(dataNationalitiesOption);

        const dataActorsOption: dataDropdownOption[] | undefined = actors && [...actors].map(actor => (
            {
                key: actor.id,
                text: actor.name,
                value: actor.id
            }
        ));
        setDataActorsOption(dataActorsOption);
    }, [categories, producers, directors, nationalities, actors]);

    const handleAddClose = () => {
        setOpenAdd(false);
    };
    const handleCancelAdd = () => {
        setOpenAdd(false);
    };
    const handleConfirmAdd = () => {
        // setOpenAdd(false);
        dispatch(CreateNewMovieAsync({name: name, alias: alias, duration,  releaseDate: new Date(releaseDate).toISOString(), content, status, imageBackground: imgBackground!, imagePreview: imgPreview!,  videoTrailer: videoTrailer!, producer: producer!, nationality: nationality!, categoryId: category!, directorId: director!, actorId: actor!  }))
        console.log(name, duration, releaseDate, content, status, imgPreview, imgBackground, videoTrailer, actor, director, producer, nationality, category, content);
    };

    const HandleCategoryChange = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        console.log(data, "data category dropdown change")
        setCategory(data.value as string[])
    }
    const HandleActorChange = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        setActor(data.value as string[]);
    }
    const HandleProducerChange = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        setProducer(data.value as string);

    }
    const HandleNationalityChange = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        setNationality(data.value as string);

    }

    const HandleDirectorChange = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        setDirector(data.value as string[]);

    }
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
                    {"Thêm mới phim"}
                </DialogTitle>
                <DialogContent>
                    <DialogContentText id="alert-dialog-description">
                        Khi thêm mới bộ phim sẽ thêm mới
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
                                    onChange={(event, data) => { setName(data.value); setAlias(toLowerCaseNonAccentVietnamese(data.value)) }}

                                />
                            </Form.Field>

                            <Form.Field>
                                <Input
                                    icon='amilia'
                                    iconPosition='left'
                                    label={{ tag: true, content: 'Bí danh (Alias)' }}
                                    labelPosition='right'
                                    placeholder='Nhập bí danh'
                                    value={alias}
                                    onChange={(event, data) => { setAlias(data.value) }}
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
                                    onChange={(event, data) => { setImgPreview(event.target.files![0]); console.log(event.target.files![0], "imgage") }}
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
                                    onChange={(event, data) => setImgBackground(event.target.files![0])}
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
                                    onChange={(event, data) => setVideoTrailer(event.target.files![0])}
                                />
                            </Form.Field>

                            <Form.Field>
                                <DropdownComponent
                                    loading={status_categories === "loading"}
                                    placeholder='Chọn danh mục phim'
                                    multiple
                                    selection
                                    search
                                    dataOption={dataCategoriesOption}
                                    onSelectChange={HandleCategoryChange}
                                />
                            </Form.Field>

                            <Form.Field>
                                <DropdownComponent
                                    loading={statusActors === "loading"}
                                    placeholder='Chọn diễn viên'
                                    multiple
                                    selection
                                    search
                                    dataOption={dataActorsOption}
                                    onSelectChange={HandleActorChange}
                                />
                            </Form.Field>

                            <Form.Field>
                                <DropdownComponent
                                    loading={status_directors === "loading"}
                                    placeholder='Chọn đạo diễn'
                                    multiple
                                    selection
                                    search
                                    dataOption={dataDirectorsOption}
                                    onSelectChange={HandleDirectorChange}
                                />
                            </Form.Field>
                            <Form.Field>
                                <DropdownComponent
                                    loading={status_producers === "loading"}
                                    placeholder='Chọn nhà sản xuất'
                                    selection
                                    search
                                    dataOption={dataProducersOption}
                                    onSelectChange={HandleProducerChange}
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
                                <DropdownComponent
                                    placeholder='Trạng thái'
                                    selection
                                    dataOption={dataStatusOption}
                                    onSelectChange={(event, data) => setStatus(data.value as boolean)}
                                />
                            </Form.Field>

                            <Form.Field>
                                <Editor
                                    apiKey='yillg49dt4io6vjxyvs8k26ldhgtxqnmurmteil8v2j6mljb'
                                    onInit={(evt, editor) => editorRef.current = editor}
                                    initialValue="<p>Nhập nội dung phim.</p>"
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
                    <Button color='blue' onClick={handleConfirmAdd}>Xác nhận lưu</Button>
                    <Button color='red' onClick={handleCancelAdd} autoFocus>
                        Huỷ bỏ lưu
                    </Button>
                </DialogActions>
            </Dialog>
        </>

    )
}
export default AddNewMovie;