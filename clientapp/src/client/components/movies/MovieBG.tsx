import classNames from "classnames";
import React, { useEffect, useState } from "react"
import ReactPlayer from "react-player"
import { Link } from "react-router-dom";
import { Grid, Button, Icon, Header, Image } from "semantic-ui-react";
import { MovieModel } from "../../../slices/movie/movieSlice"

const MovieBG: React.FC<{ movies: MovieModel[] }> = ({ movies }) => {
    const [muted, setMuted] = useState(true);
    const [movieBG, setMovieBG] = useState({} as MovieModel);
    const [isPlaying, setIsPlaying] = useState(false);
    useEffect(() => {
        setMovieBG(movies[Math.floor(Math.random() * movies.length)])
        console.log(movieBG, "movieRand")
    }, [movies])
    return (
        <>
            <div className="absolute flex w-full top-0 left-0" style={{ "zIndex": "-1" }}>
                {isPlaying && <Image className='w-full' src={movieBG && movieBG.imageBackground}></Image>}
                <ReactPlayer
                    width={"100%"}
                    // height={"40%"}
                    url={movieBG && movieBG.videoTrailer}
                    playing={true}
                    muted={muted}
                    onReady={(player) => {setIsPlaying(true)}}
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
                    <Header as={"h1"} className={classNames("transition-all ease-in-out delay-1000 duration-4000 text-white  pt-5 text-left leading-tight", {"text-7xl":!isPlaying, }, {"text-4xl pt-1/5":isPlaying, })}>{movieBG && movieBG.name}</Header>

                    <p className="text-white text-xl ">Nhà du hành và thám hiểm thế giới Gulliver được mời quay trở lại Lilliput - thị trấn trước đây đã được anh cứu khỏi hạm đội kẻ thù. Khi đến nơi, anh chỉ nhận thấy sự phẫn nộ và thất vọng của đám đông vì huyền thoại Gulliver khổng lồ giờ đây chỉ là một người bình thường. Cùng lúc đó, kẻ thù lại đe dọa xứ xở này thêm một lần nữa.</p>
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