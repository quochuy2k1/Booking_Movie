import { ApexOptions } from "apexcharts";
import numeral from "numeral";


export const TicketComboRevenueAreaOption: ApexOptions = {
    chart: {
        // id: 'area-chart',
        type: "area",
        animations: {
            enabled: true,
            easing: "linear",
            dynamicAnimation: {
              speed: 500
            }
          }
    },
    xaxis: {
        type: "category",
        categories: []
    },
    yaxis: {
        labels: {
            formatter(val, opts) {
                return  numeral(val).format("0,0");
            },
        }
        
    },
    dataLabels: {
        enabled: false
    },
    stroke: {
        curve: 'straight',
        width: 1
    },
    fill: {
        type: "gradient"
    },
    tooltip: {
        fixed: {
            enabled: false
        },
        x: {
            show: true
        },
        y: {
            title: 'Số lượng'
            
        } as ApexTooltipY,
        marker: {
            show: false
        }
    },
    grid: {
        show: true,
        yaxis:{
            lines: {
                show: true
            }
        },
        xaxis:{
            lines: {
                show: false
            }
        }
    }
   
}