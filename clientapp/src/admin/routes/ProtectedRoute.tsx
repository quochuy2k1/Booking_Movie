import { ReactNode, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

export const ProtectedRoute: React.FC<{ children: ReactNode }> = ({ children }) => {
    const [userAuth, setUserAuth] = useState<object | null>(null);
    const navigation = useNavigate();
    useEffect(() => {
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
        if (!user_auth) {
            // user is not authenticated
            navigation("/pages/login/login3", { replace : false});
        }

    }, [navigation])
    
    return <>{children}</>;
};