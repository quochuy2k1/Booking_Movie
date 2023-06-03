export function ToVietNamCurrency(value?: number | null) {
    // console.log(typeof value, "typeof value")
    return value ? value.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' }).replace(/(\d)(?=(\d{3})+\b)/g, "$1,") : value;
    // return value ? value.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' }).replace(/\./g, ",") : value;
};