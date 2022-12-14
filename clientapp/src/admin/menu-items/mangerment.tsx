// assets
import { IconKey } from '@tabler/icons';
import { IconSubtask } from '@tabler/icons';

// constant
const icons = {
    IconKey,
    IconSubtask,
};

// ==============================|| EXTRA PAGES MENU ITEMS ||============================== //

const managements = {
    id: 'managements',
    title: 'Trang quản lý',
    caption: 'Trang quản lý',
    type: 'group',
    children: [
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
                {
                    id: 'actor-management',
                    title: 'Quản lý diễn viên',
                    type: 'item',
                    url: '/pages/management/actor',
                    target: false
                },
                {
                    id: 'screening-management',
                    title: 'Quản lý lịch chiếu phim',
                    type: 'item',
                    url: '/pages/management/screening',
                    target: false
                },
                {
                    id: 'booking-management',
                    title: 'Quản lý lịch đơn đặt vé',
                    type: 'item',
                    url: '/pages/management/booking',
                    target: false
                }, 
                {
                    id: 'qr-scanner',
                    title: 'Quét mã QR đơn đặt vé',
                    type: 'item',
                    url: '/pages/management/qrscanner',
                    target: false
                }
            ]
        },
        
    ]
};

export default managements;
