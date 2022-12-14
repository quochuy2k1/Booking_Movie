import { lazy } from 'react';

// project imports
import Loadable from '../ui-component/Loadable';
import MainLayout from '../layout/MainLayout';
import { ProtectedRoute } from './ProtectedRoute';
import ScreeningManagement from '../views/pages/management/screening';
import BookingManagement from '../views/pages/management/booking';
import QRBookingScanner from '../views/pages/management/QRBookingScanner';

// login option 3 routing
const MovieManagement = Loadable(lazy(async () =>  ({default: (await import('../views/pages/management/movie/index')).default})));
const ActorManagement = Loadable(lazy(async () =>  ({default: (await import('../views/pages/management/actor/index')).default})));
// const AuthRegister3 = Loadable(lazy( async () => ({default: (await import('../views/pages/authentication/authentication3/Register3')).default})));

// ==============================|| AUTHENTICATION ROUTING ||============================== //

const ManagementRoutes = {
    path: '/',
    element: <ProtectedRoute><MainLayout /></ProtectedRoute> ,
    children: [
        {
            path: '/pages/management/movie',
            element: <MovieManagement />
        },
        {
            path: '/pages/management/actor',
            element: <ActorManagement />
        },
        {
            path: '/pages/management/screening',
            element: <ScreeningManagement />
        },
        {
            path: '/pages/management/booking',
            element: <BookingManagement />
        },
        {
            path: '/pages/management/qrscanner',
            element: <QRBookingScanner />
        }
    ]
};

export default ManagementRoutes;
