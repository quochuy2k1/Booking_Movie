import { useCallback, useEffect, useState } from "react";
import { Link, useLocation, useNavigate, useParams } from "react-router-dom";
import { Header, Image, List, Button, Icon, Container } from "semantic-ui-react"
import { GetAllMoviePaging } from "../../../services/movie.service";
import { MovieModel } from "../../../slices/movie/movieSlice";





const MovieSlideBar: React.FC<{}> = (props) => {

    const navigate = useNavigate()
    const [movieNowShowing, setMovieNowShowing] = useState<MovieModel[]>();

    const GetMovieNowShowing = useCallback(async () => {
        const result = await GetAllMoviePaging({ PageIndex: 3, PageSize: 3 });
        setMovieNowShowing([...result.data.result]);
    }, []);
    useEffect(() => {
       
        GetMovieNowShowing();
    }, [GetMovieNowShowing])

    const handleNavigation = (movieId: number) =>{
        navigate(`/movie/${movieId}`, { replace: true})

    }

    return (
        <>
            <Container className="flex flex-col">
                <Header as='h3' dividing className="text-white">
                    Phim đang chiếu
                </Header>
                <List>
                    {movieNowShowing && movieNowShowing.map((movie, idx) => (
                        <List.Item key={idx} className="pb-5" >
                            <Image src={movie.imageBackground} />
                            {/* <Header  className="text-blue-600 py-2 text-xl" ><Link  to={`/movie/${movie.id}`} replace={false}>{movie.name}</Link></Header> */}
                            <Header  className="text-blue-600 py-2 text-xl" as={"a"} onClick={ () => handleNavigation(movie.id)} >{movie.name}</Header>
                        </List.Item>
                    ))}

                </List>
                <Button icon size="large" color="orange" labelPosition='right' className="w-1/2 self-end">
                    Xem thêm
                    <Icon name={'arrow right' } />
                </Button>
            </Container>

        </>
    )

}

export default MovieSlideBar;