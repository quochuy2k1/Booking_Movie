import { useEffect, useState } from 'react';

// material-ui
import { Button, Grid } from '@mui/material';

// project imports
import EarningCard from './EarningCard';
import PopularCard from './PopularCard';
import TotalOrderLineChartCard from './TotalOrderLineChartCard';
import TotalIncomeDarkCard from './TotalIncomeDarkCard';
import TotalIncomeLightCard from './TotalIncomeLightCard';
import TotalGrowthBarChart from './TotalGrowthBarChart';
import { gridSpacing } from '../../../store/constant';
import MovieRevenueBarChart from './MovieRevenueBarChart';
import ScanningPieChart from './ScanningRatePieChart';
import TicketComBoQuantityAreaChart from './TicketComboQuantityAreaChart';
import TicketComBoRevenueAreaChart from './TicketComboRevenueAreaChart';

// ==============================|| DEFAULT DASHBOARD ||============================== //

const Dashboard: React.FC = () => {
    const [isLoading, setLoading] = useState<boolean>(true);
    const [movieRevenue, setMovieRevenue] = useState<number>(0);
    const [totalQuantityTicket, setTotalQuantityTicket] = useState<number>(0);
    const [totalQuantityCombo, setTotalQuantityCombo] = useState<number>(0);
    const [revenueCombo, setRevenueCombo] = useState<number>(0);
    const [revenueTicket, setRevenueTicket] = useState<number>(0);
    useEffect(() => {
        setLoading(false);
    }, []);

    return (
        <Grid container spacing={gridSpacing}>
            <Grid item xs={12}>
                <Grid container spacing={gridSpacing}>
                    <Grid item lg={4} md={6} sm={6} xs={12}>

                        <EarningCard movieRevenue={movieRevenue} isLoading={isLoading} />
                    </Grid>
                    <Grid item lg={4} md={6} sm={6} xs={12}>
                        <TotalOrderLineChartCard totalQuantityTicket={totalQuantityTicket} totalQuantityCombo={totalQuantityCombo} isLoading={isLoading} />
                    </Grid>
                    <Grid item lg={4} md={12} sm={12} xs={12}>
                        <Grid container spacing={gridSpacing}>
                            <Grid item sm={6} xs={12} md={6} lg={12}>
                                <TotalIncomeDarkCard revenueTicket={revenueTicket} isLoading={isLoading} />
                            </Grid>
                            <Grid item sm={6} xs={12} md={6} lg={12}>
                                <TotalIncomeLightCard revenueCombo={revenueCombo} isLoading={isLoading} />
                            </Grid>
                        </Grid>
                    </Grid>
                </Grid>
            </Grid>
            <Grid item xs={12}>
                <Grid container spacing={gridSpacing}>
                    <Grid item xs={12} md={6}>
                        <ScanningPieChart isLoading={isLoading} />
                    </Grid>


                </Grid>
            </Grid>
            <Grid item xs={12}>
                <Grid container spacing={gridSpacing}>
                <Grid item xs={12} md={6}>
                        <TicketComBoQuantityAreaChart isLoading={isLoading} totalQuantityTicketCombo={(_totalQuantityTicket, _totalQuantityCombo) => {setTotalQuantityTicket(_totalQuantityTicket); setTotalQuantityCombo(_totalQuantityCombo)}} />
                    </Grid>
                    <Grid item xs={12} md={6}>
                        <TicketComBoRevenueAreaChart isLoading={isLoading} revenueTicketCombo={(_revenueTicket, _revenueCombo) => {setRevenueTicket(_revenueTicket); setRevenueCombo(_revenueCombo)}} />
                    </Grid>
                </Grid>
            </Grid>
            <Grid item xs={12}>
                <Grid container spacing={gridSpacing}>
                    <Grid item xs={12} md={12}>
                        <MovieRevenueBarChart movieRevenue={(revenue) => setMovieRevenue(revenue)} isLoading={isLoading} />
                    </Grid>

                    {/* <Grid item xs={12} md={4}>
                        <PopularCard isLoading={isLoading} />
                    </Grid> */}
                </Grid>
            </Grid>
        </Grid>
    );
};

export default Dashboard;
