import React, { useCallback, useEffect } from "react";
import { Button, Card, Dropdown, Grid, Header, Icon, Image, Tab } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { MoviePagingRequest } from "../../../services/movie.service";
import { GetAllMoviePagingAsync } from "../../../slices/movie/movieSlice";
import "./movie.css"
import MovieBG from "../../components/movies/MovieBG";
import { Link } from "react-router-dom";




const MovieList: React.FC<{}> = () => {

    const dispatch = useAppDispatch();

    const { movies } = useAppSelector((state) => state.movie)

    // const [movieBG, setMovieBG] = useState({} as MovieModel);


    const GetAllMovie = useCallback(async (request?: MoviePagingRequest): Promise<void> => {
        try {
            console.log(await dispatch(GetAllMoviePagingAsync({ PageIndex: request?.PageIndex || 0, PageSize: request?.PageSize || 16, Status: request?.Status || 0 })))
        } catch (error) {

        }
    }, [dispatch])


    useEffect(() => {

        GetAllMovie();
    }, [GetAllMovie])


    const PlayingList = <Grid className="pt-2" >
        {movies && movies.map((movie, idx) => (
            <Grid.Column key={idx} computer={2} tablet={4} mobile={8}>
                <Card as={Link} to={`/movie/${movie.id}`}>
                    <Image rounded src={movie.imagePreview} wrapped ui={false} />
                    <Card.Content>
                        <Card.Header className="limit-text">{movie.name}</Card.Header>
                        <Card.Meta>Thời lượng: {movie.duration} phút</Card.Meta>
                        <Card.Description>
                            
                        </Card.Description>
                    </Card.Content>
                    <Card.Content extra>
                        <Button icon labelPosition='left'>
                            <Icon name='ticket' />
                            Đặt vé
                        </Button>
                    </Card.Content>
                </Card>
            </Grid.Column>
        ))}
    </Grid>

    return (
        <>

            
            <Grid>
                <Grid.Column width={2} >
                    <Header as={"h1"} className="text-white text-6xl">Phim</Header>
                </Grid.Column>
                <Grid.Column width={2} >
                    <Dropdown
                    className="bg-transparent text-white"
                        placeholder='Thể loại phim'
                        fluid
                        search
                        selection
                        options={[
                            { key: 'af', value: 'af', flag: 'af', text: 'Afghanistan' },
                            { key: 'ax', value: 'ax', flag: 'ax', text: 'Aland Islands' },]}
                    />
                </Grid.Column>
            </Grid>

            
            <MovieBG movies={movies}></MovieBG>

            
            <Tab menu={{ secondary: true, pointing: true }} panes={[
                {
                    menuItem: 'Phim đang chiếu',
                    render: () => <Tab.Pane className="bg-transparent" attached={false}> {PlayingList} </Tab.Pane>,
                },
                {
                    menuItem: 'Phim sắp chiếu',
                    render: () => <Tab.Pane attached={false}>Tab 2 Content</Tab.Pane>,
                },]} />

        </>
    )


}


export default MovieList;

