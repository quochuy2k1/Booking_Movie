import { useEffect, useState } from "react";
import { Dropdown, Input, Image } from "semantic-ui-react";
import avatar from "../../../../public/avatar-placeholder.jpg"
import { useAppDispatch } from "../../../app/hooks";
import { SignOutAsync } from "../../../slices/user/userSlice";
import { Link } from "react-router-dom";

interface userInfoState {
    lastName: string,
    firstName: string,
    userName: string,
    isSignIn: boolean
}


const UserInfo: React.FC<{}> = () => {

    const dispatch = useAppDispatch();
    const [uInfo, setUInfo] = useState<userInfoState>();

    useEffect(() => {
        const user_authenticate: userInfoState | null = JSON.parse(localStorage.getItem("user_authenticate")!);
        if (user_authenticate) {
            setUInfo(user_authenticate);
        }
    }, [])

    return (
        <>
            <Dropdown
                trigger={<><Image avatar src={avatar}></Image> {`${uInfo?.firstName} ${uInfo?.lastName}`} </>}
                floating
                labeled
            >
                <Dropdown.Menu>
                    <Dropdown.Header className="text-white" content='Tìm thông tin' />
                    <Input icon='search' iconPosition='left' name='search' placeholder="Tìm thông tin" />
                    <Dropdown.Header icon='tags' className="text-white" content='Thông tin' />
                    <Dropdown.Divider />
                    <Dropdown.Item
                    as={Link}
                        icon="history"
                        text='Lịch sử đặt vé'
                        to={`user/history-booking/`}
                    />
                    {/* <Dropdown.Item
                        label={{ color: 'blue', empty: true, circular: true }}
                        text='Announcement'
                    /> */}
                    <Dropdown.Item
                        icon="sign-out"
                        text='Đăng xuất'
                        onClick={() => { dispatch(SignOutAsync()) }}
                    />
                </Dropdown.Menu>
            </Dropdown>
        </>
    )
}

export default UserInfo;