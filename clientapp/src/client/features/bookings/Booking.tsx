import * as React from 'react';
import { Box, Button, Step, Stepper, Typography, Container, Grid, StepLabel, styled, StepIconProps } from '@mui/material';
import { ArrowBack, ArrowForward, ConfirmationNumberRounded, EventSeatRounded, PaymentRounded } from "@mui/icons-material"
import BookingTicket from './BookingTicket';
import Auditorium from '../auditoriums/Auditorium';
import Payment from '../payments/Payment';
import BookingInfo from './BookingInfo';
import { useAppDispatch, useAppSelector } from '../../../app/hooks';
import { resetQuantityBookTicket } from '../../../slices/tickets/ticketSlice';
import { Confirm } from 'semantic-ui-react';
import { SeatState } from '../../../slices/seats/SeatSlice';

const show_error: string[] = [
	"Việc chọn vị trí ghế của bạn không được để trống 1 ghế ở bên trái, giữa hoặc bên phải trên cùng hàng ghế mà bạn vừa chọn.",
	"Số lượng ghế chọn ít hơn số lượng vé đặt"
]

const ColorlibStepIconRoot = styled('div')<{
	ownerState: { completed?: boolean; active?: boolean };
}>(({ theme, ownerState }) => ({
	backgroundColor: theme.palette.mode === 'dark' ? theme.palette.grey[700] : '#ccc',
	zIndex: 1,
	color: '#fff',
	width: 50,
	height: 50,
	display: 'flex',
	borderRadius: '50%',
	justifyContent: 'center',
	alignItems: 'center',
	...(ownerState.active && {
		backgroundImage:
			'linear-gradient( 136deg, rgb(242,113,33) 0%, rgb(233,64,87) 50%, rgb(138,35,135) 100%)',
		boxShadow: '0 4px 10px 0 rgba(0,0,0,.25)',
	}),
	...(ownerState.completed && {
		backgroundImage:
			'linear-gradient( 136deg, rgb(242,113,33) 0%, rgb(233,64,87) 50%, rgb(138,35,135) 100%)',
	}),
}));

function ColorlibStepIcon(props: StepIconProps) {
	const { active, completed, className } = props;

	const icons: { [index: string]: React.ReactElement } = {
		1: <ConfirmationNumberRounded />,
		2: <EventSeatRounded />,
		3: <PaymentRounded />,
	};

	return (
		<ColorlibStepIconRoot ownerState={{ completed, active }} className={className}>
			{icons[String(props.icon)]}
		</ColorlibStepIconRoot>
	);
}


