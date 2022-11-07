import moment from "moment";
import React, { useCallback, useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Container, Grid, Header, Label, Image, Icon } from "semantic-ui-react";
import TicketPurchaseForm from "../../components/actors/TicketPurchaseForm";
import MovieSlideBar from "../../components/movies/MovieSlideBar";
import Screening from "../../components/movies/Sreening";
import { GetDetailMovie } from "../../services/movie.service";

interface moviePropsParams {
    id: string
}

export interface MovieDetailState {
    id: number,
    imagePreview: string,
    imageBackground: string,
    videoTrailer: string,
    name: string,
    releaseDate: string,
    content: string,
    duration: number,
    nationality: string,
    producer: string,
    actors: string,
    categories: string,
    directors: string,
}

const MovieDetail: React.FC<{}> = ({ }) => {
    const { id } = useParams<moviePropsParams>()
    const [movie, setMovie] = useState<MovieDetailState>();


    const GetMovie = useCallback(async () => {
        const result = await GetDetailMovie(id);
        const data: MovieDetailState = result.data;
        setMovie({
            ...data
        })
    }, [id]);

    useEffect(() => {
        GetMovie();
    }, [GetMovie])

    useEffect(() => {
        console.log(movie, "id movie")
    })

    // thông tin actor
    const Movie = <Grid>
        <Grid.Column width={6}>
            <Image rounded src={movie?.imagePreview} />
        </Grid.Column>
        <Grid.Column width={10} className='text-white'>
            <Header as='h2' className='text-blue-600 className="leading-loose"' >{movie?.name}</Header>
            <p className="leading-loose"><Label color="grey" content={movie?.duration + " phút"} icon="clock" size="large"></Label></p>
            <p className="leading-loose">
                Ngày công chiếu: {moment(movie?.releaseDate).format("DD/MM/YYYY")}
            </p>
            <p className="leading-loose">
                Quốc gia: {movie?.nationality}
            </p>
            <p className="leading-loose">
                Diễn viên: {movie?.actors}
            </p>
            <p className="leading-loose">
                Nhà sản xuất: {movie?.producer}
            </p>
            <p className="leading-loose">
                Đạo diễn loại: {movie?.directors}
            </p>
            <p className="leading-loose">
                Thể loại: {movie?.categories}
            </p>
        </Grid.Column>
    </Grid>

    return (
        <>
            <Container>
                <Grid>
                    <Grid.Column computer={10} mobile={16}>
                        {Movie}
                        {movie && <Screening id={movie!.id}></Screening>}
                    </Grid.Column>

                    <Grid.Column computer={6} mobile={16}>
                        <TicketPurchaseForm></TicketPurchaseForm>
                        <MovieSlideBar></MovieSlideBar>
                    </Grid.Column>
                </Grid>

            </Container>
        </>
    )
}

export default MovieDetail;