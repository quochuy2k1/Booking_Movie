import * as React from 'react';
import { DataGrid, GridColDef, GridToolbar, useGridApiContext, useGridSelector, gridPageSelector, gridPageCountSelector, GridSelectionModel, GridRowParams, GridValueGetterParams } from '@mui/x-data-grid';
import MainCard from '../../../../ui-component/cards/MainCard';
import { locateText } from '../../../../utils/locateTextDataGrid';
import { emptyMovieError, GetAllMoviePagingAsync } from '../../../../../slices/movie/movieSlice';
import { useAppDispatch, useAppSelector } from '../../../../../app/hooks';
import { Alert, Avatar, Collapse, IconButton, LinearProgress, Paper, TablePagination, Checkbox } from '@mui/material';
import { DropdownProps, Label } from 'semantic-ui-react';
import DropdownComponent from '../../../../ui-component/common/Dropdown/DropdownComponent';
import moment from 'moment';
import AddNewActor from './addNewScreening';
import DeleteMuilActor from './deleteMuilScreening';
import {  Close } from '@mui/icons-material';
import UpdateMovie from './updateScreening';
import { GetCategoriesAsync } from '../../../../../slices/categories/categorySlice';
import { GetAllActorAsync, GetAllActorPagingAsync } from '../../../../../slices/actor/actorSlice';
import { GetDirectorAsync } from '../../../../../slices/directors/directorSlice';
import { GetNationalitiesAsync } from '../../../../../slices/nationalities/nationalitySlice';
import { GetProducerAsync } from '../../../../../slices/producers/producerSlice';
import { GetAllScreeningAsync } from '../../../../../slices/screenings/ScreeningSlice';

