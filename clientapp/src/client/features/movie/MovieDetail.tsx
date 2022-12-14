import moment from "moment";
import React, { useCallback, useEffect, useState } from "react";
import ReactPlayer from "react-player";
import { useParams } from "react-router-dom";
import { Container, Grid, Header, Label, Image, Button, Segment, Dimmer, Portal } from "semantic-ui-react";
import { useAppSelector } from "../../../app/hooks";
import TicketPurchaseForm from "../../components/actors/TicketPurchaseForm";
import MovieSlideBar from "../../components/movies/MovieSlideBar";
import { GetDetailMovie } from "../../../services/movie.service";
import Screening from "../screenings/Screening";
import { MovieModel } from "../../../slices/movie/movieSlice";

// interface moviePropsParams {
//     movieId: string
// }



const MovieDetail: React.FC<{}> = () => {
    const { movieId } = useParams<string>()
    var movie_detail: MovieModel = useAppSelector(state => state.movie.movies.find(movie => movie.id === Number.parseInt(movieId!)))!;
    const [movie, setMovie] = useState<MovieModel>(movie_detail);
    // open trailer video
    const [open, setOpen] = useState(false);
    // hover trailer video
    const [isHover, setIsHover] = useState(false);

    const GetMovie = useCallback(async () => {
        const result = await GetDetailMovie(movieId!);
        setMovie(result.data);

    }, [movieId]);

    useEffect(() => {
        if (!movie) {
            GetMovie();
        }
    }, [GetMovie, movie])

    useEffect(() => {
        console.log(movie, "id movie")
    });


    // open video trailer
    const handleOpen = () => setOpen(true)
    const handleClose = () => setOpen(false)

    // hover video trailer
    const MouseOverTrailer = () => setIsHover(true)
    const MouseOutTrailer = () => setIsHover(false)

    // thông tin movie

    const content = (
        <Portal
            closeOnTriggerClick
            onOpen={handleOpen}
            onClose={handleClose}
            openOnTriggerClick
            trigger={
                <Button
                    size="huge"
                    className="absolute top-1/2 left-1/2 translate-x-neg-1/2 translate-y-neg-1/2"
                    color="orange"
                    circular
                    icon={open ? 'pause' : 'play'}
                />

            }

        >
            <Segment
                style={{ left: "50%", position: 'fixed', top: '20%', transform: "translate(-50%,-20%)", zIndex: 1001, width: '50%' }}
            >


                <ReactPlayer
                    width={"100%"}
                    height={"100%"}
                    url={movie?.videoTrailer}
                    playing={true}
                    muted={true}
                    controls
                    className="object-cover"
                // onReady={(player) => {setIsPlaying(true)}}
                // onEnded={() => setIsPlaying(false)}
                />
            </Segment>
        </Portal>
    )
    const Movie = <Grid>
        <Grid.Column width={6}>
            <Dimmer.Dimmable
                as={Image}
                dimmed={isHover}
                dimmer={{ active: isHover, content: content }}
                onMouseEnter={MouseOverTrailer}
                onMouseLeave={MouseOutTrailer}
                rounded
                src={movie?.imagePreview}
            />

        </Grid.Column>
        <Grid.Column width={10} className='text-white'>
            <Header as='h2' className='text-blue-600 className="leading-loose"' >{movie?.name}</Header>
            <p className="leading-loose text-base"><Label as={"span"} color="grey" content={movie?.duration + " phút"} icon="clock" size="large" /></p>
            <p className="leading-loose text-base">
                Ngày công chiếu: {moment(movie?.releaseDate).format("DD/MM/YYYY")}
            </p>
            <p className="leading-loose text-base">
                Quốc gia: {movie?.nationality}
            </p>
            <p className="leading-loose text-base">
                Diễn viên: {movie?.actors}
            </p>
            <p className="leading-loose text-base">
                Nhà sản xuất: {movie?.producer}
            </p>
            <p className="leading-loose text-base">
                Đạo diễn loại: {movie?.directors}
            </p>
            <p className="leading-loose text-base">
                Thể loại: {movie?.categories}
            </p>
        </Grid.Column>

    </Grid>

    const ContentMovie = <>
        <Header as='h3' dividing className="text-white">
            Nội dung phim
        </Header>
        <p className="text-white text-base" dangerouslySetInnerHTML={{ __html: movie?.content }}></p>
    </>

    return (
        <>
            <Dimmer.Dimmable dimmed={open} >
                <Container>
                    <Grid>
                        {/* right bar */}
                        <Grid.Column computer={10} mobile={16}>
                            {/* chi tiết phim */}
                            {Movie}
                            {/* Nội dung phim */}
                            {ContentMovie}
                            {/* Lịch chiếu phim */}
                            {movie && <Screening id={movie!.id.toString()}></Screening>}
                        </Grid.Column>

                        {/* left bar */}
                        <Grid.Column computer={6} mobile={16}>
                            <TicketPurchaseForm></TicketPurchaseForm>
                            <MovieSlideBar></MovieSlideBar>
                        </Grid.Column>
                    </Grid>

                </Container>
                <Dimmer active={open} onClickOutside={handleClose} page />
            </Dimmer.Dimmable>
        </>
    )
}

export default MovieDetail;