import React from "react";
import { Button, Checkbox, Form, Icon, Input } from "semantic-ui-react";
import PaymentSelect from "../../components/common/PaymentSelect";
import "./payment.css"

const Payment: React.FC<{}> = () => {


    return (
        <>

            <div className="bg-gray-700 flex flex-col justify-center">
                <Form className="  relative pb-10 pt-5 rounded px-10 md:w-7/12 w-full mx-auto " >
                    <Form.Group grouped widths={1} className="">
                        {/* <Form.Dropdown as={} /> */}

                        <Form.Field width={16} >
                            <label className="text-white">Họ và tên</label>
                            <Input placeholder='Họ và tên' />
                        </Form.Field>
                        <Form.Field width={16}>
                            <label className="text-white">Email</label>
                            <Input type="email" placeholder='Email' />
                        </Form.Field>
                        <Form.Field width={16}>
                            <label className="text-white">Số điện thoại</label>
                            <Input type="tel" placeholder='Số điện thoại' />
                        </Form.Field>
                    </Form.Group>

                    <Form.Group grouped widths={1}>
                        <Form.Field width={16}>
                            <label className="text-white">Phương thức thanh toán</label>
                            <PaymentSelect onPaymentSelect={() => { }} className="bg-gray-500 text-white"></PaymentSelect>
                        </Form.Field>
                        <Form.Field width={16}>
                            <label className="text-white">Mã giảm giá</label>
                            <Input type="text" placeholder='Mã giảm giá' />
                        </Form.Field>
                        <Form.Field width={16} className="pt-2">
                            <Button type='button' color="orange" fluid>Áp dụng</Button>
                        </Form.Field>
                    </Form.Group>
                    <Form.Group grouped widths={1}>
                        <Form.Field width={16}>
                            <Checkbox defaultChecked label="Cam kết mua vé xem phim này cho người xem ở độ tuổi quy định và tôi đã đọc và đồng ý với Điều Kiện và Điều Khoản." />

                        </Form.Field>

                    </Form.Group>
                    <Form.Group widths={2} unstackable className="justify-end">
                        <Form.Button color="orange" icon labelPosition="left" size="large" className="text-end">
                            <Icon name='arrow left' />
                            Quay lại
                        </Form.Button>
                        <Form.Button color="orange" icon labelPosition="left" size="large"  >
                            <Icon name='payment' />
                            Thanh toán
                        </Form.Button>

                    </Form.Group>

                </Form>
            </div>



        </>
    )
}

export default Payment;