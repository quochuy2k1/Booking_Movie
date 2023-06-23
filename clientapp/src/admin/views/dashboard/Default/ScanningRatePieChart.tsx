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
import React from 'react';
import { ScanningRateChartReport } from '../../../../services/booking.service';
import { scanningRateChartOption } from './chart-data/scanning-rate-pie-chart';
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

export interface ISeriesBar {
    name: string,
    data: number[]
}

// ==============================|| DASHBOARD DEFAULT - TOTAL GROWTH BAR CHART ||============================== //

const ScanningPieChart: React.FC<{ isLoading: boolean }> = ({ isLoading }) => {
    const token = localStorage.getItem("token");

    const [value, setValue] = useState<string>("1");
    const [seriesBar, setSeriesBar] = React.useState<number[]>([])
    const [labels, setLabels] = React.useState<string[]>([])
    const [ChartOption, setChartOption] = React.useState<ApexOptions>(scanningRateChartOption)
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
        if (value) {
            ScanningRateChartReport({ conditional: Number.parseInt(value), token: token! })
                .then(response => {
                    const tempData: number[] = [];
                    const tempLabels: string[] = [];

                    const data = response.data;
                    tempData.push(parseFloat(data.notScanningRate.toFixed(2)), parseFloat(data.scannedRate.toFixed(2)));
                    tempLabels.push(data.notScanningLabel, data.scannedLabel);


                    setSeriesBar(tempData);

                    setLabels(tempLabels);
                    const tempOption = Object.assign({}, scanningRateChartOption, { labels: [...tempLabels] } as ApexOptions);
                    setChartOption(tempOption);
                });
        }


    }, [value])

    useEffect(() => {
        // if (labels.length > 0 && seriesBar.length > 0) {
            
        //     // scanningRateChartOption.xaxis!.categories = labels;
        //     const newChartData: ApexOptions = {
        //         ...ChartOption,
        //         series: seriesBar,
        //         labels: labels,
        //         // colors: [primary200, primaryDark, secondaryMain, secondaryLight],
        //         // xaxis: {
        //         //     labels: {
        //         //         style: {
        //         //             colors: [primary, primary, primary, primary, primary, primary, primary, primary, primary, primary, primary, primary]
        //         //         }
        //         //     }
        //         // },
        //         // yaxis: {
        //         //     labels: {
        //         //         style: {
        //         //             colors: [primary]
        //         //         },
        //         //         formatter: function (value: number) {
        //         //             return value.toLocaleString('it-IT', {style : 'currency', currency : 'vnd'});
        //         //         }
        //         //     }
        //         // },
        //         // grid: {
        //         //     borderColor: grey200
        //         // },
        //         // tooltip: {
        //         //     theme: 'light'
        //         // },
        //         // legend: {
        //         //     labels: {
        //         //         colors: grey500
        //         //     }
        //         // }
        //     };
        //     console.log(isLoading, "...chartOptions")

        //     // do not load chart when loading
        //     if (!isLoading) {
        //         ApexCharts.exec(`donut-chart`, 'updateOptions', newChartData);
        //     }
        // }


    }, [isLoading, seriesBar, labels]);

    const handleChangeConditional = (event: React.ChangeEvent<HTMLTextAreaElement | HTMLInputElement>) => {
        setValue(event.target.value)

        // ScanningRateChartReport({ conditional: Number.parseInt(event.target.value), token: token! })
        //     .then(response => {
        //         const tempData: number[] = [];
        //         const tempLabels: string[] = [];

        //         const data = response.data;
        //         tempData.push(data.notScanningRate, data.scannedRate);
        //         tempLabels.push(data.notScanningLabel, data.scannedLabel);


        //         setSeriesBar(tempData);

        //         setLabels(tempLabels);
        //     });
    }

    return (
        <>
            {isLoading ? (
                <SkeletonTotalGrowthBarChart />
            ) : (
                <MainCard>
                    <Grid container spacing={gridSpacing}>
                        <Grid item xs={12}>
                            <Grid container alignItems="center" justifyContent="space-between">
                                <Grid item>
                                    <Grid container direction="column" spacing={1}>
                                        {/* <Grid item>
                                            <Typography variant="subtitle2">Báo cáo tỷ lệ quét (quét mã QR)</Typography>
                                        </Grid> */}
                                        <Grid item>
                                            <Typography component={Link} to={"/pages/management/booking"} sx={{color: "#333 !important"}} variant="h3">Báo cáo tỷ lệ quét (quét mã QR)</Typography>
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
                            <Chart type='radialBar' height={330} options={ChartOption} series={seriesBar} />
                        </Grid>
                    </Grid>
                </MainCard>
            )}
        </>
    );
};


export default ScanningPieChart;
