import * as React from "react"
import { Container, Divider, Grid, List, Segment, Image, Header, Button } from "semantic-ui-react";


const Footer: React.FC<{}> = ({ }) => {
    return (
        <Segment inverted vertical style={{ margin: '5em 0em 0em', padding: '5em 0em' }}>
            <Container textAlign='left'>
                <Grid divided inverted stackable>
                    <Grid.Column width={3}>
                        <Header inverted as='h4' content='Giới thiệu' />
                        <List link inverted>
                            <List.Item as='a'>Về chúng tôi</List.Item>
                            <List.Item as='a'>Thoả thuận sử dụng</List.Item>
                            <List.Item as='a'>Quy chế hoạt động</List.Item>
                            <List.Item as='a'>Chính sách bảo mật</List.Item>
                        </List>
                    </Grid.Column>
                    <Grid.Column width={3}>
                        <Header inverted as='h4' content='Gốc điện ảnh' />
                        <List link inverted>
                            <List.Item as='a'>Thể loại phim</List.Item>
                            <List.Item as='a'>Bình luận phim</List.Item>
                            <List.Item as='a'>Blog điện ảnh</List.Item>
                            <List.Item as='a'>Phim hay tháng</List.Item>
                        </List>
                    </Grid.Column>
                    <Grid.Column width={3}>
                        <Header inverted as='h4' content='Hỗ trợ' />
                        <List link inverted>
                            <List.Item as='a'>Góp ý</List.Item>
                            <List.Item as='a'>Sale & Service</List.Item>
                            <List.Item as='a'>Rạp / Giá vé</List.Item>
                            <List.Item as='a'>Tuyển dụng</List.Item>
                        </List>
                    </Grid.Column>
                    <Grid.Column width={7}>
                        <Header inverted as='h4' content='Kết nối với Galaxy Quốc Huy' />
                        <div className="flex gap-1">
                            <Button icon='facebook square' />
                            <Button icon='youtube' />
                            <Button icon='instagram' />
                        </div>
                    </Grid.Column>
                </Grid>

                <Divider inverted section />
                <div className="flex justify-center flex-col py-2">
                <Image centered  src='/logo-white.svg' />
                <p className="text-gray-200 italic py-4 text-center">Công Ty Cổ Phần Phim Berry, Tầng 3, Toà Nhà justin Đồng Tháp, 5, Đ. 30 Tháng 4, Phường 1, TP. Cao Lãnh, Đồng Tháp</p>
                </div>
            </Container>
        </Segment>
        );
}

export default Footer;