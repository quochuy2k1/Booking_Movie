import { lazy } from 'react';

// project imports
import Loadable from '../ui-component/Loadable';
import MainLayout from '../layout/MainLayout';
import { ProtectedRoute } from './ProtectedRoute';

// login option 3 routing
const MovieReport = Loadable(lazy(async () =>  ({default: (await import('../views/pages/report/movie/MovieReport')).default})));
const TicketReport = Loadable(lazy(async () =>  ({default: (await import('../views/pages/report/movie/TicketReport')).default})));
const ComboReport = Loadable(lazy(async () =>  ({default: (await import('../views/pages/report/movie/ComboReport')).default})));
const TicketComboReport = Loadable(lazy(async () =>  ({default: (await import('../views/pages/report/movie/TicketComboReport')).default})));

// ==============================|| AUTHENTICATION ROUTING ||============================== //

const ReportRoutes = {
    path: '/',
    element: <ProtectedRoute><MainLayout /></ProtectedRoute> ,
    children: [
        {
            path: '/pages/report/movie',
            element: <MovieReport />
        },
        {
            path: '/pages/report/ticket',
            element: <TicketReport />
        },
        {
            path: '/pages/report/combo',
            element: <ComboReport />
        },
        {
            path: '/pages/report/ticket-combo',
            element: <TicketComboReport />
        },
    ]
};

export default ReportRoutes;
