import * as React from 'react';
import { DataGrid, GridColDef, GridToolbar, useGridApiContext, useGridSelector, gridPageSelector, gridPageCountSelector } from '@mui/x-data-grid';
import MainCard from '../../../../ui-component/cards/MainCard';
import { locateText } from '../../../../utils/locateTextDataGrid';
import { GetAllMoviePagingAsync } from '../../../../../slices/movie/movieSlice';
import { useAppDispatch, useAppSelector } from '../../../../../app/hooks';
import { Avatar, Container, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, LinearProgress, Paper, TablePagination, useMediaQuery, useTheme } from '@mui/material';
import { Button, DropdownProps, Form, Icon, Input } from 'semantic-ui-react';
import DropdownComponent from '../../../../ui-component/common/Dropdown/DropdownComponent';
import moment from 'moment';
import { Editor } from '@tinymce/tinymce-react';
import AddNewMovie from './addNewMovie';

const columns: GridColDef[] = [
	{ field: 'id', headerName: 'ID', width: 40 },
	{ field: 'imageBackground', headerName: 'Hình', width: 70, renderCell: (params) => <Avatar src={params.value} variant="rounded" />, },
	{ field: 'name', headerName: 'Tên phim', width: 130 },
	{ field: 'duration', headerName: 'Thời lượng phim', width: 120 },
	{
		field: 'releaseDate',
		headerName: 'Ngày công chiếu',
		type: 'dateTime',
		width: 120,
		renderCell: (params) => moment(params.value).format("DD/MM/yyyy"),
	},
	{
		field: 'nationality',
		headerName: 'Quốc gia',
		type: 'string',
		width: 90,
	},
	{
		field: 'categories',
		headerName: 'Danh mục phim',
		type: 'string',
		width: 120,
	},
	{
		field: 'actors',
		headerName: 'Diễn viên',
		type: 'string',
		width: 130,
	},
	{
		field: 'directors',
		headerName: 'Đạo diễn',
		type: 'string',
		width: 120,
	},
	{
		field: 'producer',
		headerName: 'Nhà sản xuất',
		type: 'string',
		width: 120,
	},
	// {
	//   field: 'fullName',
	//   headerName: 'Full name',
	//   description: 'This column has a value getter and is not sortable.',
	//   sortable: false,
	//   width: 160,
	//   valueGetter: (params: GridValueGetterParams) =>
	//     `${params.row.firstName || ''} ${params.row.lastName || ''}`,
	// },
];

const countryOptions = [
	{ key: 'all', value: "all", text: 'Tất cả', },
	{ key: 'en', value: 'en', text: 'Mỹ', flag: "us" },
	{ key: 'au', value: 'au', text: 'Úc', flag: "au" },
	{ key: 'zh', value: 'zh', text: 'Trung Quốc', flag: "cn" },
	{ key: 'ko', value: 'ko', text: 'Hàn Quốc', flag: "kr" },
	{ key: 'vi', value: 'vi', text: 'Việt Nam', flag: "vn" },
]


function CustomPagination() {
	const apiRef = useGridApiContext();
	const page = useGridSelector(apiRef, gridPageSelector);
	const pageCount = useGridSelector(apiRef, gridPageCountSelector);
	const [rowsPerPage, setRowsPerPage] = React.useState<number>(1);

	const handleChangeRowsPerPage = (
		event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
	) => {
		setRowsPerPage(parseInt(event.target.value, 1));
	};

	React.useEffect(() => {
		console.log(pageCount, "pageCount")
	}, [pageCount]);
	return (

		<TablePagination
			component={"div"}
			// color="red"
			count={pageCount}
			page={page <= 0 ? 0 : page + 1}
			rowsPerPage={rowsPerPage}
			rowsPerPageOptions={[1, 5, 10, 20, 50, 100]}
			labelRowsPerPage="Dòng mỗi trang"
			labelDisplayedRows={(option) => `${option.to} đến ${option.from} của ${option.count}`}
			onPageChange={(event, value) => apiRef.current.setPage(value - 1)}
			onRowsPerPageChange={handleChangeRowsPerPage}
			onChange={() => console.log("clicked next")}
		/>

	);
}


