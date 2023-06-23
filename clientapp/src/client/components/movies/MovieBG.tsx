import classNames from "classnames";
import React, { useEffect, useMemo, useState } from "react"
import ReactPlayer from "react-player"
import { Link } from "react-router-dom";
import { Grid, Button, Icon, Header, Image } from "semantic-ui-react";
import { MovieModel } from "../../../slices/movie/movieSlice"
import styled from "@emotion/styled";
import DOMPurify from 'dompurify';

const MovieBG: React.FC<{ movies: MovieModel[] }> = ({ movies }) => {
    const [muted, setMuted] = useState(true);
    const [movieBG, setMovieBG] = useState<MovieModel | null>(null);
    const [isPlaying, setIsPlaying] = useState(false);
    useEffect(() => {
        setMovieBG(movies[Math.floor(Math.random() * movies.length)])
        // console.log(movieBG, movies[Math.floor(Math.random() * movies.length)], "movieRand")

    }, [movies, setMovieBG])

    const PlayerHandle = useMemo(() => () => {
     
      
        setIsPlaying(true);
    }, []);

    // const MovieImageBackground = styled.div<{url: string | undefined}>`
    //     position: absolute;
    //     background-image: url(${props => props.url ? props.url : ""});
    //     height: 100%;

    //     /* Center and scale the image nicely */
    //     background-position: center;
    //     background-repeat: no-repeat;
    //     background-size: cover;
    // `
    return (
        <>
            <div className="absolute flex w-full top-0 left-0" style={{ "zIndex": "-1" }}>
                {/* <MovieImageBackground  url={movieBG?.imageBackground}></MovieImageBackground> */}
               {!isPlaying &&  <Image className="w-full object-cover" src={"https://img.freepik.com/vecteurs-libre/fond-sombre-basse-poly_1048-7971.jpg?w=996&t=st=1671723569~exp=1671724169~hmac=01e1f1b9f88f36e6ff4bb191d85e49dc82bc4cf8884d61dbde6f4d907c47d5f5"}></Image>}
                <ReactPlayer
                    width={"100%"}
                    // height={"40%"}
                    url={movieBG?.videoTrailer}
                    playing={isPlaying}
                    muted={muted}
                    onReady={PlayerHandle}
                    onEnded={() => setIsPlaying(false)}
                />
            </div>

            <Grid className="absolute right-10 top-1/3">
                <Grid.Column width={9}>
                    <Button size="big" inverted icon circular basic onClick={() => setMuted((pre) => !pre)} >
                        <Icon size="large" inverted name={muted ? "volume up" : "volume off"} className="text-white" />
                    </Button>
                </Grid.Column>

            </Grid>

            <Grid className="pt-1/12 pb-5">
                <Grid.Column width={6}>
                    <Header as={"h1"} className={classNames("transition-all ease-in-out delay-1000 duration-4000 text-white  pt-5 text-left leading-tight", { "text-7xl": !isPlaying, }, { "text-4xl pt-1/5": isPlaying, })}>{movieBG && movieBG.name}</Header>

                    <p className="text-white text-xl limit-text-3" dangerouslySetInnerHTML={{ __html: movieBG?.content ? DOMPurify.sanitize(movieBG?.content) : "" }}/>
                    <div className="flex pt-2">
                        <Button size="big" icon labelPosition='left'>
                            <Icon name='ticket' />
                            Đặt vé
                        </Button>
                        <Button as={Link} to={`/movie/${movieBG && movieBG.id}`} size="big" icon labelPosition='left' color="grey">
                            <Icon name='info' />
                            Chi tiết
                        </Button>
                    </div>
                </Grid.Column>
            </Grid>
        </>
    )
}

export default MovieBG;