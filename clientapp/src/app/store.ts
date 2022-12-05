import { configureStore, ThunkAction, Action } from '@reduxjs/toolkit';
import counterReducer from '../client/features/counter/counterSlice';
import userReducer from '../slices/user/userSlice';
import actorReducer from '../slices/actor/actorSlice';
import movieReducer from '../slices/movie/movieSlice';
import ticketReducer from '../slices/tickets/ticketSlice';
import comboReducer from '../slices/combos/comboSlice';
import auditoriumReducer from '../slices/auditoriums/AuditoriumSlice';
import screeningReducer from '../slices/screenings/ScreeningSlice';
import bookingReducer from '../slices/bookings/BookingSlice';
import paymentReducer from '../slices/payments/PaymentSlice';
import customizationReducer from '../slices/customizations/customizationsSlice';

export const store = configureStore({
  reducer: {
    counter: counterReducer,
    user: userReducer,
    actor: actorReducer,
    movie: movieReducer,
    ticket: ticketReducer,
    combo: comboReducer,
    auditorium: auditoriumReducer,
    screening: screeningReducer,
    booking: bookingReducer,
    payment: paymentReducer,
    customization: customizationReducer
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

