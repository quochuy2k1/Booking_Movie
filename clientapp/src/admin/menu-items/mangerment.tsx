// assets
import { IconKey } from '@tabler/icons';
import { IconSubtask } from '@tabler/icons';
import { IconReportAnalytics } from '@tabler/icons';

// constant
const icons = {
    IconKey,
    IconSubtask,
    IconReportAnalytics
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
                    id: 'ticket-management',
                    title: 'Quản lý vé xem phim',
                    type: 'item',
                    url: '/pages/management/ticket',
                    target: false
                },
                {
                    id: 'combo-management',
                    title: 'Quản lý combo',
                    type: 'item',
                    url: '/pages/management/combo',
                    target: false
                },
                {
                    id: 'auditorium-management',
                    title: 'Quản lý ghế trong phòng xem phim',
                    type: 'item',
                    url: '/pages/management/auditorium',
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
        {
            id: 'report',
            title: 'Báo cáo',
            type: 'collapse',
            icon: icons.IconReportAnalytics,

            children: [
                {
                    id: 'movie-report',
                    title: 'Báo cáo doanh thu phim',
                    type: 'item',
                    url: '/pages/report/movie',
                    target: false
                },
                {
                    id: 'ticket-report',
                    title: 'Báo cáo vé xem phim đã bán',
                    type: 'item',
                    url: '/pages/report/ticket',
                    target: false
                },
                {
                    id: 'combo-report',
                    title: 'Báo cáo combo đã bán',
                    type: 'item',
                    url: '/pages/report/combo',
                    target: false
                },
                {
                    id: 'ticket-combo-report',
                    title: 'Báo cáo vé và combo đã bán',
                    type: 'item',
                    url: '/pages/report/ticket-combo',
                    target: false
                },
            ]
        },
        
    ]
};

export default managements;
