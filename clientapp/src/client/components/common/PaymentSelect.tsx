import React, { useEffect, useMemo, useState } from "react"
import { Dropdown, DropdownProps } from "semantic-ui-react"
import { useAppDispatch } from "../../../app/hooks"
import { GetAllPaymentAsync, PaymentModel } from "../../../slices/payments/PaymentSlice"

// const paymentOptions = [
//     { key: 'af', value: 'Mỹ', text: 'Mỹ' },
//     { key: 'ax', value: 'Úc', text: 'Úc' },
//     { key: 'al', value: 'Trung Quốc', text: 'Trung Quốc' },
//     { key: 'dz', value: 'Hàn Quốc', text: 'Hàn Quốc' },
//     { key: 'as', value: 'Việt Nam', text: 'Việt Nam' },
// ]

interface IPaymentOptions {
    key: string,
    value: string,
    text: string
}

interface IProps {
    onPaymentSelect: (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => void,
    className: string
}

const PaymentSelect: React.FC<IProps> = ({ onPaymentSelect, className }) => {

    const dispatch = useAppDispatch();
    const [paymentOptions, setPaymentOptions] = useState<IPaymentOptions[]>([] as IPaymentOptions[]);

    const getPayments = useMemo(() => (payments: PaymentModel[]): void => {
        const map_payment_to_payment_option: IPaymentOptions[] =  [...payments.map(payment => {
            const payment_option: IPaymentOptions = {
                key: payment.id,
                value: payment.id,
                text: payment.name
            }

            return payment_option;
        })]

        console.log(map_payment_to_payment_option, "map_payment_to_payment_option")
        setPaymentOptions(map_payment_to_payment_option);
    }, []);


    useEffect(() => {
        dispatch(GetAllPaymentAsync()).then(value => value.payload ).then(value => getPayments(value as PaymentModel[]))

        

    }, [dispatch, getPayments])

    return (
        <>
            {
                <Dropdown className={className} placeholder='Chọn phương thức thanh toán' fluid selection options={paymentOptions} onChange={onPaymentSelect} />
            }

        </>
    )
}

export default PaymentSelect;