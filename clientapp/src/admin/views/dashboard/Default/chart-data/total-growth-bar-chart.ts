// ===========================|| DASHBOARD - TOTAL GROWTH BAR CHART ||=========================== //

import { ApexOptions } from "apexcharts";

const TotalGrowBarOptions: ApexOptions = {
    chart: {
        id: 'bar-chart',
        stacked: true,
        toolbar: {
            show: true
        },
        zoom: {
            enabled: true
        }
    },
    responsive: [
        {
            breakpoint: 480,
            options: {
                legend: {
                    position: 'bottom',
                    offsetX: -10,
                    offsetY: 0
                }
            }
        }
    ],
    plotOptions: {
        bar: {
            horizontal: false,
            columnWidth: '50%'
        }
    },
    xaxis: {
        type: 'category',
        categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
    },
    yaxis: {

        labels: {
            formatter: function (value: number) {
                return value + "$";
            }
        },
    },
    legend: {
        show: true,
        fontSize: '14px',
        fontFamily: `'Roboto', sans-serif`,
        position: 'bottom',
        offsetX: 20,
        labels: {
            useSeriesColors: false,
        },
        markers: {
            width: 16,
            height: 16,
            radius: 5
        },
        itemMargin: {
            horizontal: 15,
            vertical: 8
        }
    },
    fill: {
        type: 'solid'
    },
    dataLabels: {
        enabled: false
    },
    grid: {
        show: true
    },

};

export const seriesBar = [
    {
        name: 'Đồ ăn / thức uống',
        data: [35000000, 12500000, 35000000, 35000000, 35000000, 80000000, 35000000, 20000000, 35000000, 45000000, 15000000, 75000000]
    },
    {
        name: 'Vé bán',
        data: [35000000, 15000000, 15000000, 35000000, 65000000, 40000000, 80000000, 25000000, 15000000, 85000000, 25000000, 75000000]
    },
]
export default TotalGrowBarOptions;
