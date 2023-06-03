import React from "react";
import { connect } from "react-redux";
import { Location } from "react-router-dom";
import { SignInAsync, UserState, checkLogin } from "../../../slices/user/userSlice";
import { Grid, Header, Form, Segment, Button, Message, Modal, Icon } from "semantic-ui-react";
import { RootState } from "../../../app/store";
import UserInfo from "./UserInfo";
import Notification from "../../components/reusing/notification";
import { STATUS_MESSAGE, STATUS_RESPONSE } from "../../../common/status-message";
import { AlertColor } from "@mui/material";


interface mapToProps {
    SignIn: (UserName: string, Password: string, Remember: boolean) => any,
    CheckLogin: (isLogin: boolean | null) => any
}

type UserProps =
    UserState // ... state we've requested from the Redux store
    & mapToProps
    & Location;

interface IStateLogin {
    open: boolean,
    openNoti: boolean,
    userName: string,
    firstName?: string,
    lastName?: string,
    password: string,
    remember: boolean,
    isSignIn: boolean,
}

// const Login: React.FC<{}> = () => {
//     return(
//         <>
//          <span>Đăng xuất</span>
//         </>
//     )
// }
// export default Login;

class Login extends React.PureComponent<UserProps, IStateLogin> {


    constructor(props: UserProps) {
        super(props);
        this.state = {
            open: false,
            openNoti: false,
            userName: '',
            password: '',
            remember: true,
            isSignIn: false
        }

        this.onChangeUserName = this.onChangeUserName.bind(this)
        this.onChangPassword = this.onChangPassword.bind(this)
        this.onSign = this.onSign.bind(this)
        this.SignInComplete = this.SignInComplete.bind(this)



    }

    componentWillReceiveProps({ isLogin, CheckLogin }: { isLogin: boolean | null, CheckLogin: (isLogin: boolean | null) => any }): void {

        console.log(isLogin, "is login")
        if (isLogin === false) {
            this.setState(pre => ({
                ...pre,
                open: true
            }));
            CheckLogin(null);
        }

        if (isLogin === null) {
            this.setState(pre => ({
                ...pre,
                isSignIn: false
            }));
        }
    }
    componentDidMount(): void {


        console.log(this.props, "login props")
        var user_auth = JSON.parse(localStorage.getItem("user_authenticate")!);
        var exp_token = localStorage.getItem("exp_token");
        console.log(Date.now(), new Date(exp_token!).getMilliseconds)
        var exp_convert_to_date = new Date(exp_token!).getTime();
        if (exp_token) {
            if (Date.now() >= exp_convert_to_date) {
                localStorage.removeItem("user_authenticate")
                localStorage.removeItem("exp_token")
                localStorage.removeItem("sessionId")

                // token hết hạn thì thông tin authenticate cũng không còn

                user_auth = null;
            }
        }
        if (user_auth) {
            this.setState(pre => ({
                ...pre,
                firstName: user_auth.firstName,
                lastName: user_auth.lastName,
                isSignIn: user_auth.isSignIn
            }));
            console.log("logged")
            this.props.CheckLogin(true);
        }
        else {
            this.setState(pre => ({
                ...pre,
                isSignIn: false
            }))
            this.props.CheckLogin(null);
        }

        console.log(this.props)
    }

    onChangeUserName(e: React.ChangeEvent<HTMLInputElement>) {
        e.persist()
        this.setState(pre => ({
            ...pre, userName: e.target.value
        }))
    }
    onChangPassword(e: React.ChangeEvent<HTMLInputElement>) {
        e.persist()
        this.setState(pre => ({
            ...pre, password: e.target.value
        }))
    }

    SignInComplete(): void {
        var user = this.props.appUser;
        console.log(this.props, "sign")
        this.setState(pre => ({
            ...pre, firstName: user.firstName, lastName: user.lastName, isSignIn: true, open: false,
            openNoti: true
        }))
    }

    async onSign() {
        try{
            await this.props.SignIn(this.state.userName, this.state.password, this.state.remember);
            if (this.props.status === "idle") {
                this.SignInComplete()
    
            }
            else if(this.props.status === "failed"){
                this.setState(pre => ({
                    ...pre,
                    openNoti: true
                }))
            }
        }
        catch(error){
            this.setState(pre => ({
                ...pre,
                openNoti: true
            }))
        }
       

        
    }
    public render(): React.ReactNode {
        return (
            <>

                {!this.state.isSignIn ? <Modal
                    onClose={() => this.setState(pre => ({ ...pre, open: false }))}
                    onOpen={() => this.setState(pre => ({ ...pre, open: true }))}
                    size="small"
                    open={this.state.open}
                    trigger={<span>Đăng nhập</span>
                    }
                >
                    <Modal.Header
                        className="bg-gray-700 text-white"
                    >Đăng nhập</Modal.Header>

                    <Modal.Content>
                        <Grid textAlign='center' verticalAlign='middle'>
                            <Grid.Column style={{ maxWidth: 450 }}>
                                <Header as='h2' textAlign='center' className="border-b-white text-white">
                                    Chào mừng bạn trở lại,
                                </Header>
                                <Form size='large'>
                                    <Segment stacked className="py-10 px-10">
                                        <Form.Input
                                            fluid icon='user'
                                            iconPosition='left'
                                            placeholder='Tài khoản'
                                            onChange={this.onChangeUserName} />

                                        <Form.Input
                                            fluid
                                            icon='lock'
                                            iconPosition='left'
                                            placeholder='Password'
                                            type='password'
                                            onChange={this.onChangPassword}
                                        />

                                        <Button color='olive' loading={this.props.status === "loading"} disabled={this.props.status === "loading"} fluid size='large' onClick={this.onSign}>
                                            Đăng nhập
                                        </Button>
                                        <Message>
                                            Bạn là người mới? <a href='.' className="text-blue-700">Đăng ký</a>
                                        </Message>
                                    </Segment>
                                </Form>

                            </Grid.Column>
                        </Grid>
                    </Modal.Content>
                    <Modal.Actions>
                        <Button color='black' onClick={() => this.setState(pre => ({ ...pre, open: false }))}>
                            <Icon name='remove' />   Đóng
                        </Button>

                    </Modal.Actions>
                </Modal>
                    // : <span>{this.state.isSignIn && `${this.state.lastName} ${this.state.firstName} | `}Đăng xuất</span>
                    : <UserInfo></UserInfo>
                }

                <Notification
                    open={this.state.openNoti}
                    severity={STATUS_RESPONSE[this.props.statusResponse!] as AlertColor}
                    message={STATUS_MESSAGE[this.props.statusMessageResponse!]}
                    handleClose={ (event?: Event | React.SyntheticEvent<Element, Event> | undefined, reason?: string | undefined): void => {
                        if (reason === 'clickaway') {
                            return;
                        }
                        this.setState(pre => ({
                            ...pre,
                            openNoti: false
                        }));
                    }} />
            </>
        );
    }
}

const mapDispatchToProps = (dispatch: any) => {
    return {
        // dispatching plain actions
        SignIn: (UserName: string, Password: string, Remember: boolean) => dispatch(SignInAsync({ UserName, Password, Remember })),
        CheckLogin: (isLogin: boolean | null) => dispatch(checkLogin({ isLogin: isLogin }))
    }
}
export default connect(
    (state: RootState) => state.user,
    mapDispatchToProps// Selects which state properties are merged into the component's props
)(Login as any);