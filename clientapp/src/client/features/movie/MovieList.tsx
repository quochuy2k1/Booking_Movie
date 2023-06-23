import { useCallback, useEffect, useMemo } from "react"
import { Link } from "react-router-dom"
import { Card, Grid, Tab, Image, Button, Icon, Container } from "semantic-ui-react"
import { useAppDispatch, useAppSelector } from "../../../app/hooks"
import { MoviePagingRequest } from "../../../services/movie.service"
import { GetAllMoviePagingAsync } from "../../../slices/movie/movieSlice"


const MovieList: React.FC<{}> = ({}) =>{

    const dispatch = useAppDispatch();
    const { movies } = useAppSelector((state) => state.movie)

    // const [movieBG, setMovieBG] = useState({} as MovieModel);


    const GetAllMovie = useMemo(() => (request?: MoviePagingRequest): void => {
        try {
            dispatch(GetAllMoviePagingAsync({ PageIndex: request?.PageIndex || 0, PageSize: request?.PageSize || 20}))
        } catch (error) {

        }
    }, [dispatch])


    useEffect(() => {

        if(movies.length <= 0){
            GetAllMovie();
        }
    }, [GetAllMovie, movies.length])
    const PlayingList = <Grid className="pt-2" >
        {movies && movies.filter(x => x.isShowing === true).map((movie, idx) => (
            <Grid.Column key={idx} computer={4} tablet={4} mobile={8}>
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
    const CommingSoonList = <Grid className="pt-2" >
        {movies && movies.filter(x => x.commingSoon === true).map((movie, idx) => (
            <Grid.Column key={idx} computer={4} tablet={4} mobile={8}>
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
        <Container>
             <Tab className="pt-1" menu={{ secondary: true, pointing: true }} panes={[
                {
                    menuItem: 'Phim đang chiếu',
                    render: () => <Tab.Pane className="bg-transparent" attached={false}> {PlayingList} </Tab.Pane>,
                },
                {
                    menuItem: 'Phim sắp chiếu',
                    render: () => <Tab.Pane className="bg-transparent" attached={false}>{CommingSoonList}</Tab.Pane>,
                },]} />
        </Container>
    )
}

export default MovieList;