const Booking: React.FC<{}> = () => {

	const dispatch = useAppDispatch();
	const { classSelect } = useAppSelector(state => state.auditorium)
	const { chooseTotal } = useAppSelector(state => state.ticket)
	const [preventNext, setPreventNext] = React.useState(false);
	const [activeError, setActiveError] = React.useState(0);
	const [open, setOpen] = React.useState(false);
	const [steps, setSteps] = React.useState([] as { label: string, component: React.ReactNode }[]);
	const [activeStep, setActiveStep] = React.useState(0);
	const [completed, setCompleted] = React.useState<{
		[k: number]: boolean;
	}>({});


	const totalSteps = () => {
		return steps.length;
	};

	const completedSteps = () => {
		return Object.keys(completed).length;
	};

	const isLastStep = () => {
		return activeStep === totalSteps() - 1;
	};

	const allStepsCompleted = () => {
		return completedSteps() === totalSteps();
	};

	const handleNext = () => {
		console.log(activeStep, "active step next")
		if (activeStep === 1) {
			// kiểm tra các ghế đã chọn
			checkSelect()
		}

		// không next đến bước 3 nếu như chọn ghế không đúng
		if (!preventNext && activeStep !== 1) {
			const newActiveStep =
				isLastStep() && !allStepsCompleted()
					? // It's the last step, but not all steps have been completed,
					// find the first step that has been completed
					steps.findIndex((step, i) => !(i in completed))
					: activeStep + 1;
			setActiveStep(newActiveStep);
		}

	};

	const handleBack = () => {

		setActiveStep((prevActiveStep) => prevActiveStep - 1);
		console.log(activeStep, "active step back")

	};

	const handleStep = (step: number) => {
		console.log(step, "handle step")
		if (step === 2) {
			// kiểm tra các ghế đã chọn
			if(checkSelect()){
				return;

			}
			else{
				setActiveStep(step);

			}
			return;
			console.log(preventNext, "in check select")
			
		}
		// không next đến bước 3 nếu như chọn ghế không đúng

		console.log(preventNext, step !== 2, "!preventNext && step !== 2")

		if (preventNext && step !== 2) {
			console.log(preventNext, "prevent next true")

			setActiveStep(step);

			return;

		}
		console.log(preventNext, step !== 2, "prevent after reuturn")

		if (!preventNext) {
			setActiveStep(step);
		}



	};

	const handleComplete = () => {
		const newCompleted = completed;
		newCompleted[activeStep] = true;
		setCompleted(newCompleted);
		handleNext();
	};

	const handleReset = () => {
		setActiveStep(0);
		setCompleted({});
	};

	//

	function compare(a: SeatState, b: SeatState) {

		if (a.rowIndex === b.rowIndex) {
			return a.columnIndex - b.columnIndex
		}
		return a.rowIndex - b.rowIndex;
	}

	const onClose = () => setOpen(false);
	const checkSelect =  (): boolean => {
		console.log(classSelect, "class select booking")
		const seat_selected = [...classSelect].sort(compare);
		console.log(seat_selected)
		if(seat_selected.length < chooseTotal) {
			setOpen(true);
			setPreventNext(true);
			setActiveError(1);
			return true;
		}		
		console.log("after compare length")
		for (let i = 0; i < seat_selected.length - 1; i++) {
			if (seat_selected[i].rowIndex === seat_selected[i + 1].rowIndex
				&& Math.abs(seat_selected[i].columnIndex - seat_selected[i + 1].columnIndex) === 2) {
				setPreventNext(true);
				setOpen(true);
				setActiveError(0);
				return true;
			}
		}
		setPreventNext(false);
		return false;
	}

	React.useEffect(() => {

		// console.log(activeStep, "idle")
		// console.log(completed, "k in complete")
		dispatch(resetQuantityBookTicket())

		// dispatch(emptyBookCombo())
		setSteps([{
			label: 'Đặt loại vé và đồ ăn',
			component: <BookingTicket />
		}, {
			label: 'Chọn ghế',
			component: <Auditorium />
		}, {
			label: 'Thanh toán',
			component: <Payment />
		}])

	}, [dispatch])

	return (

		<Container>
			<Grid container spacing={4}>
				<Grid item xs={9} >
					<Box sx={{ width: '100%' }}>
						<Stepper nonLinear activeStep={activeStep}>
							{steps.map((step, index) => (
								<Step key={step.label} completed={completed[index]}>
									<StepLabel StepIconComponent={ColorlibStepIcon} color="inherit" onClick={() => handleStep(index)} sx={{ cursor: preventNext ? "not-allowed" : "" }}>
										{step.label}
									</StepLabel>
								</Step>
							))}
						</Stepper>
						<div>
							{allStepsCompleted() ? (
								<React.Fragment>
									<Typography sx={{ mt: 2, mb: 1 }}>
										Các bước đặt của bạn đã hoàn thành
									</Typography>
									<Box sx={{ display: 'flex', flexDirection: 'row', pt: 2 }}>
										<Box sx={{ flex: '1 1 auto' }} />
										<Button onClick={handleReset}>Đặt lại</Button>
									</Box>
								</React.Fragment>
							) : (
								<React.Fragment>
									<Box sx={{ mt: 2, mb: 1, py: 1 }}>
										{steps[activeStep].component}
									</Box>
									<Box sx={{ display: 'flex', flexDirection: 'row', pt: 2 }}>
										<Button
											variant="outlined"
											color="inherit"
											disabled={activeStep === 0}
											onClick={handleBack}
											startIcon={<ArrowBack />}
											sx={{ mr: 1 }}

										>

											Quay lại
										</Button>
										<Box sx={{ flex: '1 1 auto' }} />
										<Button
											variant="outlined"
											onClick={handleNext}
											sx={{ mr: 1 }}
											startIcon={<ArrowForward />}>

											Kế tiếp
										</Button>
										{activeStep !== steps.length &&
											(completed[activeStep] ? (
												<Typography variant="caption" sx={{ display: 'inline-block' }}>
													Bước {activeStep + 1} đã hoàn thành
												</Typography>
											) : (
												<Button
													variant='outlined'
													onClick={handleComplete}>
													{completedSteps() === totalSteps() - 1
														? 'Kết thúc'
														: 'Hoàn thành'}
												</Button>
											))}
									</Box>
								</React.Fragment>
							)}
						</div>
					</Box>
				</Grid>
				<Grid item xs={3} >
					<BookingInfo />
				</Grid>
			</Grid>
			<Confirm
				content={show_error[activeError]}
				open={open}
				confirmButton="Vâng"
				onConfirm={onClose}
				cancelButton={false}
				className="bg-gray-700 text-white text-lg"
				size="tiny"

			/>
		</Container>

	);
}

export default Booking;