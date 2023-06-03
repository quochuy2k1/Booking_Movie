interface ISTATUS_MESSAGE{
    [key : string]: string;
}


export const STATUS_MESSAGE : ISTATUS_MESSAGE = {
    USER_NAME_NOT_EXISTS: "Tài khoản không tồn tại.",
    PASSWORD_INCORRECT: "Mật khẩu không chính xác.",
    SIGN_IN_SUCCESS: "Đăng nhập thành công.",
}

export const STATUS_RESPONSE : string[] = ["error", "success"]
