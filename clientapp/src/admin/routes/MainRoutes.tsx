import { lazy } from 'react';

// project imports
import MainLayout from '../layout/MainLayout';
import Loadable from '../ui-component/Loadable';
import { ProtectedRoute } from './ProtectedRoute';

// dashboard routing
const DashboardDefault = Loadable(lazy(async () =>({ default: (await import('../views/dashboard/Default')).default})));

// utilities routing
const UtilsTypography = Loadable(lazy(async () =>({ default: (await import('../views/utilities/Typography')).default})));
const UtilsColor = Loadable(lazy(async () =>({ default: (await import('../views/utilities/Color')).default})));
const UtilsShadow = Loadable(lazy(async () =>({ default: (await import('../views/utilities/Shadow')).default})));
const UtilsMaterialIcons = Loadable(lazy(async () =>({ default: (await import('../views/utilities/MaterialIcons')).default})));
const UtilsTablerIcons = Loadable(lazy(async () =>({ default: (await import('../views/utilities/TablerIcons')).default})));

// sample page routing
const SamplePage = Loadable(lazy(async () =>({ default: (await import('../views/sample-page')).default})));

// ==============================|| MAIN ROUTING ||============================== //

const MainRoutes = {
    path: '/',
    element: <MainLayout />,
    children: [
        {
            path: '/',
            element: <DashboardDefault />
        },
        {
            path: 'dashboard',
            children: [
                {
                    path: 'default',
                    element: <DashboardDefault />
                }
            ]
        },
        {
            path: 'utils',
            children: [
                {
                    path: 'util-typography',
                    element: <UtilsTypography />
                }
            ]
        },
        {
            path: 'utils',
            children: [
                {
                    path: 'util-color',
                    element: <UtilsColor />
                }
            ]
        },
        {
            path: 'utils',
            children: [
                {
                    path: 'util-shadow',
                    element: <UtilsShadow />
                }
            ]
        },
        {
            path: 'icons',
            children: [
                {
                    path: 'tabler-icons',
                    element: <UtilsTablerIcons />
                }
            ]
        },
        {
            path: 'icons',
            children: [
                {
                    path: 'material-icons',
                    element: <UtilsMaterialIcons />
                }
            ]
        },
        {
            path: 'sample-page',
            element: <SamplePage />
        }
    ]
};

export default MainRoutes;
