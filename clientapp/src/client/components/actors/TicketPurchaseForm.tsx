import { Segment, Form, Button, Select, Rail } from "semantic-ui-react"

const countryOptions = [
    { key: 'af', value: 'af', text: 'Afghanistan' },
    { key: 'ax', value: 'ax', text: 'Aland Islands' },
    { key: 'al', value: 'al', text: 'Albania' },
]

const TicketPurchaseForm: React.FC<{}> = (props) => {

    return (
        <Segment className="relative bg-gray-700">
            <Rail internal position='left' size="small" className="m-0 p-0 w-fit">
                <Segment textAlign="center" size="large" className="text-xl leading-3"  inverted color="orange">Mua vé nhanh</Segment>
            </Rail>
            <Form className="mt-16">

                <Form.Field>
                    <Select placeholder='Chọn phim' options={countryOptions} className="bg-gray-500 text-white" />
                </Form.Field>
                <Form.Field>
                    <Select placeholder='Chọn rạp' options={countryOptions} className="bg-gray-500 text-white"/>

                </Form.Field>
                <Form.Field>
                    <Select placeholder='Chọn ngày' options={countryOptions} className="bg-gray-500 text-white"/>
                </Form.Field>
                <Form.Field>
                    <Select placeholder='Chọn suất' options={countryOptions} className="bg-gray-500 text-white"/>
                </Form.Field>
                <Button type='submit' floated="right" color="orange" size="large">Mua vé</Button>
                <div className="clear-both"></div>
            </Form>
        </Segment>
    )
}

export default TicketPurchaseForm;