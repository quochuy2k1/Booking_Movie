import { createRoot } from 'react-dom/client';
import { Provider } from 'react-redux';
import { store } from '../app/store';
import App from './App';
import 'semantic-ui-css/semantic.min.css'
import '../index.css';
import 'react-perfect-scrollbar/dist/css/styles.css';
import 'devextreme/dist/css/dx.common.css';
import 'devextreme/dist/css/dx.light.css';
const container = document.getElementById('root')!;
const root = createRoot(container);

root.render(
    <Provider store={store}>
      <App />
    </Provider>
);