import * as React from 'react';
// import { DataGrid, GridColDef, GridToolbar, useGridApiContext, useGridSelector, gridPageSelector, gridPageCountSelector, GridSelectionModel, GridRowParams, GridValueGetterParams, GridValueFormatterParams } from '@mui/x-data-grid';
import MainCard from '../../../../ui-component/cards/MainCard';
import { locateText } from '../../../../utils/locateTextDataGrid';
import { emptyMovieError } from '../../../../../slices/movie/movieSlice';
import { useAppDispatch, useAppSelector } from '../../../../../app/hooks';
import { Alert, Collapse, IconButton, LinearProgress, Paper, TablePagination, Checkbox, Typography } from '@mui/material';
import { DropdownProps, Label } from 'semantic-ui-react';
import DropdownComponent from '../../../../ui-component/common/Dropdown/DropdownComponent';
import moment from 'moment';
import { Close } from '@mui/icons-material';
import { BookingModel } from '../../../../../slices/bookings/BookingSlice';
import { Box, DataGrid, NumberBox, Switch, Toast } from 'devextreme-react';
import CustomStore from 'devextreme/data/custom_store';
import { ToastType } from 'devextreme/ui/toast';
import { Selection, Column, ColumnFixing, Editing, FilterBuilderPopup, FilterPanel, FilterRow, GroupPanel, Grouping, HeaderFilter, Pager, Paging, RemoteOperations, SearchPanel, LoadPanel, ColumnChooser, Summary, TotalItem } from 'devextreme-react/data-grid';
import themes from 'devextreme/ui/themes';
import { createStore } from 'devextreme-aspnet-data-nojquery';
import { STATUS_MESSAGE, STATUS_RESPONSE } from '../../../../../common/status-message';
import DropdownWithDataGrid, { IDataGirdColumn } from '../../../../ui-component/common/Dropdown/DropdownWithDataGrid';

const url = `${import.meta.env.VITE_REACT_APP_API_BASE!}`

// const columns: GridColDef[] = [
// 	{ field: 'id', headerName: 'ID', width: 45  },
// 	{ field: 'userFullName', headerName: 'Tên người đặt vé', flex: 1  },
// 	{ field: 'paymentMethod', headerName: 'Phương thức thanh toán',width: 150 },
// 	{ field: 'couponId', headerName: 'Mã giảm giá', width: 120 },

// 	{
// 		field: 'createdDate',
// 		headerName: 'Ngày tạo',
// 		type: 'date',
// 		flex: 1,
// 		// renderCell: (params) => moment(params.value).format("DD/MM/yyyy"),
// 		valueFormatter: (params: GridValueFormatterParams) => {
// 			// first converts to JS Date, then to locale option through date-fns

// 			return moment(params.value).format("DD/MM/yyyy");
// 		  },
// 		// valueGetter: (params: GridValueGetterParams) => {
// 		// 	return moment(params.value).format("DD/MM/yyyy");
// 		//   }
// 		// ,
// 	},
// 	{ field: 'total', headerName: 'Số tiền thanh toán', flex: 1, renderCell: (params) =>params.value.toLocaleString('it-IT', {style : 'currency', currency : 'vnd'})  },
// 	{
// 		field: 'showTime',
// 		headerName: 'Lịch chiếu',
// 		type: 'dateTime',
// 		flex: 1,
// 		// renderCell: (params) => moment(params.value).format("hh:mm"),
// 		valueFormatter: (params: GridValueFormatterParams) => {
// 			// first converts to JS Date, then to locale option through date-fns
// 			console.log(params, "params")
// 			return moment(params.value).format("hh:mm");
// 		  }
// 		,
// 		// valueGetter: (params: GridValueGetterParams) => {
// 		// 	console.log(params, "params")
// 		// 	return params.value;
// 		//   }
// 		// ,
// 	},
// 	{
// 		field: 'tickets',
// 		headerName: 'Đặt loại vé',
// 		type: 'string',
// 		flex: 1,
// 		renderCell: (params) =>params.value.join(", ")
// 		,
// 	},
// 	{
// 		field: 'combos',
// 		headerName: 'Đặt combo',
// 		type: 'string',
// 		flex: 1,
// 		renderCell: (params) => {
// 			if(params.value.length <= 0) return "không đặt"
// 			return params.value.join(", ")
// 		}
// 		,
// 	},
// 	{
// 		field: 'seatRevered',
// 		headerName: 'Đặt ghế',
// 		type: 'string',
// 		flex: 1,
// 		renderCell: (params) =>params.value.join(", ")
// 		,
// 	},

