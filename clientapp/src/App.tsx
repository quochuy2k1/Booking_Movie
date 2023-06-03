import './App.css';
import ClientLayout from './client/components/layouts/Layout';
import { BrowserRouter } from 'react-router-dom';
import { StyledEngineProvider } from '@mui/material/styles';
import { ThemeProvider, createTheme } from '@mui/material/styles';
import CssBaseline from '@mui/material/CssBaseline';
import { Provider, useSelector } from 'react-redux';
import { RootState, store } from './admin/store';
import themes from './admin/themes';
import NavigationScroll from './admin/layout/NavigationScroll';
import Routes from './admin/routes';
import config from './admin/config';
import { useAppSelector } from './app/hooks';

// const darkTheme = createTheme({
// 	palette: {
// 		mode: 'dark',
// 	},
// });

function App(): JSX.Element {
	const customization = useAppSelector((state) => state.customization);

	return (
		<BrowserRouter>
			<ThemeProvider theme={themes(customization)}>
				<CssBaseline />
				<ClientLayout></ClientLayout>
			</ThemeProvider>

		</BrowserRouter>
	);
}

// function App(): JSX.Element {
// 	const customization = useAppSelector((state) => state.customization);
// 	return (
		
// 			<BrowserRouter basename={config.basename}>
// 				<StyledEngineProvider injectFirst>
// 					<ThemeProvider theme={themes(customization)}>
// 						<CssBaseline />
// 						<NavigationScroll>
// 							<Routes />
// 						</NavigationScroll>
// 					</ThemeProvider>
// 				</StyledEngineProvider>
// 			</BrowserRouter>
		
// 	);
// }

export default App;
