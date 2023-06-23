import PropTypes from 'prop-types';
import { useState, useEffect } from 'react';
import { useSelector } from 'react-redux';

// material-ui
import { useTheme } from '@mui/material/styles';
import { Grid, MenuItem, TextField, Typography } from '@mui/material';

// third-party
import ApexCharts, { ApexOptions } from 'apexcharts';
import Chart from 'react-apexcharts';

// project imports
import SkeletonTotalGrowthBarChart from '../../../ui-component/cards/Skeleton/TotalGrowthBarChart';
import MainCard from '../../../ui-component/cards/MainCard';
import { gridSpacing } from '../../../store/constant';

// chart data
import { RootState } from '../../../store';
import { revenueMovieChartOption } from './chart-data/movie-revenue-bar-chart';
import React from 'react';
import { MovieRevenueChartReport } from '../../../../services/movie.service';
import numeral from 'numeral';
import { Link } from 'react-router-dom';

const status = [
    {
        value: '0',
        label: 'Hôm nay'
    },
    {
        value: "1",
        label: 'Theo tháng'
    },
    {
        value: "2",
        label: 'Theo năm'
    }
];

export interface ISeriesBar{
    name: string,
    data: number[]
}

// ==============================|| DASHBOARD DEFAULT - TOTAL GROWTH BAR CHART ||============================== //

const MovieRevenueBarChart: React.FC<{isLoading: boolean, movieRevenue?: (revenue: number) => void}> = (props) => {
    const token = localStorage.getItem("token");

    const [value, setValue] = useState<string>('1');
    const [total, setTotal] = useState<number>(0);
    const [seriesBar, setSeriesBar] = React.useState<ISeriesBar[]>([])
    const [categoriesXAxis, setCategoriesXAxis] = React.useState<string[]>([])
    const [ChartOption, setChartOption] = React.useState<ApexOptions>(revenueMovieChartOption)
    const theme = useTheme();
    // const customization = useSelector((state: RootState) => state.customization);

    // const { navType } = customization;
    const { primary } = theme.palette.text;
    const darkLight = theme.palette.dark.light;
    const grey200 = theme.palette.grey[200];
    const grey500 = theme.palette.grey[500];

    const primary200 = theme.palette.primary[200];
    const primaryDark = theme.palette.primary.dark;
    const secondaryMain = theme.palette.secondary.main;
    const secondaryLight = theme.palette.secondary.light;


    useEffect(() => {
        if(value){
            MovieRevenueChartReport({conditional: Number.parseInt(value), token: token!})
            .then(response => {
                const tempData: number[] = [];
                const tempLabels: string[] = [];
                var tempTotal = 0;
                response.data.forEach(data => {
                    tempData.push(data.revenue);
                    tempLabels.push(`${value === "1" ? "Tháng " : "Năm "}${data.month}`)

                    tempTotal += data.revenue;
                });
    
                setTotal(tempTotal);
                props.movieRevenue && props.movieRevenue(tempTotal);
                // 
                setSeriesBar([
                    {
                        name: "Báo cáo doanh thu",
                        data: tempData
                    }
                ]);
    
                setCategoriesXAxis(tempLabels);
                const tempOption = Object.assign({}, revenueMovieChartOption, {xaxis: {...revenueMovieChartOption.xaxis, categories: tempLabels}} as ApexOptions);
                setChartOption(tempOption);
            });
        }
        
        
    }, [value])

    useEffect(() => {
       
        // revenueMovieChartOption.xaxis!.categories = categoriesXAxis;
        // const newChartData = {
        //     ...ChartOption,
        //     series: seriesBar,
        //     colors: [primary200, primaryDark, secondaryMain, secondaryLight],
        //     xaxis: {
        //         labels: {
        //             style: {
        //                 colors: [primary, primary, primary, primary, primary, primary, primary, primary, primary, primary, primary, primary]
        //             }
        //         }
        //     },
        //     yaxis: {
        //         labels: {
        //             style: {
        //                 colors: [primary]
        //             },
        //             formatter: function (value: number) {
        //                 return value.toLocaleString('it-IT', {style : 'currency', currency : 'vnd'});
        //             }
        //         }
        //     },
        //     grid: {
        //         borderColor: grey200
        //     },
        //     tooltip: {
        //         theme: 'light'
        //     },
        //     legend: {
        //         labels: {
        //             colors: grey500
        //         }
        //     }
        // };
        // console.log(props.isLoading, "...chartOptions")

        // // do not load chart when loading
        // if (!props.isLoading) {
        //     ApexCharts.exec(`bar-chart`, 'updateOptions', newChartData);
        // }

        
    }, [props.isLoading, seriesBar, categoriesXAxis]);

    const handleChangeConditional = (event: React.ChangeEvent<HTMLTextAreaElement | HTMLInputElement>) => {
        setValue(event.target.value)

        // MovieRevenueChartReport({conditional: Number.parseInt(event.target.value), token: token!})
        // .then(response => {
        //     const tempData: number[] = [];
        //     const tempLabels: string[] = [];
        //     var tempTotal = 0;
        //     response.data.forEach(data => {
        //         tempData.push(data.revenue);
        //         tempLabels.push(`${value === "1" ? "Tháng " : "Năm "}${data.month}`)
        //         tempTotal += data.revenue;
        //     });

        //     setTotal(tempTotal);
        //     setSeriesBar([
        //         {
        //             name: "Báo cáo doanh thu",
        //             data: tempData
        //         }
        //     ]);

        //     setCategoriesXAxis(tempLabels);
        // });
    }

    return (
        <>
            {props.isLoading ? (
                <SkeletonTotalGrowthBarChart />
            ) : (
                <MainCard>
                    <Grid container spacing={gridSpacing}>
                        <Grid item xs={12}>
                            <Grid container alignItems="center" justifyContent="space-between">
                                <Grid item>
                                    <Grid container direction="column" spacing={1}>
                                        <Grid item>
                                            <Typography component={Link} sx={{color: "#333 !important"}} to={"/pages/report/movie"} variant="h3">Báo cáo doanh thu</Typography>
                                        </Grid>
                                        <Grid item>
                                            <Typography variant="h2" sx={{color: "#38bdf8"}}>{numeral(total).format("0,0")} vnđ</Typography>
                                        </Grid>
                                    </Grid>
                                </Grid>
                                <Grid item>
                                    <TextField
                                        id="standard-select-currency"
                                        select
                                        value={value}
                                        onChange={handleChangeConditional}
                                    >
                                        {status.map((option) => (
                                            <MenuItem key={option.value} value={option.value}>
                                                {option.label}
                                            </MenuItem>
                                        ))}
                                    </TextField>
                                </Grid>
                            </Grid>
                        </Grid>
                        <Grid item xs={12}> 
                            <Chart type='bar' height={420} options={ChartOption} series={seriesBar} />
                        </Grid>
                    </Grid>
                </MainCard>
            )}
        </>
    );
};


export default MovieRevenueBarChart;