// ];

const countryOptions = [
	{ key: 'all', value: "all", text: 'Tất cả', },
	{ key: 'en', value: 'en', text: 'Mỹ', flag: "us" },
	{ key: 'au', value: 'au', text: 'Úc', flag: "au" },
	{ key: 'zh', value: 'zh', text: 'Trung Quốc', flag: "cn" },
	{ key: 'ko', value: 'ko', text: 'Hàn Quốc', flag: "kr" },
	{ key: 'vi', value: 'vi', text: 'Việt Nam', flag: "vn" },
]

// function CustomPagination() {
// 	const apiRef = useGridApiContext();
// 	const page = useGridSelector(apiRef, gridPageSelector);
// 	const pageCount = useGridSelector(apiRef, gridPageCountSelector);
// 	const [rowsPerPage, setRowsPerPage] = React.useState<number>(1);

// 	const handleChangeRowsPerPage = (
// 		event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
// 	) => {
// 		setRowsPerPage(parseInt(event.target.value, 1));
// 	};

// 	React.useEffect(() => {
// 		console.log(pageCount, "pageCount")
// 	}, [pageCount]);
// 	return (

// 		<TablePagination
// 			component={"div"}
// 			// color="red"
// 			count={pageCount}
// 			page={page <= 0 ? 0 : page + 1}
// 			rowsPerPage={rowsPerPage}
// 			rowsPerPageOptions={[1, 5, 10, 20, 50, 100]}
// 			labelRowsPerPage="Dòng mỗi trang"
// 			labelDisplayedRows={(option) => `${option.to} đến ${option.from} của ${option.count}`}
// 			onPageChange={(event, value) => apiRef.current.setPage(value - 1)}
// 			onRowsPerPageChange={handleChangeRowsPerPage}
// 			onChange={() => console.log("clicked next")}
// 		/>

// 	);
// }

// function CustomCheckbox(props: any){
// 	return (
// 		<>
// 			<Checkbox
// 			sx={{
// 				color: "#fafafa",
// 				'&.Mui-checked': {
// 				  color: "#fafafa",
// 				},
// 			}}
// 				// icon={<CheckCircle />}
// 				// checkedIcon={<RadioButtonUnchecked />}
// 				{...props}
// 			/>
// 		</>
// 	)
// }
interface IFilter {
	movieId?: string | null,
	cinemaId?: string | null,
	auditoriumId?: string | null,
}

const defaultFilter: IFilter = {
	movieId: null,
	cinemaId: null,
	auditoriumId: null,
}
interface IToast {
	visible?: boolean;
	message?: string;
	type: ToastType;
}

const defaultToast: IToast = {
	visible: false,
	message: "",
	type: 'success',
}


//#region movieColumns

const movieColumns: IDataGirdColumn[] = [
	{
		column_name: "imagePreview",
		data_type: "string",
		default_hiden: undefined,
		format_type: undefined,
		name_vn: "Hình bộ phim",
		type: "image",
		allowFilter: false,
		number_order: 0

	},
	{
		column_name: "name",
		data_type: "string",
		default_hiden: undefined,
		format_type: undefined,
		name_vn: "Tên bộ phim",
		allowFilter: true,
		number_order: 5

	},
]
const cinemaColumns: IDataGirdColumn[] = [
	{
		column_name: "name",
		data_type: "string",
		default_hiden: undefined,
		format_type: undefined,
		name_vn: "Tên rạp chiếu phim",
		allowFilter: true,
		number_order: 0

	},
	{
		column_name: "address",
		data_type: "string",
		default_hiden: undefined,
		format_type: undefined,
		name_vn: "Địa chỉ",
		allowFilter: true,
		number_order: 5

	},
]
//#endregion