const ActorManagement: React.FC = () => {
	const dispatch = useAppDispatch();
	const { status, movies, total } = useAppSelector(state => state.movie);
	const [pageSize, setPageSize] = React.useState<number>(1);
	const [pageIndex, setPageIndex] = React.useState<number>(0);
	const [nationality, setNationality] = React.useState<string>("all");
	const [rowCountState, setRowCountState] = React.useState(total || 0);

	
	

	React.useEffect(() => {
		if (movies.length <= 0) {
			dispatch(GetAllMoviePagingAsync({ PageIndex: pageIndex, PageSize: pageSize }));
		}

		setRowCountState((prevRowCountState) =>
			total !== undefined ? total : prevRowCountState,
		);
		console.log(rowCountState, "      ", total, "rowCountState")
	}, [dispatch, total, setRowCountState]);

	const [openDel, setOpenDel] = React.useState(false);

	
	const handleClickDelOpen = () => {
		setOpenDel(true);
	};

	const handleDelClose = () => {
		setOpenDel(false);
	};

	const handlePageChange = React.useMemo(() => (page: number) => {
		console.log(page, "page index")
		dispatch(GetAllMoviePagingAsync({ PageIndex: page, PageSize: pageSize, Nationality: nationality }));

	}, [dispatch, pageSize]);

	const FilterByCountries = (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => {
		setNationality(data.value as string)
		console.log(data.value, "data dropdown")
		dispatch(GetAllMoviePagingAsync({ PageIndex: pageIndex, PageSize: pageSize, Nationality: data.value as string }));
	}
	return (
		<MainCard title="Quản lý Phim">
			<div className='py-2'>
				
				<AddNewMovie/>
				<Button icon color='red' onClick={handleClickDelOpen} labelPosition='right'>
					<Icon name='delete' /> Xoá nhiều
				</Button>

				<Dialog
					open={openDel}
					onClose={handleDelClose}
					aria-labelledby="alert-dialog-title"
					aria-describedby="alert-dialog-description"
				>
					<DialogTitle id="alert-dialog-title" className='text-xl font-bold'>
						{"Bạn có thực sự muốn xoá?"}
					</DialogTitle>
					<DialogContent>
						<DialogContentText id="alert-dialog-description" className='text-lg'>
							Hàng bạn muốn xoá là
						</DialogContentText>
					</DialogContent>
					<DialogActions>
						<Button color='red' onClick={handleDelClose}>Huỷ bỏ xoá</Button>
						<Button color='blue' onClick={handleDelClose} autoFocus>
							Xác nhận xoá
						</Button>
					</DialogActions>
				</Dialog>

				

			</div>
			<Paper elevation={1} square className='p-5 my-1'>
				<div className='flex'>
					<span className='font-semibold'>
						Quốc gia{' '}
						<DropdownComponent inline dataOption={countryOptions} onSelectChange={FilterByCountries} />
					</span>
				</div>

			</Paper>
			<div style={{ height: 400, width: '100%' }}>


				<DataGrid

					loading={status === "loading" ? true : false}
					rows={movies}
					columns={columns}
					pageSize={pageSize}
					rowsPerPageOptions={[1, 3, 5, 10, 20, 50, 100]}
					onPageSizeChange={(newPageSize) => { setPageSize(newPageSize); dispatch(GetAllMoviePagingAsync({ PageIndex: pageIndex, PageSize: newPageSize, Nationality: nationality })); }}
					pagination
					paginationMode="server"
					checkboxSelection
					onPageChange={handlePageChange}
					rowCount={rowCountState}
					// components={{ Toolbar: GridToolbar, Pagination: CustomPagination, LoadingOverlay: LinearProgress, }}
					components={{ Toolbar: GridToolbar, LoadingOverlay: LinearProgress, }}
					localeText={locateText}
				/>


			</div>

		</MainCard>
	);
}

export default ActorManagement;