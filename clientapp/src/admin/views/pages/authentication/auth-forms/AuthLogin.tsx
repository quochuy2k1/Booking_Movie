import React, { useEffect, useMemo, useState } from 'react';
import { useSelector } from 'react-redux';

// material-ui
import { useTheme } from '@mui/material/styles';
import {
    Alert,
    Box,
    Button,
    Checkbox,
    Collapse,
    Divider,
    FormControl,
    FormControlLabel,
    FormHelperText,
    Grid,
    IconButton,
    InputAdornment,
    InputLabel,
    OutlinedInput,
    Stack,
    Typography,
    useMediaQuery
} from '@mui/material';

// third party
import * as Yup from 'yup';
import { Formik, useFormikContext } from 'formik';

// project imports
import useScriptRef from '../../../../hooks/useScriptRef';
import AnimateButton from '../../../../ui-component/extended/AnimateButton';

// assets
import Visibility from '@mui/icons-material/Visibility';
import VisibilityOff from '@mui/icons-material/VisibilityOff';

import Google from '../../../../assets/images/icons/social-google.svg';
import { RootState } from '../../../../store';
import { useAppDispatch, useAppSelector } from '../../../../../app/hooks';
import { emptyUserError, SignInAsync } from '../../../../../slices/user/userSlice';
import { Close } from '@mui/icons-material';
import { emptyMovieError } from '../../../../../slices/movie/movieSlice';
import { Navigate, useLocation, useNavigate } from 'react-router-dom';

// ============================|| FIREBASE - LOGIN ||============================ //

const AutoSubmitToken = () => {
    // Grab values and submitForm from context
    const { setErrors  } = useFormikContext();
    const {status, error } = useAppSelector((state) => state.user);
    const dispatch =  useAppDispatch();


    useEffect(() => {
        console.log(error, "eror")
        error && setErrors({username: error.userNameError, password: error.passwordError})
        dispatch(emptyUserError());
        
   }, [dispatch, error, setErrors])
    return null;
  };

