import moment from "moment";
import React, { useCallback, useEffect, useState } from "react"
import { useParams } from "react-router-dom";
import { Button, Checkbox, Container, Form, Grid, Header, Image, Label, List, Segment, Tab } from "semantic-ui-react";
import TicketPurchaseForm from "../../components/actors/TicketPurchaseForm";
import MovieSlideBar from "../../components/movies/MovieSlideBar";
import { GetDetailActor } from "../../services/actor.service";
import { Actor } from "./actorSlice";


interface ActorDetailParams {
    id: string
}
interface ActorDetailProps {
}

const panes = [
    {
        menuItem: 'Hình ảnh',
        render: () => <Tab.Pane attached={false} className="bg-gray-700">
            <List horizontal>
                <List.Item>
                    <Image size="small" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />

                </List.Item>
                <List.Item>
                    <Image size="small" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />
                </List.Item>
                <List.Item>
                    <Image size="small" src='https://react.semantic-ui.com/images/wireframe/image-text.png' />
                </List.Item>
            </List>
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
]


const ActorDetail: React.FC<ActorDetailProps> = (props) => {
    const { id } = useParams<ActorDetailParams>();
    const [actor, setActor] = useState<Actor>();


    const GetActor = useCallback(async () => {
        const result = await GetDetailActor(id);
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
            <Image rounded src={actor?.image} />
        </Grid.Column>
        <Grid.Column width={10} className='text-white'>
            <Header as='h2' className='text-blue-600'>{actor?.name}</Header>
            <p><Label as='a' content={actor?.viewCount} icon='eye' /></p>
            <p>
                Ngày sinh: {moment(actor?.dateOfBirth).format("DD/MM/YYYY")}
            </p>
            <p>
                Chiều cao: {actor?.height}
            </p>
            <p>
                Quốc tịch: {actor?.nationality}
            </p>
        </Grid.Column>
    </Grid>


    const Story = <Grid>
        <Grid.Column width={16}>
            <Tab menu={{ secondary: true, pointing: true }} panes={panes} />
        </Grid.Column>
        <Grid.Column width={16}>
            <Header as='h3' dividing>
                Tiểu sử
            </Header>
        </Grid.Column>
    </Grid>


    return (
        <Container>
            <Grid>
                <Grid.Column computer={10} mobile={16}>
                    {Actor}
                    {Story}
                </Grid.Column>

                <Grid.Column computer={6} mobile={16}>
                    <TicketPurchaseForm></TicketPurchaseForm>
                    <MovieSlideBar></MovieSlideBar>
                </Grid.Column>
            </Grid>

        </Container>
    )
}

export default ActorDetail;