const pageSizes = [8, 12, 20];

const BookingManagement: React.FC = () => {
	const dispatch = useAppDispatch();
	// const { status, bookings, total, error } = useAppSelector(state => state.booking);
	const [pageSize, setPageSize] = React.useState<number>(1);
	const [pageIndex, setPageIndex] = React.useState<number>(0);
	const [nationality, setNationality] = React.useState<string>("all");
	const [openError, setOpenError] = React.useState<boolean>(false);
	// const [rowCountState, setRowCountState] = React.useState<number>(total || 0);
	const [rowCountState, setRowCountState] = React.useState<number>(0);

	const [rowSelect, setRowSelect] = React.useState<number[]>([] as number[]);
	const [rowItems, setRowItems] = React.useState<{ [k: string]: any }>();

	const [openUpdate, setOpenUpdate] = React.useState<boolean>(false);


	// 
	const dataGridRef = React.useRef<DataGrid>(null);
	const [dataSource, setDataSource] = React.useState<CustomStore<BookingModel, string>>();

	// 
	const [isHiddenGroup, setIsHiddenGroup] = React.useState<boolean>(false);
	const [isHiddenSearch, setIsHiddenSearch] = React.useState<boolean>(false);
	const [isHiddenFilter, setIsHiddenFilter] = React.useState<boolean>(false);
	const [isHiddenAdvantageFilter, setIsHiddenAdvantageFilter] = React.useState<boolean>(false);
	const [isHiddenColumnChooser, setIsHiddenColumnChooser] = React.useState<boolean>(false);

	// 

	const [allMode] = React.useState<string>('allPages');
	const [checkBoxesMode] = React.useState<string>(themes.current().startsWith('material') ? 'always' : 'onClick');

	// 
	const filterBuilderPopupPosition = {
		of: window,
		at: 'top',
		my: 'top',
		offset: { y: 10 },
	};
	//

	// 

	const [filter, setFilter] = React.useState<IFilter>(defaultFilter);
	// Toast

	const [toast, setToast] = React.useState<IToast>(defaultToast);

	//  

	const handleChangeFilterInput = (e: any) => {
		const { name, value } = e.target;

		setFilter(pre => ({ ...filter, [name]: value } as IFilter));
	};
	React.useEffect(() => {
		const data = createStore({
			key: 'id',
			loadMethod: "POST",
			loadUrl: `${url}/api/Bookings/get-all-booking-admin-paging`,
			loadParams: {
				...filter
			},
			// insertUrl: `${url}/api/Screenings/add-new`,

			// updateUrl: `${url}/api/Screenings/update`,
			// deleteUrl: `${url}/DeleteOrder`,
			onBeforeSend: (method, ajaxOptions) => {
				ajaxOptions.xhrFields = { withCredentials: true };
			},
			errorHandler(e) {
				// console.log(e., "error")


				setToast({
					visible: true,
					type: STATUS_RESPONSE[0] as ToastType,
					message: STATUS_MESSAGE[e.message]

				});

			},
		});

		setDataSource(data);

	}, [filter])

	// 
	// React.useEffect(() => {
	// 	if (bookings.length <= 0) {
	// 		dispatch(GetAllBookingPagingAsync());
	// 	}

	// 	setRowCountState((prevRowCountState) =>
	// 		total !== undefined ? total : prevRowCountState,
	// 	);
	// 	if (error) {
	// 		setOpenError(true);
	// 	}

	// 	// dispatch(GetCategoriesAsync());
	// 	// dispatch(GetNationalitiesAsync());
	// 	// dispatch(GetProducerAsync());
	// 	// dispatch(GetDirectorAsync());
	// 	// dispatch(GetAllActorAsync());
	// 	// [dispatch, total, setRowCountState, error, setOpenError, screenings.length]
	// }, [dispatch, total, setRowCountState, error, setOpenError, bookings.length]);


	// const handlePageChange = React.useMemo(() => (page: number) => {
	// 	console.log(page, "page index")
	// 	// dispatch(GetAllActorPagingAsync({ PageIndex: page, PageSize: pageSize, Nationality: nationality }));

	// }, [dispatch, pageSize]);

	// const CloseUpdate = (open: boolean) => {
	// 	setOpenUpdate(open);
	// }
	// const handleRowClick = (params: GridRowParams<any>) => {
	// 	setOpenUpdate(true);
	// 	setRowItems(params.row)
	// }


	// const onRowSelectChange = (selection: GridSelectionModel, detail: any) => {
	// 	setRowSelect(selection as number[]);
	// 	console.log(selection, detail, "seletion data grid")

	// }

	const FilterByCountries = (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => {
		setNationality(data.value as string)
		console.log(data.value, "data dropdown")
		// dispatch(GetAllActorPagingAsync({ PageIndex: pageIndex, PageSize: pageSize, Nationality: data.value as string }));
	}

	const handleContextMenuItems = (items: any) => {
		if (!items) {
			return;
		}

		items.forEach((item: any) => {
			if (item.items) {
				// Xử lý mục menu lồng nhau
				handleContextMenuItems(item.items);
			}

			switch (item.text) {
				case "Sort Ascending":
					item.text = 'Sắp xếp tăng dần';
					break;
				case "Sort Descending":
					item.text = 'Sắp xếp giảm dần';
					break;
				case "Clear Sorting":
					item.text = 'Hủy sắp xếp';
					break;
				case "Group by This Column":
					item.text = 'Group cột này';
					break;
				case "Ungroup All":
					item.text = 'Hủy bỏ group tất cả';
					break;
				case "Fix":
					item.text = 'Cố định';
					break;
				case "To the left":
					item.text = 'Từ trái sang';
					break;
				case "To the right":
					item.text = 'Từ phải sang';
					break;
				case "Unfix":
					item.text = 'Không cố định';
					break;
			}
		});
	};

	const handleContextMenuPreparing = (e: any) => {
		const { row, column } = e;

		// Xác định loại ContextMenu (dành cho hàng hoặc cột)
		if (row) {
			// ContextMenu cho hàng
			// const rowData = row.data;
			// Tùy chỉnh ContextMenu cho hàng dựa trên rowData
			e.items?.push(
				{
					text: isHiddenGroup ? "Ẩn group" : "Hiện group",
					onItemClick: () => setIsHiddenGroup(pre => !pre),
					beginGroup: true,
				},
				{
					text: isHiddenSearch ? "Ẩn tìm kiếm" : "Hiện tìm kiếm",
					onItemClick: () => setIsHiddenSearch(pre => !pre),
				},
				{
					text: isHiddenFilter ? "Ẩn lọc" : "Hiện lọc",
					onItemClick: () => setIsHiddenFilter(pre => !pre),
				},
				{
					text: isHiddenAdvantageFilter ? "Ẩn lọc nâng cao" : "Hiện lọc nâng cao",
					onItemClick: () => setIsHiddenAdvantageFilter(pre => !pre),
				},
				{
					text: isHiddenColumnChooser ? "Ẩn ẩn cột" : "Hiện ẩn cột",
					onItemClick: () => setIsHiddenColumnChooser(pre => !pre),

				},
				// Các mục menu khác cho hàng
			);
		} else if (column) {
			// ContextMenu cho cột
			// const columnData = column.dataField;
			// Tùy chỉnh ContextMenu cho cột dựa trên columnData
			e.items.push(
				{
					text: isHiddenGroup ? "Ẩn group" : "Hiện group",
					onItemClick: () => setIsHiddenGroup(pre => !pre),
				},
				// Các mục menu khác cho cột
			);
		}

		// Thay đổi văn bản của các mục menu trong e.items
		handleContextMenuItems(e.items);


	};

	return (
		<MainCard>
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
						{/* {error} */}
					</Alert>
				</Collapse>

			</div>
			<div className='py-2'>

				{/* <AddNewActor />
				{openUpdate && <UpdateMovie {...rowItems} setOpenUpdateMovie={CloseUpdate} isOpen={openUpdate} />}
				<DeleteMuilActor id={rowSelect}  /> */}



			</div>
			<Paper elevation={1} square className='p-5 my-1'>
				<div className='flex items-center gap-2'>


					<DropdownWithDataGrid
						id="movie-select"
						value={filter.movieId ?? null}
						columns={movieColumns}
						placeholder="Chọn bộ phim ..."
						// filter={props.payload}
						name="id"
						keyExpr={"id"}
						valueExpr={"id"}
						apiUrl={"/api/Movies/paging/admin"}
						dataGridOnSelectionChanged={(e, newValue: any) => {
							handleChangeFilterInput({
								target: {
									name: "movieId",
									value: newValue?.id ?? null,
								},
							})
						}}
						syncDataGridSelection={function (e): void {
							handleChangeFilterInput({
								target: {
									name: "movieId",
									value: e?.value ?? null,
								},
							});
						}}
						gridBoxDisplayExpr={function (item: any): string {
							return item && `${item?.name}`;
						}}

					// disabled={props.action === ACTIONS.VIEW}
					/>

					<DropdownWithDataGrid
						id="cinema-select"
						value={filter.cinemaId ?? null}
						columns={cinemaColumns}
						placeholder="Chọn rạp chiếu phim ..."
						// filter={props.payload}
						name="id2"
						keyExpr={"id"}
						valueExpr={"id"}
						apiUrl={"/api/cinemas/paging/admin"}
						dataGridOnSelectionChanged={(e, newValue: any) => {
							handleChangeFilterInput({
								target: {
									name: "cinemaId",
									value: newValue?.id ?? null,
								},
							})
						}}
						syncDataGridSelection={function (e): void {
							handleChangeFilterInput({
								target: {
									name: "cinemaId",
									value: e?.value ?? null,
								},
							});
						}}
						gridBoxDisplayExpr={function (item: any): string {
							return item && `${item?.name} - ${item?.address}`;
						}}

					// disabled={props.action === ACTIONS.VIEW}
					/>



				</div>

			</Paper>
			<div style={{ height: 400, width: '100%', overflowY: 'scroll', marginTop: "0.5rem" }}>



				<DataGrid
					id="grid2Container"
					ref={dataGridRef}
					dataSource={dataSource}
					showBorders={true}
					// remoteOperations={{ grouping: false, filtering: true, sorting: false, paging: true, summary: true }}
					allowColumnResizing={true}
					repaintChangesOnly={true}
					noDataText='Không có dữ liệu'
					keyExpr={"id"}
					// columnHidingEnabled={true}
					columnMinWidth={50}
					columnAutoWidth={true}
					// focusedRowEnabled={true}
					// autoNavigateToFocusedRow
					onEditingStart={(e) => {
						console.log('EditingStart')
					}}
					onInitNewRow={(e) => {


					}}
					onRowInserting={(e) => {

					}}
					onRowInserted={(e) => {
						// const tempData = [...dataTable01D0]
						// tempData.push(e.data)
						// setDataTable01D0(tempData)
					}}

					onRowUpdating={(e) => console.log(e, 'RowUpdating')}
					onRowUpdated={(e) => {





					}}
					onRowRemoving={() => console.log('RowRemoving')}
					onRowRemoved={() => console.log('RowRemoved')}
					onSaving={() => console.log('Saving')}
					onSaved={(e) => {
						console.log(e, "saved")
					}}
					// selectedRowKeys={selectedRowKeys}
					// onSelectedRowKeysChange={setSelectedRowKeys}
					onEditCanceling={() => console.log('EditCanceling')}
					onEditCanceled={() => console.log('EditCanceled')}
					onSelectionChanged={(params) => {
						// const tempIndexs: number[] = []
						// if(dataGridRef.current){
						//     dataGridRef.current.instance.getSelectedRowKeys()
						//     .then(keys => {
						//         setSelectedRowKeys(keys)
						//         keys.forEach(key => {

						//             tempIndexs.push(dataGridRef.current!.instance.getRowIndexByKey(key))
						//         })
						//     });

						// setSelectedRowIndexs(tempIndexs);

						// }

					}}
					onContextMenuPreparing={handleContextMenuPreparing}
					onRowClick={async (e) => {
						dataGridRef.current?.instance.editRow(e.rowIndex)


					}}

				// onEditorPreparing={(e) => {


				// }}

				>
					<RemoteOperations grouping={false} filtering={true} paging={true} sorting={true} summary={true} />

					<HeaderFilter visible={true} allowSearch={true}  >
					</HeaderFilter>
					<FilterPanel visible={isHiddenAdvantageFilter} texts={{ clearFilter: "Xóa lọc", createFilter: "Tạo bộ lọc" }} />
					<FilterBuilderPopup title={"Tạo bộ lọc cho cột"} position={filterBuilderPopupPosition} />

					<ColumnChooser enabled={isHiddenColumnChooser} emptyPanelText={"Kéo và thả cột muốn ẩn vào đây"} title={"Chọn cột ẩn"} />
					<ColumnFixing enabled={true} />
					<Selection
						mode="single"
						selectAllMode={allMode}
						showCheckBoxesMode={checkBoxesMode}
						deferred={true}

					/>

					<Editing
						mode="popup"
						// allowUpdating={true}
						// allowAdding={true}
						// allowDeleting={true}
						// useIcons={true}
						confirmDelete={true}
						refreshMode={"reshape"}
					/>

					<FilterRow visible={isHiddenFilter} />
					<SearchPanel visible={isHiddenSearch} placeholder={"Tìm ..."} />
					<Grouping contextMenuEnabled={true} allowCollapsing={true} />
					<GroupPanel visible={isHiddenGroup} emptyPanelText={"Kéo vào thả cột muốn group vào đây"} />
					<Pager allowedPageSizes={pageSizes} showPageSizeSelector={true} />
					<LoadPanel enabled={true} />
					<Paging defaultPageSize={5} />

					{/* <Column
					  dataField="id"
					  defaultVisible={false}
					  visible={false}
					  allowEditing={false}
					  dataType="number"
					  formItem={{
						  visible: false
					  }}
					  allowFiltering={false}
					  allowSearch={false}
					  allowGrouping={false}
					  allowSorting={false}
				  
				  /> */}

					<Column
						dataField="flagScanner"
						caption={"Trạng thái"}
						dataType="boolean"
						allowEditing={false}
						headerFilter={{
							dataSource: [
								{
									text: "Đã quét",
									value: ["flagScanner", "=", true]
								},
								{
									text: "Chưa quét",
									value: ["flagScanner", "=", false]
								}
							]
						}}

						cellComponent={(props) =>
							<Label color={props.data.value ? "green" : "red"} size="small">
								{props.data.value ? "Đã quét" : "Chưa quét"}

							</Label>}
						editCellComponent={props => {
							return <Switch
								readOnly
								switchedOnText=''
								switchedOffText=''

								// width={100}
								value={props.data.value}
								onValueChanged={(e) => {
									props.data.setValue(e.value)
								}}
							/>
						}}
					/>

					<Column
						dataField="userFullName"
						dataType="string"
						caption={"Tên người đặt"}
						allowEditing={false}

					/>

					<Column
						dataField="paymentMethod"
						caption={"Phương thức thanh toán"}
						dataType="string"
						allowEditing={false}

						// calculateDisplayValue={(dataRow: any) => {
						// 	return dataRow.cinemaName
						// }}

						allowFiltering={true}

					// calculateSortValue={"cinemaName"}
					// cellComponent={(props) =>{
					//    return <>{props.data.text}</>
					// }}
					>
						{/* <Lookup 
					  dataSource={cinemaOptions} 
					  displayExpr={"name"} 
					  valueExpr={"id"}  
					  calculateCellValue={(params : any) =>{
						  console.log(params, "paráms")
					  } }/> */}
					</Column>
					<Column
						dataField="couponId"
						caption={"Mã giảm giá"}
						dataType="string"
						allowEditing={false}


					// calculateDisplayValue={(dataRow: any) => {
					// 	return dataRow.movieName
					// }}
					// calculateSortValue={"movieName"}
					// defaultSortOrder="asc"

					// cellComponent={(props) => <>{props.data.value}</>}
					/>
					<Column
						dataField="total"
						caption={"Tổng thanh toán"}
						dataType="number"
						format={"fixedPoint"}
						allowEditing={false}

						// calculateDisplayValue={(dataRow: any) => {
						// 	return dataRow.auditoriumName
						// }}
						// calculateCellValue={(dataRow: any) => {
						// 	return (dataRow?.auditoriumId && dataRow?.cinemaId) && `${dataRow?.auditoriumName} - ${dataRow?.cinemaName}`
						// }}
						// calculateSortValue={"auditoriumName"}
						cellRender={(props) => <Typography sx={{ color: "#06b6d4", fontWeight: 700, fontSize: 14 }}>{props.text}</Typography>}
						editCellComponent={(e) => (
							<NumberBox
								readOnly={true}
								// value={e.data.value}
								defaultValue={e.data.value}
								inputAttr={{
									style: "text-align: right"
								}}
								format="#,###"
								onValueChange={(value) => {
									e.data.setValue(value);
								}}
							/>
						)}
					/>
					<Column
						dataField="showTime"
						caption={"Giờ chiếu"}
						dataType="date"
						format={"HH:mm"}
						allowEditing={false}


						calculateDisplayValue={(dataRow: any) => {
							return dataRow.showDate && moment.utc(dataRow.showTime).local().toDate()
						}}
					// calculateCellValue={(dataRow: any) => {
					//     return dataRow.screeningTypeName;
					// }}
					// calculateSortValue={"screeningTypeName"}

					/>
					<Column
						dataField="showDate"
						caption={"Ngày chiếu"}
						dataType="date"
						format={"dd/MM/yyyy"}
						allowEditing={false}


					calculateDisplayValue={(dataRow: any) => {
						return dataRow.showDate && moment.utc(dataRow.showDate).local().toDate()
					}}
					// calculateCellValue={(dataRow: any) => {
					//     return dataRow.screeningTypeName;
					// }}
					// calculateSortValue={"screeningTypeName"}

					/>
					{/* <Column
							dataField="dateFrom"
							caption={"Ngày bắt đầu"}
							dataType="date"
							format='dd/MM/yyyy'
						/>
						<Column
							dataField="dateTo"
							caption={"Ngày kết thúc"}
							dataType="date"
							format='dd/MM/yyyy'
						/> */}
					<Column
						dataField="tickets"
						caption={"Vé"}
						dataType="string"
						allowFiltering={false}
						allowSearch={false}
						allowSorting={false}
						allowEditing={false}

					//   cellComponent={(props) => props.data.row.data.movieSchedule.map(({ id, showTime }: MovieSchedule, idx: number) => (
					// 	  <Label key={idx} color="olive" size="small">
					// 		  {moment.utc(showTime).local().format("HH:mm A")},

					// 	  </Label>))}
					/>
					<Column
						dataField="combos"
						caption={"Combo"}
						dataType="string"
						allowFiltering={false}
						allowSearch={false}
						allowSorting={false}

						allowEditing={false}

					//   cellComponent={(props) => props.data.row.data.movieSchedule.map(({ id, showTime }: MovieSchedule, idx: number) => (
					// 	  <Label key={idx} color="olive" size="small">
					// 		  {moment.utc(showTime).local().format("HH:mm A")},

					// 	  </Label>))}
					/>
					<Column
						dataField="seatRevered"
						caption={"ghế"}
						dataType="string"
						allowFiltering={false}
						allowSearch={false}
						allowSorting={false}

						allowEditing={false}

					//   cellComponent={(props) => props.data.row.data.movieSchedule.map(({ id, showTime }: MovieSchedule, idx: number) => (
					// 	  <Label key={idx} color="olive" size="small">
					// 		  {moment.utc(showTime).local().format("HH:mm A")},

					// 	  </Label>))}
					/>

					<Summary>
						<TotalItem
							column="total"
							summaryType="sum"
							displayFormat={"Tổng: {0}"}
							valueFormat={"fixedPoint"}
						// customizeText={React.useCallback((e: any) => {
						// 	return "Tổng: " + e.value;
						// }, [])}
						/>

					</Summary>

					{/* <Toolbar>
					  <Item name='addRowButton' showText='always' location={"before"} >
						  <Button
							  icon='add'
							  text="Thêm mới"
							  type="default"
							  stylingMode="contained"
							  onClick={() => {

								  if (dataGridRef.current) {
									  dataGridRef.current.instance.addRow();
								  }
							  }} />
					  </Item>
				  </Toolbar> */}

				</DataGrid>
				{
					// <DataGrid
					// 	 sx={{
					// 		'.MuiDataGrid-columnHeader': {
					// 		  backgroundColor: "#333",
					// 		  color: "#fff"
					// 		},
					// 	  }}
					// 	loading={status === "loading" ? true : false}
					// 	rows={bookings}
					// 	columns={columns}
					// 	pageSize={pageSize}
					// 	rowsPerPageOptions={[1, 3, 5, 10, 20, 50, 100]}
					// 	// onPageSizeChange={(newPageSize) => { setPageSize(newPageSize); dispatch(GetAllActorPagingAsync({ PageIndex: pageIndex, PageSize: newPageSize, Nationality: nationality })); }}
					// 	onPageSizeChange={(newPageSize) => { setPageSize(newPageSize); }}
					// 	pagination
					// 	paginationMode="server"
					// 	checkboxSelection
					// 	onPageChange={handlePageChange}
					// 	rowCount={rowCountState}
					// 	onSelectionModelChange={onRowSelectChange}
					// 	// components={{ Toolbar: GridToolbar, Pagination: CustomPagination, LoadingOverlay: LinearProgress, }}
					// 	components={{ BaseCheckbox: CustomCheckbox, Toolbar: GridToolbar, LoadingOverlay: LinearProgress, }}
					// 	localeText={locateText}
					// 	getCellClassName={(params) => { 
					// 		if (params.field === 'id' || params.field === 'userFullName' || params.field === 'paymentMethod' || params.field === 'couponId' ||  params.field === 'createdDate' || params.field === 'showTime'   || params.field === 'total' || params.field === 'combos'|| params.field === 'tickets' || params.field === 'seatRevered' || params.value == null) {
					// 			return '';
					// 		  }
					// 		  if(params.row.flagScanner === false){return "bg-blue-400"} 
					// 		return "bg-rose-400"
					// 	}}
					// 	onRowClick={handleRowClick}
					// />
				}



			</div>

			<Toast
				position={{ at: { x: "right", y: 'top' }, offset: { x: -250, y: 50 } }}
				visible={toast.visible}
				message={toast.message}
				type={toast.type}
				maxWidth={400}
				onHiding={() => setToast(pre => ({
					...pre,
					visible: false
				} as IToast))}

				displayTime={6000} // Thời gian hiển thị thông báo (tính bằng milliseconds)
			/>

		</MainCard>
	);
}

export default BookingManagement;