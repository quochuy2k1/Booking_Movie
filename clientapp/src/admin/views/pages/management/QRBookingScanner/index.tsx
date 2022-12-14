import moment from "moment";
import React from "react";
import { useState } from "react";
import { QrReader } from "react-qr-reader";
import { Container, Header, Item, Label, Image, Grid, Button } from "semantic-ui-react";


const QRBookingScanner: React.FC = () => {
    const [data, setData] = useState<string>("")
    return (
       <>
        
            <Grid >
                <Grid.Column width={5}>
                <Header as="h3" color="orange" >{"Nơi quét mã"}</Header>
                    <QrReader
                        onResult={(result, error) => {
                            if (!!result) {
                                setData(result.getText());
                            }

                            if (!!error) {
                                console.info(error);
                            }
                        }}
                        // scanDelay={5}
                        videoId="123"
                        ViewFinder={(props) => <svg width="50px" viewBox="0 0 100 100" fill="none" xmlns="http://www.w3.org/2000/svg" style={{ top: 0, left: 0, zIndex: 1, boxSizing: 'border-box', border: '50px solid rgba(0, 0, 0, 0.3)', position: 'absolute', width: '100%', height: '100%' }}>
                            <path fill="none" d="M13,0 L0,0 L0,13" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                            <path fill="none" d="M0,87 L0,100 L13,100" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                            <path fill="none" d="M87,100 L100,100 L100,87" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                            <path fill="none" d="M100,13 L100,0 87,0" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                        </svg>
                        }
                        constraints={{ facingMode: 'user' }}
                        containerStyle={{ width: '100%' }}
                        className="pb-4"
                    //     videoContainerStyle={{ width: "50%" }}
                    // // videoStyle={{width: "50%"}}
                    />
                      <Button content='Xác nhận' size="large" color="orange" fluid icon='ticket alternate' labelPosition='left' />
                </Grid.Column>

                <Grid.Column width={6}>
                <Header as="h3" color="orange" >{"Kết quả quét"}</Header>
                    <div className="sticky top-0 bg-gray-700 p-5">
                        <Image src={`https://localhost:7157/movie-content/1b2d77e3-41c2-4d4d-bb1b-0b4e46236a80.jpg`}></Image>
                        <Header as="h3" className="text-orange-600">{"Hạnh phúc máu"}</Header>
                        <Item.Group divided>
                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    Rạp: {"Galaxy Nguyễn Du"} | {"phòng 02"}
                                </Item.Content>
                            </Item>

                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    Suất chiếu: {moment("2022-12-13T11:30:29.085Z").format("HH:mm")} | {"phong-02"}
                                </Item.Content>
                            </Item>

                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    Combo: {[{ id: 1, name: "iCombo 1 Big Extra", quantity: 2 }, { id: 2, name: "iCombo Friends 1 Big ", quantity: 2 }].map((combo: any) => combo.quantity! > 0 && (<Label key={combo.id} className="my-1" color='teal' horizontal>
                                        {`${combo.name} (${combo.quantity})`}
                                    </Label>))}
                                </Item.Content>
                            </Item>
                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    Ghế: {"B1, B2"}
                                </Item.Content>
                            </Item>
                        </Item.Group>
                    </div>
                </Grid.Column>
                <p>{data}</p>
            </Grid>
        </>
       

    )
}

export default QRBookingScanner;