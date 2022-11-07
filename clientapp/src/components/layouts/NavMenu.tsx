import * as React from 'react';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import { Container, Dropdown, Input, Menu, MenuItemProps, Image, Sidebar, Icon, Header } from 'semantic-ui-react';
import Login from '../../features/user/Login';

interface IProps {
    children: React.ReactNode,
    onPusherClick: () => void,
    onToggle: () => void,
    handleItemClick: (e: React.MouseEvent<HTMLAnchorElement, MouseEvent>, data: MenuItemProps) => void,
    activeItem: string,
    visible: boolean
}

const NavBarMobile = (props: IProps) => {
    const {
        children,
        onPusherClick,
        onToggle,
        handleItemClick,
        activeItem,
        visible
    } = props;

    return (
        <Sidebar.Pushable>
            <Sidebar
                as={Menu}
                animation="overlay"
                icon="labeled"
                inverted
                vertical
                visible={visible}
                size='tiny'
            >
                <Menu.Item >
                    <Input
                        placeholder='Tìm phim hoặc diễn viên ...'
                    />
                </Menu.Item>
                <Menu.Menu >
                    <Menu.Item

                        content="Mua vé"
                        name='sell_ticket'
                        active={activeItem === 'sell_ticket'}
                        onClick={handleItemClick}
                        as={Link}
                        to={"/"}
                    />

                    <Dropdown item text='Phim' pointing='left'>
                        <Dropdown.Menu>
                            <Dropdown.Item as={Link} to={"/movie"}>Phim đang chiếu</Dropdown.Item>
                            <Dropdown.Item>Automotive</Dropdown.Item>
                            <Dropdown.Item>Home</Dropdown.Item>
                        </Dropdown.Menu>
                    </Dropdown>
                    <Dropdown item text='Góc điện ảnh' pointing='left'>
                        <Dropdown.Menu>
                            <Dropdown.Item as={Link} to={"/counter"}>Counter</Dropdown.Item>
                            <Dropdown.Item as={Link} to={"/fetch-data"}>Automotive</Dropdown.Item>
                            <Dropdown.Item>Home</Dropdown.Item>
                        </Dropdown.Menu>
                    </Dropdown>
                    <Menu.Item
                        content="Rạp/Giá vé"
                        name='cinema_ ticket_price'
                        active={activeItem === 'cinema_ ticket_price'}
                        onClick={handleItemClick}
                        as={Link}
                        to={"/"}
                    />
                    <Menu.Item
                        content="Hỗ trợ"
                        name='support'
                        active={activeItem === 'support'}
                        onClick={handleItemClick}
                        as={Link}
                        to={"/"}
                    />
                    <Menu.Item
                        content="Thành viên"
                        name='members'
                        active={activeItem === 'members'}
                        onClick={handleItemClick}
                        as={Link}
                        to={"/"}
                    />
                </Menu.Menu>



            </Sidebar>



            <Sidebar.Pusher
                dimmed={visible}
                onClick={onPusherClick}
                style={{ minHeight: "100vh" }}
            >

                <Menu fixed="top" inverted>
                    <Menu.Item>
                        <Image size="mini" src="https://react.semantic-ui.com/logo.png" />
                    </Menu.Item>
                    <Menu.Item onClick={onToggle}>
                        <Icon name="sidebar" />
                    </Menu.Item>

                    <Menu.Menu position="right">

                        <Menu.Item
                            content="Đăng xuất"
                            name='logout'
                            active={activeItem === 'logout'}
                            onClick={handleItemClick}
                        />
                    </Menu.Menu>
                </Menu>

                {children}
            </Sidebar.Pusher>
        </Sidebar.Pushable>
    );
};

