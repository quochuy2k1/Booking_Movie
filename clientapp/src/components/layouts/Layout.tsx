import { createMedia } from '@artsy/fresnel';
import * as React from 'react';
import { Route, Switch } from 'react-router-dom';
import ActorDetail from '../../features/actor/actorDetail';
import ActorList from '../../features/actor/actorlist';
import MovieDetail from '../../features/movie/MovieDetail';
import MovieList from '../../features/movie/MovieList';
import Home from '../Home';
import TicketList from '../../features/tickets/TicketList';
import Footer from './Footer';
import NavMenu from './NavMenu';
import ComboList from '../../features/combos/comboList';


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

const SwitchRoute: React.FC<{}> = ({ }) => {
    return (
        <Switch>
            <Route exact path='/' component={Home} />
            <Route exact path='/actor' component={ActorList} />
            <Route exact path='/actor/:id' component={ActorDetail} />
            <Route exact path='/movie' component={MovieList} />
            <Route exact path='/movie/:id' component={MovieDetail} />
            <Route exact path='/book-ticket/:cinemaId' component={TicketList} />
            <Route exact path='/book-combo/:cinemaId' component={ComboList} />
            <Route path='/fetch-data/:startDateIndex?' component={Home} />
        </Switch>
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