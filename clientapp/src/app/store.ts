import { configureStore, ThunkAction, Action } from '@reduxjs/toolkit';
import counterReducer from '../features/counter/counterSlice';
import userReducer from '../features/user/userSlice';
import actorReducer from '../features/actor/actorSlice';
import movieReducer from '../features/movie/movieSlice';
import ticketReducer from '../features/tickets/ticketSlice';
import comboReducer from '../features/combos/comboSlice';

export const store = configureStore({
  reducer: {
    counter: counterReducer,
    user: userReducer,
    actor: actorReducer,
    movie: movieReducer,
    ticket: ticketReducer,
    combo: comboReducer
  },
  middleware: (getDefaultMiddleware) => {
    return getDefaultMiddleware()
  },
});

export type AppDispatch = typeof store.dispatch; 
export type RootState = ReturnType<typeof store.getState>;
export type AppThunk<ReturnType = void> = ThunkAction<
  ReturnType,
  RootState,
  unknown,
  Action<string>
>;

