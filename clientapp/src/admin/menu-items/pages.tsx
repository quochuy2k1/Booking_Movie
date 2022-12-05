// assets
import { IconKey } from '@tabler/icons';
import { IconSubtask } from '@tabler/icons';

// constant
const icons = {
    IconKey,
    IconSubtask,
};

// ==============================|| EXTRA PAGES MENU ITEMS ||============================== //

const pages = {
    id: 'pages',
    title: 'Trang chứng thực',
    caption: 'Trang chứng thực',
    type: 'group',
    children: [
        {
            id: 'authentication',
            title: 'Chứng thực',
            type: 'collapse',
            icon: icons.IconKey,

            children: [
                {
                    id: 'login3',
                    title: 'Đăng nhập',
                    type: 'item',
                    url: '/pages/login/login3',
                    target: true
                },
                {
                    id: 'register3',
                    title: 'Đăng ký',
                    type: 'item',
                    url: '/pages/register/register3',
                    target: true
                }
            ]
        },
        {
            id: 'management',
            title: 'Quản lý',
            type: 'collapse',
            icon: icons.IconSubtask,

            children: [
                {
                    id: 'movie-management',
                    title: 'Quản lý Phim',
                    type: 'item',
                    url: '/pages/management/movie',
                    target: false
                },
                // {
                //     id: 'register3',
                //     title: 'Đăng ký',
                //     type: 'item',
                //     url: '/pages/register/register3',
                //     target: true
                // }
            ]
        }
    ]
};

export default pages;
