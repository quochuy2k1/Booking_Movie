import { createStore } from 'redux';
import reducer from './reducer';

// ==============================|| REDUX - MAIN STORE ||============================== //

const store = createStore(reducer);
const persister = 'Free';
export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
export { store, persister };
