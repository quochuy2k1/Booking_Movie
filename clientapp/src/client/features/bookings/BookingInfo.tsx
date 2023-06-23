import moment from "moment";
import React from "react";
import { useParams } from "react-router-dom";
import { Header, Image, Item, Label } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { addMovie, MovieModel } from "../../../slices/movie/movieSlice";
import { ScreeningModel } from "../../../slices/screenings/ScreeningSlice";
import { bookScreening } from "../../../slices/bookings/BookingSlice";
import { bookScreeningId } from "../../../slices/bookings/BookingSliceClient";
// interface BookingPropsParams {
//     movieId: string,
//     cinemaId: string
// }

const BookingInfo: React.FC<{}> = () => {
    const { movieId } = useParams<string>();

    const dispatch = useAppDispatch();
    const { screening } = useAppSelector(state => state.bookingClient.booking);
    const { seatNo } = useAppSelector(state => state.seatReserved);
    const { combos } = useAppSelector(state => state.combo);
    // const contextRef = useRef<HTMLElement>(null);
    const movie: MovieModel | undefined = useAppSelector(state => state.movie.movies.find(m => m.id === Number.parseInt(movieId!)));



    React.useEffect(() => {
        console.log(sessionStorage.getItem("book-movie"), "session store book-movie)")
        const screening = JSON.parse(sessionStorage.getItem("book-cinema")!);
		const showDate = JSON.parse(sessionStorage.getItem("showDate")!);

		dispatch(bookScreeningId({screening, showDate}));
        // get movie from session store
        const movie_session: string | null = sessionStorage.getItem("book-movie");
        const screening_session: string | null = sessionStorage.getItem("book-cinema");

        // lưu movie vào session store và lấy, lưu vào redux state khi refresh trang
        if (movie || (movie_session === null || movie_session === 'undefined')) {
            sessionStorage.setItem("book-movie", JSON.stringify(movie))
        }
        else {
            const movie_session: MovieModel = JSON.parse(sessionStorage.getItem("book-movie")!)

            // nếu tồn tại movie session store
            movie_session && dispatch(addMovie(movie_session))
            // sessionStorage.removeItem("book-movie")

        }
        // lưu movie vào session store và lấy, lưu vào redux state khi refresh trang
        if (screening || (screening_session === null || screening_session === 'undefined')) {
            sessionStorage.setItem("book-cinema", JSON.stringify(screening))
        }
        else {
            const screening_session: ScreeningModel = JSON.parse(sessionStorage.getItem("book-cinema")!)
            console.log(screening_session);
            // nếu tồn tại cinema session store
            screening_session && dispatch(bookScreening(screening_session))
            // sessionStorage.removeItem("book-cinema")

        }

    }, [dispatch, movie]);
    return (
        <>


            <div className="sticky top-0 bg-gray-700 p-5 ">
                <Image src={movie?.imageBackground}></Image>
                <Header as="h3" className="text-orange-600">{movie?.name}</Header>
                <Item.Group divided>
                    <Item className="py-2">
                        <Item.Content verticalAlign='middle' className="text-white">
                            Rạp: {screening?.cinemaName} | {screening?.auditoriumName}
                        </Item.Content>
                    </Item>

                    <Item className="py-2">
                        <Item.Content verticalAlign='middle' className="text-white">
                            Suất chiếu: {moment.utc(screening?.movieSchedule![0].showTime).local().format("HH:mm")} | {screening?.auditoriumName}
                        </Item.Content>
                    </Item>

                    <Item className="py-2">
                        <Item.Content verticalAlign='middle' className="text-white">
                            Combo: {combos.map(combo => combo.quantity! > 0 && ( <Label key={combo.id} className="my-1" color='teal'  horizontal>
                                {`${combo.name} (${combo.quantity})`}
                            </Label>))}
                        </Item.Content>
                    </Item>
                    <Item className="py-2">
                        <Item.Content verticalAlign='middle' className="text-white">
                            Ghế: {seatNo.map(seatNo => seatNo.seatId && seatNo.seatId).join(", ")}
                        </Item.Content>
                    </Item>
                </Item.Group>
            </div>


        </>
    )
}

export default BookingInfo;