
import { BrowserRouter } from 'react-router-dom';
import { StyledEngineProvider } from '@mui/material/styles';

import { ThemeProvider } from '@mui/material/styles';
import CssBaseline from '@mui/material/CssBaseline';
import themes from './themes';
import NavigationScroll from './layout/NavigationScroll';
import Routes from './routes';
import config from './config';
import { useAppSelector } from '../app/hooks';


function App(): JSX.Element {
	const customization = useAppSelector((state) => state.customization);
	return (
		
			<BrowserRouter basename={config.basename}>
				<StyledEngineProvider injectFirst>
					<ThemeProvider theme={themes(customization)}>
						<CssBaseline />
						<NavigationScroll>
							<Routes />
						</NavigationScroll>
					</ThemeProvider>
				</StyledEngineProvider>
			</BrowserRouter>
		
	);
}

export default App;
