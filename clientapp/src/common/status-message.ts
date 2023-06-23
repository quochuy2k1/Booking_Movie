interface ISTATUS_MESSAGE{
    [key : string]: string;
}


export const STATUS_MESSAGE : ISTATUS_MESSAGE = {
    USER_NAME_NOT_EXISTS: "Tài khoản không tồn tại.",
    PASSWORD_INCORRECT: "Mật khẩu không chính xác.",
    SIGN_IN_SUCCESS: "Đăng nhập thành công.",
    UPDATE_SUCCESS: "Cập nhật thành công.",
    UPDATE_FAILD: "Cập nhật không thành công.",
    ADD_SUCCESS: "Thêm thành công.",
    ADD_FAILD: "Thêm không thành công.",
    DELETE_SUCCESS: "Xóa thành công.",
    DELETE_FAILD: "Xóa không thành công.",
    SAVE_SUCCESS: "Lưu thành công.",
    SAVE_FAILD: "Lưu không thành công.",
    SCAN_SUCCESS: "Quét thành công.",
    BOOK_MOVIE_FAILD: "Có lỗi xãy ra trong quá trình đắt phim. Vui lòng đặt lại.",

    SHOW_DATE_OUT_OF_RANGE: "Ngày chiếu phim ngoài phạm vi cho phép",

    FORIEGNKEY_CONFLICT: "Không thể xóa giờ chiếu vì giờ chiếu đã được sử dụng trước đó.",
}

export const STATUS_RESPONSE : string[] = ["error", "success"]
