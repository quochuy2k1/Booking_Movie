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
import { Link } from 'react-router-dom';
import { TicketComboQuantityChartReport } from '../../../../services/movie.service';
import { TicketComboQuantityAreaOption } from './chart-data/ticket-combo-quantity-area-chart';

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

const TicketComBoQuantityAreaChart: React.FC<{ isLoading: boolean, totalQuantityTicketCombo?: (totalQuantityTicket: number, totalComboTicket: number) => void }> = (props) => {
    const token = localStorage.getItem("token");

    const [value, setValue] = useState<string>("1");
    const [seriesBar, setSeriesBar] = React.useState<any[]>([])
    const [labels, setLabels] = React.useState<string[]>([])
    const [ChartOption, setChartOption] = React.useState<ApexOptions>(TicketComboQuantityAreaOption)
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
        (async () => {
            if (value) {
                const response = await TicketComboQuantityChartReport({ conditional: Number.parseInt(value), token: token! })

                const tempTotalTicketQuantityData: number[] = [];
                const tempTotalComboQuantityData: number[] = [];
                const tempLabels: string[] = [];

                const data = response.data;
                var tempTotalComboQuantity = 0;
                var tempTotalTicketQuantity = 0;
                data.forEach(tc => {
                    tempTotalTicketQuantityData.push(parseFloat(tc.totalQuantityTicket.toFixed(2)));
                    tempTotalComboQuantityData.push(parseFloat(tc.totalQuantityCombo.toFixed(2)));

                    tempLabels.push(`${value === "1" ? "Tháng " : "Năm "}${tc.month}`);
                    // 
                    tempTotalComboQuantity += tc.totalQuantityCombo;
                    tempTotalTicketQuantity += tc.totalQuantityTicket;
                })

                props.totalQuantityTicketCombo && props.totalQuantityTicketCombo(tempTotalTicketQuantity, tempTotalComboQuantity);


                setSeriesBar([
                    {
                        name: "Tổng số lượng vé",
                        data: [...tempTotalTicketQuantityData]
                    },
                    {
                        name: "Tổng số lượng combo",
                        data: [...tempTotalComboQuantityData]
                    },
                ]);

                setLabels(tempLabels);
                const tempOption = {
                    ...TicketComboQuantityAreaOption,
                    xaxis: {
                        ...TicketComboQuantityAreaOption.xaxis,
                        categories: tempLabels,
                    },
                };
                setChartOption(tempOption);




            }
        })()

    }, [value])

    // useEffect(() => {
    //     if (labels.length > 0 && seriesBar.length > 0) {

    //         // TicketComboQuantityAreaOption.xaxis!.categories = labels;
    //         // const newChartData: ApexOptions = {
    //         //     ...ChartOption,
    //         //     series: seriesBar,
    //         //     // labels: labels,
    //         //     // colors: [primary200, primaryDark, secondaryMain, secondaryLight],
    //         //     xaxis: {
    //         //         labels: {
    //         //             // style: {
    //         //             //     colors: [primary, primary, primary, primary, primary, primary, primary, primary, primary, primary, primary, primary]
    //         //             // }
    //         //         },
    //         //         categories: labels
    //         //     },
    //         //     // yaxis: {
    //         //     //     labels: {
    //         //     //         style: {
    //         //     //             colors: [primary]
    //         //     //         },
    //         //     //         formatter: function (value: number) {
    //         //     //             return value.toLocaleString('it-IT', {style : 'currency', currency : 'vnd'});
    //         //     //         }
    //         //     //     }
    //         //     // },
    //         //     // grid: {
    //         //     //     borderColor: grey200
    //         //     // },
    //         //     // tooltip: {
    //         //     //     theme: 'light'
    //         //     // },
    //         //     // legend: {
    //         //     //     labels: {
    //         //     //         colors: grey500
    //         //     //     }
    //         //     // }
    //         // };
    //         console.log(props.isLoading, "...chartOptions")

    //         // do not load chart when loading
    //         if (!props.isLoading) {
    //             // ApexCharts.exec(`area-chart`, 'updateOptions', newChartData);
    //         }
    //     }


    // }, [props.isLoading, seriesBar, labels]);

    const handleChangeConditional = (event: React.ChangeEvent<HTMLTextAreaElement | HTMLInputElement>) => {
        setValue(event.target.value)

        // TicketComboQuantityChartReport({ conditional: Number.parseInt(value), token: token! })
        //         .then(response => {
        //             const tempTotalTicketQuantityData: number[] = [];
        //             const tempTotalComboQuantityData: number[] = [];
        //             const tempLabels: string[] = [];

        //             const data = response.data;
        //             data.forEach(tc => {
        //                 tempTotalTicketQuantityData.push(parseFloat(tc.totalQuantityTicket.toFixed(2)));
        //                 tempTotalComboQuantityData.push(parseFloat(tc.totalQuantityCombo.toFixed(2)));

        //                 tempLabels.push(`${value === "1" ? "Tháng " : "Năm "}${tc.month}`);
        //             })


        //             setSeriesBar([
        //                 {
        //                 name: "Tổng số lượng vé",
        //                 data: tempTotalTicketQuantityData
        //             },
        //                 {
        //                 name: "Tổng số lượng combo",
        //                 data: tempTotalComboQuantityData
        //             },
        //         ]);

        //             setLabels(tempLabels);
        //         });

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
                                        {/* <Grid item>
                                            <Typography variant="subtitle2">Báo cáo tỷ lệ quét (quét mã QR)</Typography>
                                        </Grid> */}
                                        <Grid item>
                                            <Typography component={Link} to={"/pages/report/ticket-combo"} sx={{ color: "#333 !important" }} variant="h3">Báo cáo số lượng vé và combo</Typography>
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
                            <Chart type='area' height={280} options={ChartOption} series={seriesBar} />
                        </Grid>
                    </Grid>
                </MainCard>
            )}
        </>
    );
};


export default TicketComBoQuantityAreaChart;
