import moment from 'moment'
import React, { useCallback, useEffect, useRef, useState } from 'react'
import { connect } from 'react-redux'
import { Link, RouteComponentProps } from 'react-router-dom'
import { Container, DropdownProps, Grid, Header, Item, Label, Loader, Pagination, PaginationProps, Segment } from 'semantic-ui-react'
import { RootState } from '../../app/store'
import TicketPurchaseForm from '../../components/actors/TicketPurchaseForm'
import SelectCountry from '../../components/common/SelectCountry'
import SelectSort from '../../components/common/SelectSortBy'
import MovieSlideBar from '../../components/movies/MovieSlideBar'
import { ActorPagingRequest } from '../../services/actor.service'
import { ActorState, GetAllActorPagingAsync } from './actorSlice'

interface mapToProps {
    GetAllActorPaging: (request: ActorPagingRequest) => any
}

type ActorListProps =
    ActorState &
    mapToProps &
    RouteComponentProps<{}>


const ActorList: React.FC<ActorListProps> = (props) => {

    const { result, total, status, GetAllActorPaging } = props;
    const [sort, setSort] = useState(0);
    const [country, setCountry] = useState("");
    const refToTop = useRef<HTMLDivElement>(null);

    // 2 hàm obChange của select
    const onChangeSort = (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps): void => {
        e.persist();
        setSort(data.value as number)
        console.log('event.currentTarget was', data.value); // null
    }

    const onChangeCountry = (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps): void => {
        e.persist();
        setCountry(data.value as string)
        console.log('event.currentTarget was', data.value); // null

    }

    // Hàm get data từ server
    const ensureDataFetched = useCallback(async (request?: { pageIndex?: number, }): Promise<void> => {
        console.log(await GetAllActorPaging({ PageIndex: request?.pageIndex || 0, PageSize: 5, Nationality: country, SortBy: sort }), "paging")
    }, [GetAllActorPaging, country, sort])

    // hàm onPageChange của Pagination senmatic ui
    const onPageChange = (event: React.MouseEvent<HTMLAnchorElement, MouseEvent>, data: PaginationProps) => {
        console.log(data, "data paging")
        ensureDataFetched({ pageIndex: data.activePage as number - 1 });
        refToTop.current?.scrollIntoView({
            behavior: 'smooth'
        });
    }


    // gọi hàm ensureDataFetched
    useEffect(() => {
        ensureDataFetched();

    }, [ensureDataFetched]);




    return (
        <Container>
            <Grid>
                <Grid.Column width={10}>
                    <div style={{ "display": "flex", gap: "10px" }}>
                        <SelectCountry onSelectCountry={onChangeCountry}></SelectCountry>
                        <SelectSort onSelectSort={onChangeSort} sort={sort}></SelectSort>
                        {/* <Select placeholder='Sắp xếp theo' options={countryOptions} /> */}
                    </div>
                    <Header as='h2' icon='hand point right' content='Diễn viên' />
                    <Item.Group>

                        {/* {status !== "f" && <Segment className=''>
                            <Loader active />
                        </Segment>} */}

                        <div id='scrollToTop' ref={refToTop}></div>
                        {result && result.map((actor, idx) => { 
                            return <Item key={idx} className="hover:shadow-lg bg-gray-700 rounded" >
                                <Item.Image size='small' src={actor.image} />

                                <Item.Content className='p-3'>
                                    <Item.Header className='text-blue-500' as={Link} to={`/actor/${actor.id}`}>{actor.name}</Item.Header>
                                    <Item.Description className='text-white'>
                                        <p ><Label as='a' content={actor.viewCount} icon='eye' /></p>
                                        <p>
                                            Ngày sinh: {moment(actor.dateOfBirth).format("DD/MM/YYYY")}
                                        </p>
                                        <p>
                                            Chiều cao: {actor.height}
                                        </p>
                                        <p>
                                            Quốc tịch: {actor.nationality}
                                        </p>
                                    </Item.Description>
                                </Item.Content>
                            </Item>
                        })}


                    </Item.Group>
                    <div className=''>
                        <Pagination
                            defaultActivePage={1}
                            firstItem={null}
                            lastItem={null}
                            pointing
                            secondary
                            boundaryRange={1}
                            totalPages={total}
                            onPageChange={onPageChange}
                        />
                    </div>
                </Grid.Column>

                <Grid.Column width={6}>
                    <TicketPurchaseForm></TicketPurchaseForm>
                    <MovieSlideBar></MovieSlideBar>
                </Grid.Column>
            </Grid>

        </Container>
    )
}

const mapDispatchToProps = (dispatch: any) => ({
    GetAllActorPaging: (request: ActorPagingRequest) => dispatch(GetAllActorPagingAsync(request))
})

export default connect(
    (state: RootState) => state.actor,
    mapDispatchToProps
)(ActorList);