const FirebaseLogin: React.FC<{[others: string]: any}> = ({ ...others }) => {

    const theme = useTheme();
    const dispatch =  useAppDispatch();
    const scriptedRef = useScriptRef();
    const Navigation = useNavigate();
    const matchDownSM = useMediaQuery(theme.breakpoints.down('md'));
    const customization = useAppSelector((state) => state.customization);
    const {status, error } = useAppSelector((state) => state.user);

    const [checked, setChecked] = useState(true);
    // const [userName, setUserName] = useState<string>("");
    // const [password, setPassword] = useState<string>("");
	const [openError, setOpenError] = React.useState<boolean>(false);


    const googleHandler = async () => {
        console.error('Login');
    };

    const [showPassword, setShowPassword] = useState(false);
    const handleClickShowPassword = () => {
        setShowPassword(!showPassword);
    };

    const handleMouseDownPassword = (event: React.MouseEvent<HTMLButtonElement>) => {
        event.preventDefault();
    };

    useEffect(() => {
        var user_auth = JSON.parse(localStorage.getItem("user_authenticate")!);
        if (user_auth && status === "idle") {
            Navigation(-1)
        }
      
    }, [ Navigation, status])
   

    return (
        <>
        
            <Grid container direction="column" justifyContent="center" spacing={2}>
                {/* <Grid item xs={12}>
                    <AnimateButton>
                        <Button
                            disableElevation
                            fullWidth
                            onClick={googleHandler}
                            size="large"
                            variant="outlined"
                            sx={{
                                color: 'grey.700',
                                backgroundColor: theme.palette.grey[50],
                                borderColor: theme.palette.grey[100]
                            }}
                        >
                            <Box sx={{ mr: { xs: 1, sm: 2, width: 20 } }}>
                                <img src={Google} alt="google" width={16} height={16} style={{ marginRight: matchDownSM ? 8 : 16 }} />
                            </Box>
                            Sign in with Google
                        </Button>
                    </AnimateButton>
                </Grid> */}
                {/* <Collapse in={openError} >
					<Alert
						variant='filled'
						severity='error'
						action={
							<IconButton
								aria-label="close"
								color="inherit"
								size="small"
								onClick={() => {
									setOpenError(false);
									dispatch(emptyUserError());
								}}
							>
								<Close fontSize="inherit" />
							</IconButton>
						}
						sx={{ mb: 2 }}
					>
						{error}
					</Alert>
				</Collapse> */}
                <Grid item xs={12}>
                    <Box
                        sx={{
                            alignItems: 'center',
                            display: 'flex'
                        }}
                    >
                        <Divider sx={{ flexGrow: 1 }} orientation="horizontal" />

                        {/* <Button
                            variant="outlined"
                            sx={{
                                cursor: 'unset',
                                m: 2,
                                py: 0.5,
                                px: 7,
                                borderColor: `${theme.palette.grey[100]} !important`,
                                color: `${theme.palette.grey[900]}!important`,
                                fontWeight: 500,
                                borderRadius: `${customization.borderRadius}px`
                            }}
                            disableRipple
                            disabled
                        >
                            OR
                        </Button> */}

                        <Divider sx={{ flexGrow: 1 }} orientation="horizontal" />
                    </Box>
                </Grid>
                <Grid item xs={12} container alignItems="center" justifyContent="center">
                    <Box sx={{ mb: 2 }}>
                        <Typography variant="subtitle1">Đăng nhập bằng tài khoản quản trị</Typography>
                    </Box>
                </Grid>
            </Grid>

            <Formik
                initialValues={{
                    username: "",
                    password: "",
                    remember: true,
                    submit: null
                }}
           
                validationSchema={Yup.object().shape({
                    username: Yup.string().max(255).required('Vui lòng nhập tài khoản'),
                    password: Yup.string().max(255).required('Vui lòng nhập mật khẩu').matches(
                        /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/,
                        "Phải chứa 8 ký tự, một chữ hoa, một chữ thường, một số và một ký tự đặc biệt."
                      ),
                })}
                onSubmit={ async (values, { setErrors, setStatus, setSubmitting }) => {
                    console.log(values, "values submit", scriptedRef)
                    try {
                        dispatch(SignInAsync({ UserName: values.username, Password: values.password, Remember:values.remember })) 
                    //    .then((value: any) => setErrors({username: value.payload.userNameError, password: value.payload.passwordError}))
                        
                        if (scriptedRef.current) {
                            setStatus({ success: true });
                            setSubmitting(false);
                        }
                    } catch (err: any) {
                        console.error(err);
                        if (scriptedRef.current) {
                            setStatus({ success: false });
                            setErrors({ submit: err.message });
                            setSubmitting(false);
                        }
                    }
                }}
            >
                {({ errors, handleBlur, handleChange, handleSubmit, isSubmitting, touched, values }) => (
                    <form noValidate onSubmit={handleSubmit} {...others}>
                        <FormControl fullWidth error={Boolean(touched.username && errors.username)} sx={{ ...theme.typography.customInput }}>
                            <InputLabel htmlFor="outlined-adornment-email-login">Tài khoản</InputLabel>
                            <OutlinedInput
                                id="outlined-adornment-email-login"
                                type="text"
                                value={values.username}
                                name="username"
                                onBlur={handleBlur}
                                onChange={handleChange}
                                label="username"
                                inputProps={{}}
                            />
                            {touched.username && errors.username && (
                                <FormHelperText error id="standard-weight-helper-text-email-login">
                                    {errors.username}
                                </FormHelperText>
                            )}
                        </FormControl>

                        <FormControl
                            fullWidth
                            error={Boolean(touched.password && errors.password)}
                            sx={{ ...theme.typography.customInput }}
                        >
                            <InputLabel htmlFor="outlined-adornment-password-login">Mật khẩu</InputLabel>
                            <OutlinedInput
                                id="outlined-adornment-password-login"
                                type={showPassword ? 'text' : 'password'}
                                value={values.password}
                                name="password"
                                onBlur={handleBlur}
                                onChange={handleChange}
                                endAdornment={
                                    <InputAdornment position="end">
                                        <IconButton
                                            aria-label="toggle password visibility"
                                            onClick={handleClickShowPassword}
                                            onMouseDown={handleMouseDownPassword}
                                            edge="end"
                                            size="large"
                                        >
                                            {showPassword ? <Visibility /> : <VisibilityOff />}
                                        </IconButton>
                                    </InputAdornment>
                                }
                                label="Password"
                                inputProps={{}}
                            />
                            {touched.password && errors.password && (
                                <FormHelperText error id="standard-weight-helper-text-password-login">
                                    {errors.password}
                                </FormHelperText>
                            )}
                        </FormControl>
                        <Stack direction="row" alignItems="center" justifyContent="space-between" spacing={1}>
                            <FormControlLabel
                                control={
                                    <Checkbox
                                        value={values.remember}
                                        checked={checked}
                                        onChange={(event) => setChecked(event.target.checked)}
                                        name="checked"
                                        color="primary"
                                    />
                                }
                                label="Nhớ lần đăng nhập sau?"
                            />
                            {/* <Typography variant="subtitle1" color="secondary" sx={{ textDecoration: 'none', cursor: 'pointer' }}>
                                Forgot Password?
                            </Typography> */}
                        </Stack>
                        {errors.submit && (
                            <Box sx={{ mt: 3 }}>
                                <FormHelperText error>{errors.submit}</FormHelperText>
                            </Box>
                        )}

                        <Box sx={{ mt: 2 }}>
                            <AnimateButton>
                                <Button
                                    disableElevation
                                    disabled={isSubmitting}
                                    fullWidth
                                    size="large"
                                    type="submit"
                                    variant="contained"
                                    color="secondary"
                                >
                                    Đăng nhập
                                </Button>
                            </AnimateButton>
                        </Box>
                <AutoSubmitToken/>

                    </form>
                )}
            </Formik>
        </>
    );
};

export default FirebaseLogin;
