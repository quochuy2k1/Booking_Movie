import moment from "moment";
import React, { useCallback, useEffect, useState } from "react"
import { useParams } from "react-router-dom";
import { Button, Container, Grid, Header, Image, Label, List, Tab } from "semantic-ui-react";
import TicketPurchaseForm from "../../components/actors/TicketPurchaseForm";
import MovieSlideBar from "../../components/movies/MovieSlideBar";
import { GetDetailActor } from "../../../services/actor.service";
import { Actor } from "../../../slices/actor/actorSlice";
import ActorImage from "./actorImage";


// interface ActorDetailParams {
//     id: string
// }
interface ActorDetailProps {
}



const ActorDetail: React.FC<ActorDetailProps> = (props) => {
    const { id } = useParams<string>();
    const [actor, setActor] = useState<Actor>();


    const GetActor = useCallback(async () => {
        const result = await GetDetailActor(id!);
        const data: Actor = result.data;
        setActor({
            ...data
        })
    }, [id]);

    useEffect(() => {
        GetActor();
    }, [GetActor])


    // thông tin actor
    const Actor = <Grid>
        <Grid.Column width={6}>
            <Image rounded src={actor?.image ? actor?.image : 'https://via.placeholder.com/150x225'} />
        </Grid.Column>
        <Grid.Column width={10} className='text-white'>
            <Header as='h2' className='text-blue-600'>{actor?.name}</Header>
            <p className="py-1"><Label as='a' content={actor?.viewCount} icon='eye' /></p>
            <p className="py-1 text-base">
                Ngày sinh: {moment(actor?.dateOfBirth).format("DD/MM/YYYY")}
            </p>
            <p className="py-1 text-base">
                Chiều cao: {actor?.height}
            </p>
            <p className="py-1 text-base">
                Quốc tịch: {actor?.nationality}
            </p>
        </Grid.Column>
    </Grid>


    const Story = <Grid>
        <Grid.Column width={16}>
            <Tab menu={{ secondary: true, pointing: true }} panes={[
                {
                    menuItem: 'Hình ảnh',
                    render: () => <Tab.Pane attached={false} className="bg-gray-700">
                        <ActorImage id={id} />
                    </Tab.Pane>,
                },
                {
                    menuItem: 'Phim đã tham gia',
                    render: () => <Tab.Pane attached={false} className="bg-gray-700" >
                        <List divided verticalAlign='middle' >
                            <List.Item>
                                <List.Content floated='right' verticalAlign="middle">
                                    <Header as={"h5"} className="pt-2 font-semibold text-white">Vai diễn</Header>
                                </List.Content>
                                <Image size="mini" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />
                                <List.Content className="text-lg font-medium text-white">Lena</List.Content>
                            </List.Item>
                            <List.Item>
                                <List.Content floated='right' verticalAlign="middle">
                                    <Header as={"h5"} className="pt-2 font-semibold text-white">Vai diễn</Header>

                                </List.Content>
                                <Image size="mini" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />
                                <List.Content className="text-lg font-medium text-white">Lindsay</List.Content>
                            </List.Item>
                            <List.Item>
                                <List.Content floated='right' verticalAlign="middle">
                                    <Header as={"h5"} className="pt-2 font-semibold text-white">Vai diễn</Header>

                                </List.Content>
                                <Image size="mini" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />
                                <List.Content className="text-lg font-medium text-white">Mark</List.Content>
                            </List.Item>
                            <List.Item>
                                <List.Content floated='right' verticalAlign="middle">
                                    <Header as={"h5"} className="pt-2 font-semibold text-white">Vai diễn</Header>

                                </List.Content>
                                <Image size="mini" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />
                                <List.Content className="text-lg font-medium text-white">Molly</List.Content>
                            </List.Item>
                        </List>
                    </Tab.Pane>,
                },
            ]} />
        </Grid.Column>
        <Grid.Column width={16}>
            <div className="flex flex-col ">
                <Header as='h3' dividing className="text-white">
                    Tiểu sử
                </Header>
                <div >
                    <p /><p><span style={{ fontSize: 14, color: "#fff" }}><strong><em>Khác với Chris Hemsworth vẫn đang loay hoay trong hình tượng vị thần sấm sét, đa số người hâm mộ vẫn nhìn nhận rõ ràng, Chris Evans và Captain America là hai con người hoàn toàn khác nhau. </em></strong></span></p>
                    <p><span style={{ fontSize: 14, color: "#fff" }}>Sinh ngày 13 tháng 6 năm 1981 tại Boston, bang Massachusetts, con đường diễn xuất của cậu&nbsp;</span><span style={{ fontSize: 14, color: "#fff" }}>bé Chris Evans bắt đầu&nbsp;</span><span style={{ fontSize: 14, color: "#fff" }}>từ </span><span style={{ fontSize: 14, color: "#fff" }}>nhỏ với những vở kịch trong trường học. Tình yêu diễn xuất lớn dần theo năm tháng, khi trưởng thành, Evans lắng nghe tiếng gọi con tim, tới New York và thi vào trường nghệ thuật Lee Strasberg.</span></p>
                    <p><span style={{ fontSize: 14, color: "#fff" }}>Theo lời khuyên của bạn bè, anh bắt đầu tham gia thử vai một vài phim rồi dần nhận ra đam mê của bản thân là phim trường chứ không phải sân khấu kịch nghệ. Ban đầu con đường sự nghiệp của Chris khá bằng phẳng. Năm 2000, anh xuất hiện lần đầu tiên trên một phim truyền hình của đài CBS. Sau vài vai diễn nhỏ trên các phim kinh phí thấp, Evans bắt đầu xuất hiện trong các dự án lớn hơn.</span></p>
                    <p><span style={{ fontSize: 14, color: "#fff" }}>Cuối năm 2001, tên tuổi Chris Evans vụt sáng với vai diễn chàng hotboy trường học trong bộ <a href="https://www.galaxycine.vn/phim-dang-chieu"><i>phim chiếu rạp</i></a> <em>Not Another Teen Movie</em>. Chiều cao 1m83 cùng khuôn mặt đẹp trai “chuẩn Mỹ” giúp anh nhanh chóng trở thành người tình trong mộng của nhiều cô gái.</span></p>
                    <p><span style={{ fontSize: 14, color: "#fff" }}>Năm 2004, một cơ hội khác đến với Evans khi anh tham gia vai chính trong bộ phim đầu tư trung bình <em>The Perfect Score</em>. Đáng tiếc, phim nhận thất bại phòng vé nặng nề. Tuy nhiên, đây là chính là bộ phim “đầu tay” của một trong những tình bạn đẹp nhất Holllywood của “nam thần” Chris Evans với “mỹ nhân màn bạc nóng bỏng” Scarlett Johansson.</span></p>
                    <p><span style={{ fontSize: 14, color: "#fff" }}>Sau khi tiếp tục xuất hiện trong vài bộ phim kinh phí thấp với doanh thu không mấy khả quan, vào đầu năm 2005, Evans chính thức đổi đời bằng vai diễn Johnny Storm trong <em>Fantastic Four</em> cùng với Jessica Alba và Ioan Gruffudd. Bướng bỉnh, bốc đồng nhưng lại đẹp trai hấp dẫn khó cưỡng, Johnny Storm - Human Torch của Chris Evans nhanh chóng lấy được cảm tình của người hâm mộ, trở thành một gương mặt trẻ sáng giá của Hollywood.</span></p>
                    <p><span style={{ fontSize: 14, color: "#fff" }}>Không ngoa khi nói rằng Human Torch là vai diễn để đời của Evans, thành công của nhân vật này đủ bảo đảm danh tiếng của anh suốt nhiều năm trời. &nbsp;Thậm chí, cho dù giờ đây, khi Chris Evans đã là Captain Ameica – một trong những Avenger nổi tiếng nhất và Human Torch đã chọn được một diễn viên mới thì cũng không ít người nhớ đến anh thông qua hình tượng này.</span></p>

                </div>
                <Button size="medium" className="self-center" content='Xem nhiều hơn' color="orange" icon='angle double down' labelPosition='left'>

                </Button>
            </div>
        </Grid.Column>
    </Grid>


    return (
        <Container>
            <Grid >
                <Grid.Column computer={10} mobile={16} >
                    {Actor}
                    {Story}
                </Grid.Column>

                <Grid.Column computer={6} mobile={16} >
                    <TicketPurchaseForm></TicketPurchaseForm>
                    <MovieSlideBar></MovieSlideBar>
                </Grid.Column>
            </Grid>

        </Container>
    )
}

export default ActorDetail;