const NavBarDesktop = (props: {
    handleItemClick: (e: React.MouseEvent<HTMLAnchorElement, MouseEvent>, data: MenuItemProps) => void,
    activeItem: string,
}) => {
    const {
        handleItemClick,
        activeItem,
    } = props;

    return (
        <>
           
            {/* <Container className="flex justify-center items-center py-2">
                <div className="flex">
                    <Image size="large" circular src='https://www.galaxycine.vn/website/images/galaxy-logo.png' /> 
                </div>
                <div className="pl-5" >
                    <Input
                        size="mini"
                        action={{ type: 'submit', content: 'Tìm' }}
                        placeholder='Tìm phim hoặc diễn viên ...'
                    />
                </div>
            </Container> */}
            <Menu className='z-10 bg-transparent'>
                <Menu.Item>
                    <Image size="mini" src="https://react.semantic-ui.com/logo.png" />
                </Menu.Item>

                <Menu.Item
                    content="Mua vé"
                    name='sell_ticket'
                    active={activeItem === 'sell_ticket'}
                    onClick={handleItemClick}
                    as={Link}
                    to={"/"}
                />

                <Dropdown item text='Phim'>
                    <Dropdown.Menu>
                        <Dropdown.Item as={Link} to="/movie">Phim đang chiếu</Dropdown.Item>
                        <Dropdown.Item>Automotive</Dropdown.Item>
                        <Dropdown.Item>Home</Dropdown.Item>
                    </Dropdown.Menu>
                </Dropdown>
                <Dropdown item text='Góc điện ảnh'>
                    <Dropdown.Menu>
                        <Dropdown.Item as={Link} to={"/actor"}>Diễn viên</Dropdown.Item>
                        <Dropdown.Item as={Link} to={"/fetch-data"}>Đạo diễn</Dropdown.Item>
                        <Dropdown.Item>Home</Dropdown.Item>
                    </Dropdown.Menu>
                </Dropdown>
                <Menu.Item
                    content="Rạp/Giá vé"
                    name='cinema_ ticket_price'
                    active={activeItem === 'cinema_ ticket_price'}
                    onClick={handleItemClick}
                    as={Link}
                    to={"/"}
                />
                <Menu.Item
                    content="Hỗ trợ"
                    name='support'
                    active={activeItem === 'support'}
                    onClick={handleItemClick}
                    as={Link}
                    to={"/"}
                />
                <Menu.Item
                    content="Thành viên"
                    name='members'
                    active={activeItem === 'members'}
                    onClick={handleItemClick}
                    as={Link}
                    to={"/"}
                />

                <Menu.Menu position="right">
                <Menu.Item>
                <Icon size='large' name='search' />
                </Menu.Item>
                    <Menu.Item
                        name='logout'
                        active={activeItem === 'logout'}
                        onClick={handleItemClick}
                    >
                        <Login ></Login>
                    </Menu.Item>
                </Menu.Menu>
            </Menu>
            
        </>
    );
};


const NavBarChildren = (props: { children: React.ReactNode }) => (
    <Container fluid style={{ marginTop: "5em", paddingLeft: "2rem", paddingRight: "2rem" }}>{props.children}</Container>
);

export default class NavMenu extends React.PureComponent<{ Media: any, children: any }, { activeItem: string, visible: boolean }> {

    constructor(props: { Media: any, children: any }) {
        super(props)
    }
    public state = { activeItem: 'home', visible: false };

    private handlePusher = () => {
        const { visible } = this.state;

        if (visible) this.setState(pre => ({ ...pre, visible: false }));
    };

    private handleToggle = () => this.setState(pre => ({ ...pre, visible: !this.state.visible }));

    private handleItemClick = (e: React.MouseEvent<HTMLAnchorElement, MouseEvent>, data: MenuItemProps): void => this.setState({ activeItem: data.name! })
    public render() {
        const { activeItem, visible } = this.state
        const { Media, children } = this.props
        return (
            <header className='relative'>

                <Media at="mobile">
                    <NavBarMobile
                        onPusherClick={this.handlePusher}
                        onToggle={this.handleToggle}
                        visible={visible}
                        handleItemClick={this.handleItemClick}
                        activeItem={activeItem}>
                        <NavBarChildren>{children}</NavBarChildren>
                    </NavBarMobile>
                </Media>

                <Media greaterThan="mobile">
                    <NavBarDesktop
                        handleItemClick={this.handleItemClick}
                        activeItem={activeItem} />
                    <NavBarChildren>{children}</NavBarChildren>
                </Media>
            </header>
        );

    }
}
