import * as React from "react"
import { Container, Divider, Grid, List, Segment, Image, Header } from "semantic-ui-react";


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
                        <Header inverted as='h4' content='Kết nối với Galaxy Cinema' />
                        <p>
                            Extra space for a call to action inside the footer that could help re-engage users.
                        </p>
                    </Grid.Column>
                </Grid>

                <Divider inverted section />
                <Image centered size='mini' src='/logo.png' />
                <List horizontal inverted divided link size='small'>
                    <List.Item as='a' href='#'>
                        Site Map
                    </List.Item>
                    <List.Item as='a' href='#'>
                        Contact Us
                    </List.Item>
                    <List.Item as='a' href='#'>
                        Terms and Conditions
                    </List.Item>
                    <List.Item as='a' href='#'>
                        Privacy Policy
                    </List.Item>
                </List>
            </Container>
        </Segment>
        );
}

export default Footer;