import React from "react";
import { connect } from "react-redux";
import { Location } from "react-router-dom";
import { SignInAsync, UserState } from "../../../slices/user/userSlice";
import { Grid, Header, Form, Segment, Button, Message, Modal, Icon } from "semantic-ui-react";
import { RootState } from "../../../app/store";


interface mapToProps {
    SignIn: (UserName: string, Password: string) => any
}

type UserProps =
    UserState // ... state we've requested from the Redux store
    & mapToProps
    & Location;

interface IStateLogin {
    open: boolean,
    userName: string,
    firstName?: string,
    lastName?: string,
    password: string,
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
            userName: '',
            password: '',
            isSignIn: false
        }

        this.onChangeUserName = this.onChangeUserName.bind(this)
        this.onChangPassword = this.onChangPassword.bind(this)
        this.onSign = this.onSign.bind(this)
        this.SignInComplete = this.SignInComplete.bind(this)



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
            }))
        }
        else {
            this.setState(pre => ({
                ...pre,
                isSignIn: false
            }))
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
        }))
    }

    async onSign() {
        console.log(await this.props.SignIn(this.state.userName, this.state.password));
        if (this.props.status === "idle") {
            this.SignInComplete()

        }
        console.log(this.props, this.state.isSignIn, "props login sucesss")
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
                                <Header as='h2'  textAlign='center' className="border-b-white text-white">
                                    Chào Mừng Bạn Trở Lại
                                </Header>
                                <Form size='large'>
                                    <Segment stacked className="py-10">
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

                                        <Button color='blue' loading={this.props.status === "loading"} disabled={this.props.status === "loading"} fluid size='large' onClick={this.onSign}>
                                            Đăng nhập
                                        </Button>
                                    </Segment>
                                </Form>
                                <Message>
                                    Bạn là người mới? <a href='.' className="text-blue-700">Đăng ký</a>
                                </Message>
                            </Grid.Column>
                        </Grid>
                    </Modal.Content>
                    <Modal.Actions>
                        <Button color='black' onClick={() => this.setState(pre => ({ ...pre, open: false }))}>
                            <Icon name='remove' />   Đóng
                        </Button>

                    </Modal.Actions>
                </Modal>
                    : <span>{this.state.isSignIn && `${this.state.lastName} ${this.state.firstName} | `}Đăng xuất</span>
                }
            </>
        );
    }
}

const mapDispatchToProps = (dispatch: any) => {
    return {
        // dispatching plain actions
        SignIn: (UserName: string, Password: string) => dispatch(SignInAsync({ UserName, Password }))
    }
}
export default connect(
    (state: RootState) => state.user,
    mapDispatchToProps// Selects which state properties are merged into the component's props
)(Login as any);