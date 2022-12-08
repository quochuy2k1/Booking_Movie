// ===========================|| DASHBOARD - BAJAJ AREA CHART ||=========================== //
import { ApexOptions } from "apexcharts";


export const AreaOption: ApexOptions = {
    chart: {
        id: 'support-chart',
        sparkline: {
            enabled: true
        }
    },
    dataLabels: {
        enabled: false
    },
    stroke: {
        curve: 'smooth',
        width: 1
    },
    tooltip: {
        fixed: {
            enabled: false
        },
        x: {
            show: false
        },
        y: {
            title: 'Ticket '
        } as ApexTooltipY,
        marker: {
            show: false
        }
    },
   
}


export const  areaSeries = [
    {
        data: [0, 15, 10, 50, 30, 40, 25]
    }
]






