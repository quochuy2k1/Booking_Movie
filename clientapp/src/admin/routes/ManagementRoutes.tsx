import { lazy } from 'react';

// project imports
import Loadable from '../ui-component/Loadable';
import MainLayout from '../layout/MainLayout';

// login option 3 routing
const MovieManagement = Loadable(lazy(async () =>  ({default: (await import('../views/pages/management/movie/index')).default})));
// const AuthRegister3 = Loadable(lazy( async () => ({default: (await import('../views/pages/authentication/authentication3/Register3')).default})));

// ==============================|| AUTHENTICATION ROUTING ||============================== //

const ManagementRoutes = {
    path: '/',
    element: <MainLayout />,
    children: [
        {
            path: '/pages/management/movie',
            element: <MovieManagement />
        },
        // {
        //     path: '/pages/register/register3',
        //     element: <AuthRegister3 />
        // }
    ]
};

export default ManagementRoutes;
