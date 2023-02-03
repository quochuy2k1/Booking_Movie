import { ReactNode, useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { checkLogin } from "../../../slices/user/userSlice";

export const ProtectedRoute: React.FC<{ children: ReactNode,}> = ({ children,  }) => {

    const {movieId}= useParams<{movieId: string}>();
    const dispatch = useAppDispatch();
    const [userAuth, setUserAuth] = useState<object | null>(null);
    const isLogin = useAppSelector(state => state.user.isLogin);
    const navigation = useNavigate();

    
    useEffect(() => {
        console.log(movieId, "movieID")
        var user_auth = JSON.parse(localStorage.getItem("user_authenticate")!);
        setUserAuth(user_auth);
        var exp_token = localStorage.getItem("exp_token");
        console.log(Date.now(), new Date(exp_token!).getMilliseconds)
        var exp_convert_to_date = new Date(exp_token!).getTime();
        if (exp_token) {
            if (Date.now() >= exp_convert_to_date) {
                localStorage.removeItem("user_authenticate")
                localStorage.removeItem("exp_token")
                localStorage.removeItem("sessionId")

                // token hết hạn thì thông tin authenticate cũng không còn

                setUserAuth(null);
            }
        }
        if (!user_auth || isLogin === false) {
            // user is not authenticated
            // loginHandle(false);
            // dispatch(checkLogin({isLogin: false}))
            navigation(`/`, { replace : false});
            
        }

    }, [isLogin, movieId, navigation])
    
    return <>{children}</>;
};