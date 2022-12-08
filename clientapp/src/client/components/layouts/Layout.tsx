import { createMedia } from '@artsy/fresnel';
import * as React from 'react';
import { Route, Routes } from 'react-router-dom';
import ActorDetail from '../../features/actor/actorDetail';
import ActorList from '../../features/actor/actorlist';
import MovieDetail from '../../features/movie/MovieDetail';
import MovieList from '../../features/movie/MovieList';
import Home from '../Home';
import Footer from './Footer';
import NavMenu from './NavMenu';
import Booking from '../../features/bookings/Booking';


const AppMedia = createMedia({
    breakpoints: {
        mobile: 320,
        tablet: 768,
        computer: 992,
        largeScreen: 1200,
        widescreen: 1920
    }
});

const mediaStyles = AppMedia.createMediaStyle();
const { Media, MediaContextProvider } = AppMedia;

const SwitchRoute: React.FC<{}> = () => {
    const sessionId: string | null = localStorage.getItem("sessionId");
    console.log(sessionId !== null ? sessionId : "", "sessionId layout")
    return (
        <Routes>
            <Route  path='/' element={<Home/>} />
            <Route  path='/actor' element={<ActorList/>} />
            <Route  path='/actor/:id' element={<ActorDetail/>} />
            <Route  path='/movie' element={<MovieList/>} />
            <Route  path='/movie/:movieId' element={<MovieDetail/>} />
            <Route  path={`/booking/:cinemaId/movie/:movieId/sessionId/${sessionId}`} element={<Booking/>} />
            {/* <Route path='/fetch-data/:startDateIndex?' element={<Home/>} /> */}
            {/* <Route path='*'>
                <div>Không phù hợp</div>
            </Route> */}
        </Routes>
    )
}


export default class Layout extends React.PureComponent<{ children?: React.ReactNode }, {}> {
    public render() {
        return (
            <>
                <style>{mediaStyles}</style>
                <MediaContextProvider>
                    <React.Fragment>
                        <NavMenu Media={Media} children={<SwitchRoute/>} />

                        <Footer></Footer>
                    </React.Fragment>
                </MediaContextProvider>

            </>
        );
    }
}