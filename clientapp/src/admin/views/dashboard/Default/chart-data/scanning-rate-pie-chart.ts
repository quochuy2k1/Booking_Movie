import { ApexOptions } from "apexcharts";
import numeral from "numeral";

export  const scanningRateChartOption : ApexOptions = {
    chart: {
        id: 'radialBar-chart',
        type: "radialBar",
        // stacked: true,
        animations: {
            enabled: true,
            easing: "linear",
            dynamicAnimation: {
              speed: 500
            }
          },
        toolbar: {
            show: true
        },
        zoom: {
            enabled: true
        }
    },
    colors: ['#f87171', "#4ade80"],
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
    // plotOptions: {
    //     pie: {
    //         donut: {
    //             size: "100%",

    //         }
    //     },
        
    // },
    
    // xaxis: {
    //     type: 'category',
    //     labels: {
    //         formatter(value, timestamp, opts) {
                
    //                 return  numeral(value).format("0,0");
                
    //         },
    //     },
    //     categories: [],
    // },
    // yaxis: {

    //     labels: {
    //         // formatter: function (value: number) {
    //         //     return  numeral(value).format("0,0 VND");
    //         // }
    //     },
    // },
    plotOptions: {
        pie: {
            expandOnClick: true
          }
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
        formatter: function(seriesName, opts) {
            return seriesName + ":  " + opts.w.globals.series[opts.seriesIndex] + "%"
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
    tooltip: {
        y: {
            formatter(value, opts) {
                return  value + "%";
            
        },
        }
    },
    labels: [],
    dataLabels: {
        enabled: true,
        formatter(value, opts) {
                return  value + "%";
            
        },
        offsetX: -6,
        style: {
          fontSize: '12px',
          colors: ['#fff']
        }},
        
    // grid: {
    //     show: true
    // },

};