const columns: GridColDef[] = [
	{ field: 'id', headerName: 'ID', width: 45  },
	{ field: 'movieName', headerName: 'Tên phim', flex: 1  },
	{ field: 'cinemaName', headerName: 'Tên rạp chiếu phim',width: 150 },
	{ field: 'auditoriumName', headerName: 'Tên phòng chiếu', width: 120 },
	
	{
		field: 'screeningTypeName',
		headerName: 'Loại lịch chiếu',
		type: 'string',
		width: 120,

	},
	{
		field: 'showTime',
		headerName: 'Thời gian chiếu',
		type: 'dateTime',
		flex: 1,
		renderCell: (params) => params.value.map((showTime: string, idx: number) => (
			<Label key={idx} color="olive" size="small">
        {moment(showTime).format("hh:mm")},
		
      </Label>
		)),
		
	},
	
	
	
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

function CustomCheckbox(props: any){
	return (
		<>
			<Checkbox
			sx={{
				color: "#fafafa",
				'&.Mui-checked': {
				  color: "#fafafa",
				},
			}}
				// icon={<CheckCircle />}
				// checkedIcon={<RadioButtonUnchecked />}
				{...props}
			/>
		</>
	)
}

const ScreeningManagement: React.FC = () => {
	const dispatch = useAppDispatch();
	const { status, screenings, total, error } = useAppSelector(state => state.screening);
	const [pageSize, setPageSize] = React.useState<number>(1);
	const [pageIndex, setPageIndex] = React.useState<number>(0);
	const [nationality, setNationality] = React.useState<string>("all");
	const [openError, setOpenError] = React.useState<boolean>(false);
	const [rowCountState, setRowCountState] = React.useState<number>(total || 0);

	const [rowSelect, setRowSelect] = React.useState<number[]>([] as number[]);
	const [rowItems, setRowItems] = React.useState<{ [k: string]: any }>();

	const [openUpdate, setOpenUpdate] = React.useState<boolean>(false);





	React.useEffect(() => {
		if (screenings.length <= 0) {
			dispatch(GetAllScreeningAsync());
		}

		setRowCountState((prevRowCountState) =>
			total !== undefined ? total : prevRowCountState,
		);
		if (error) {
			setOpenError(true);
		}

		// dispatch(GetCategoriesAsync());
        // dispatch(GetNationalitiesAsync());
        // dispatch(GetProducerAsync());
        // dispatch(GetDirectorAsync());
        // dispatch(GetAllActorAsync());
	}, [dispatch, total, setRowCountState, error, setOpenError, screenings.length]);


	const handlePageChange = React.useMemo(() => (page: number) => {
		console.log(page, "page index")
		dispatch(GetAllActorPagingAsync({ PageIndex: page, PageSize: pageSize, Nationality: nationality }));

	}, [dispatch, pageSize]);

	const CloseUpdate = (open: boolean) => {
		setOpenUpdate(open);
	}
	const handleRowClick = (params: GridRowParams<any>) => {
		setOpenUpdate(true);
		setRowItems(params.row)
	}


	const onRowSelectChange = (selection: GridSelectionModel, detail: any) => {
		setRowSelect(selection as number[]);
		console.log(selection, detail, "seletion data grid")

	}

	const FilterByCountries = (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => {
		setNationality(data.value as string)
		console.log(data.value, "data dropdown")
		// dispatch(GetAllActorPagingAsync({ PageIndex: pageIndex, PageSize: pageSize, Nationality: data.value as string }));
	}
	return (
		<MainCard title="Quản lý lịch chiếu phim">
			<div>
				<Collapse in={openError} >
					<Alert
						variant='filled'
						severity='error'
						action={
							<IconButton
								aria-label="close"
								color="inherit"
								size="small"
								onClick={() => {
									setOpenError(false);
									dispatch(emptyMovieError());
								}}
							>
								<Close fontSize="inherit" />
							</IconButton>
						}
						sx={{ mb: 2 }}
					>
						{error}
					</Alert>
				</Collapse>

			</div>
			<div className='py-2'>

				<AddNewActor />
				{openUpdate && <UpdateMovie {...rowItems} setOpenUpdateMovie={CloseUpdate} isOpen={openUpdate} />}
				<DeleteMuilActor id={rowSelect}  />



			</div>
			<Paper elevation={1} square className='p-5 my-1'>
				<div className='flex'>
					<span className='font-semibold'>
						Rạp chiếu phim{' '}
						<DropdownComponent inline dataOption={countryOptions} onSelectChange={FilterByCountries} />
					</span>
				</div>

			</Paper>
			<div style={{ height: 400, width: '100%' }}>


				<DataGrid
					 sx={{
						'.MuiDataGrid-columnHeader': {
						  backgroundColor: "#333",
						  color: "#fff"
						},
					  }}
					loading={status === "loading" ? true : false}
					rows={screenings}
					columns={columns}
					pageSize={pageSize}
					rowsPerPageOptions={[1, 3, 5, 10, 20, 50, 100]}
					// onPageSizeChange={(newPageSize) => { setPageSize(newPageSize); dispatch(GetAllActorPagingAsync({ PageIndex: pageIndex, PageSize: newPageSize, Nationality: nationality })); }}
					onPageSizeChange={(newPageSize) => { setPageSize(newPageSize); }}
					pagination
					paginationMode="server"
					checkboxSelection
					onPageChange={handlePageChange}
					rowCount={rowCountState}
					onSelectionModelChange={onRowSelectChange}
					// components={{ Toolbar: GridToolbar, Pagination: CustomPagination, LoadingOverlay: LinearProgress, }}
					components={{ BaseCheckbox: CustomCheckbox, Toolbar: GridToolbar, LoadingOverlay: LinearProgress, }}
					localeText={locateText}
					getCellClassName={(params) => { 
						if (params.field === 'id' || params.field === 'cinemaName' || params.field === 'movieName' || params.field === 'auditoriumName' ||  params.field === 'screeningTypeName' || params.field === 'showTime' || params.value == null) {
							return '';
						  }
						
						return "bg-blue-400"
					}}
					onRowClick={handleRowClick}
					
				/>


			</div>



		</MainCard>
	);
}

export default ScreeningManagement;