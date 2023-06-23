import { ApexOptions } from "apexcharts";
import numeral from "numeral";

export  const revenueMovieChartOption : ApexOptions = {
    chart: {
        id: 'horizontal-bar-chart',
        type: "bar",
        animations: {
            enabled: true
        },
        stacked: true,
        toolbar: {
            show: true
        },
        zoom: {
            enabled: true
        }
    },
    colors: ['#38bdf8'],
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
            horizontal: true,
            columnWidth: '100%',
            borderRadius: 4,
            dataLabels: {
                position: 'top',
              },
        },
        
    },
    
    xaxis: {
        type: 'category',
        labels: {
            formatter(value, timestamp, opts) {
                
                    return  numeral(value).format("0,0");
                
            },
        },
        categories: [],
    },
    yaxis: {

        labels: {
            // formatter: function (value: number) {
            //     return  numeral(value).format("0,0 VND");
            // }
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
    series: [],
    fill: {
        type: 'solid'
    },
    tooltip: {
        y: {
            formatter(value, opts) {
                return  numeral(value).format("0,0");
            
        },
        }
    },
    dataLabels: {
        enabled: true,
        formatter(value, opts) {
                return  numeral(value).format("0,0");
            
        },
        offsetX: -6,
        style: {
          fontSize: '12px',
          colors: ['#fff']
        }},
        
    grid: {
        show: true,
        yaxis: {
            lines: {
                show: false
            }
        },
        xaxis: {
            lines: {
                show: true
            }
        },
    },

};