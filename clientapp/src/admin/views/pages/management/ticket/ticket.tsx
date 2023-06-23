import { Button, DataGrid, NumberBox, Toast, } from "devextreme-react";
import { Column, Selection, ColumnFixing, FilterBuilderPopup, FilterPanel, FilterRow, GroupPanel, Grouping, HeaderFilter, Pager, Paging, SearchPanel, Editing, Item, LoadPanel, Toolbar, RemoteOperations } from "devextreme-react/data-grid";
import React, { useEffect, useState } from "react";
import 'devextreme/data/odata/store';
import 'whatwg-fetch';
import themes from 'devextreme/ui/themes';
import CustomStore from 'devextreme/data/custom_store';
import MainCard from "../../../../ui-component/cards/MainCard";
import { Alert, Collapse, IconButton, Paper } from "@mui/material";
import { Close } from "@mui/icons-material";
import moment from "moment";
import { createStore } from 'devextreme-aspnet-data-nojquery';
import DropdownWithDataGrid, { IDataGirdColumn } from "../../../../ui-component/common/Dropdown/DropdownWithDataGrid";
import { MovieModel } from "../../../../../slices/movie/movieSlice";
import { GetAllMoviePaging } from "../../../../../services/movie.service";
import { CinemaModel } from "../../../../../slices/cinema/cinemaSlice";
import { IAuditoriumBaseModel } from "../../../../../slices/auditoriums/AuditoriumSlice";
import { ShowTimeModel } from "../../../../../slices/showTime/showTimeSlice";
import { GetAllShowTimePaging } from "../../../../../services/showTime.service";
import { ScreeningModel } from "../../../../../slices/screenings/ScreeningSlice";
import { ScreeningTypeModel } from "../../../../../slices/screenings/screeningTypeSlice";
import { STATUS_MESSAGE, STATUS_RESPONSE } from "../../../../../common/status-message";
import { ToastType } from "devextreme/ui/toast";


const url = `${import.meta.env.VITE_REACT_APP_API_BASE!}`


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

interface IAuditoriumGrouped {
    key: string,
    items: IAuditoriumBaseModel[]
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
const ticketTypeColumns: IDataGirdColumn[] = [
    {
        column_name: "name",
        data_type: "string",
        default_hiden: undefined,
        format_type: undefined,
        name_vn: "Tên loại vé",
        allowFilter: true,
        number_order: 0

    },
    {
        column_name: "description",
        data_type: "string",
        default_hiden: undefined,
        format_type: undefined,
        name_vn: "Môt tả",
        allowFilter: true,
        number_order: 5

    },
]
//#endregion

const pageSizes = [8, 12, 20];

const TicketManagement: React.FC = () => {
    const [openError, setOpenError] = React.useState<boolean>(false);
    const token = localStorage.getItem("token");

    //#region datagrid
    const dataGridRef = React.useRef<DataGrid>(null);
    const [dataSource, setDataSource] = React.useState<CustomStore<ScreeningModel, string>>();
    const [movieOptions, setMovieOptions] = React.useState<MovieModel[]>([]);
    const [cinemaOptions, setCinemaOptions] = React.useState<CinemaModel[]>([]);
    const [auditoriumOptions, setAuditoriumOptions] = React.useState<IAuditoriumGrouped[]>([]);
    const [showTimeOptions, setShowTimeOptions] = React.useState<ShowTimeModel[]>([]);
    const [screeningTypeOptions, setScreeningTypeOptions] = React.useState<ScreeningTypeModel[]>([]);

    // 
    const [isHiddenGroup, setIsHiddenGroup] = React.useState<boolean>(false);
    const [isHiddenSearch, setIsHiddenSearch] = React.useState<boolean>(false);
    const [isHiddenFilter, setIsHiddenFilter] = React.useState<boolean>(false);
    const [isHiddenAdvantageFilter, setIsHiddenAdvantageFilter] = React.useState<boolean>(false);
    const [isHiddenColumnChooser, setIsHiddenColumnChooser] = React.useState<boolean>(false);

    // 

    const [allMode] = useState<string>('allPages');
    const [checkBoxesMode] = useState<string>(themes.current().startsWith('material') ? 'always' : 'onClick');

    // 

    const [filter, setFilter] = useState<IFilter>(defaultFilter);

    // Toast

    const [toast, setToast] = useState<IToast>(defaultToast);

    // 
    const filterBuilderPopupPosition = {
        of: window,
        at: 'top',
        my: 'top',
        offset: { y: 10 },
    };

    const handleChangeFilterInput = (e: any) => {
        const { name, value } = e.target;

        setFilter(pre => ({ ...filter, [name]: value } as IFilter));
    };

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

    // Hàm nhóm dữ liệu theo key
    const groupData = (data: IAuditoriumBaseModel[]): IAuditoriumGrouped[] => {
        const groupedData: IAuditoriumGrouped[] = [];

        // Tạo một đối tượng dùng để lưu trữ các nhóm dữ liệu
        const groups: { [key: string]: IAuditoriumBaseModel[] } = {};

        // Lặp qua từng item trong mảng dữ liệu đầu vào
        for (const item of data) {
            // Kiểm tra xem item.key đã tồn tại trong groups hay chưa
            if (item.cinemaName in groups) {
                // Nếu đã tồn tại, push item vào mảng items tương ứng
                groups[item.cinemaName].push(item);
            } else {
                // Nếu chưa tồn tại, tạo một mảng mới và thêm item vào đó
                groups[item.cinemaName] = [item];
            }
        }

        // Duyệt qua các nhóm đã tạo và tạo các đối tượng IAuditoriumGrouped tương ứng
        for (const key in groups) {
            const groupedItem: IAuditoriumGrouped = {
                key,
                items: groups[key],
            };

            groupedData.push(groupedItem);
        }

        return groupedData;
    }
    useEffect(() => {

        GetAllMoviePaging({ PageIndex: 0, PageSize: 100 })
            .then(res => {
                setMovieOptions(res.data.result);
            });



        GetAllShowTimePaging({ PageIndex: 0, PageSize: 100 })
            .then(res => {
                setShowTimeOptions(res.data.result);
            });


    }, [])

    useEffect(() => {
        const data = createStore({
            key: 'id',
            loadMethod: "POST",
            loadUrl: `${url}/api/tickets/paging/admin`,
            loadParams: {
                ...filter
            },
            insertUrl: `${url}/api/tickets/create`,

            updateUrl: `${url}/api/tickets/update`,
            // deleteUrl: `${url}/DeleteOrder`,
            onBeforeSend: (method, ajaxOptions) => {
                ajaxOptions.xhrFields = { withCredentials: true };
                ajaxOptions.headers = {

                    'Authorization': `Bearer ${token}`,
                    'CrossOrigin': "true",
                    'Mode': 'no-cors',
                }
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



    //#endregion


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
                                    // dispatch(emptyMovieError());
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
            <div className='py-2'></div>
            <Paper elevation={1} square className='p-5 my-1'>
                <div className='flex items-center gap-2'>

                    <DropdownWithDataGrid
                        id="movie-select"
                        value={filter.movieId ?? null}
                        columns={movieColumns}
                        placeholder="Chọn bộ phim ..."
                        // filter={props.payload}
                        name="id"
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

                </div>

            </Paper>
            <div style={{ height: 400, width: '100%', overflowY: 'scroll', marginTop: "0.5rem" }}>

                <DataGrid
                    id="gridContainer"
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
                        e.data.movieId = filter.movieId;
                    }}
                    onRowInserting={(e) => {

                    }}
                    onRowInserted={(e) => {
                        // const tempData = [...dataTable01D0]
                        // tempData.push(e.data)
                        // setDataTable01D0(tempData)
                        setToast({
                            visible: true,
                            type: STATUS_RESPONSE[e.data.status] as ToastType,
                            message: STATUS_MESSAGE[e.data.message]

                        });
                    }}

                    onRowUpdating={(e) => console.log(e, 'RowUpdating')}
                    onRowUpdated={(e) => {


                        setToast({
                            visible: true,
                            type: STATUS_RESPONSE[e.data.status] as ToastType,
                            message: STATUS_MESSAGE[e.data.message]

                        });


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

                    onEditorPreparing={(e) => {


                        if ((e.parentType === "dataRow" || e.parentType === "filterRow") && e.dataField === "movieId") {

                            if (!e.row?.isNewRow) {
                                e.editorOptions.readOnly = true;
                            }
                            e.editorName = "dxSelectBox";
                            e.editorOptions = {
                                ...e.editorOptions,
                                onValueChanged: function (args: any) {
                                    console.log(args);
                                    e.setValue(args.value);
                                    // e.component.cellValue(e.row!.rowIndex, "auditoriumId", null);

                                }
                            };

                        }


                    }}

                >
                    <RemoteOperations grouping={false} filtering={true} paging={true} sorting={true} summary={true} />

                    <HeaderFilter visible={true} allowSearch={true}  >
                    </HeaderFilter>
                    <FilterPanel visible={isHiddenAdvantageFilter} texts={{ clearFilter: "Xóa lọc", createFilter: "Tạo bộ lọc" }} />
                    <FilterBuilderPopup title={"Tạo bộ lọc cho cột"} position={filterBuilderPopupPosition} />

                    {/* <ColumnChooser mode={"select"} enabled={isHiddenColumnChooser} emptyPanelText={"Kéo và thả cột muốn ẩn vào đây"} title={"Chọn cột ẩn"} /> */}
                    <ColumnFixing enabled={true} />
                    <Selection
                        mode="multiple"
                        selectAllMode={allMode}
                        showCheckBoxesMode={checkBoxesMode}
                        deferred={true}

                    />

                    <Editing
                        mode="form"
                        allowUpdating={true}
                        allowAdding={true}
                        allowDeleting={true}
                        useIcons={true}
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
                    {/* <Column
                        dataField="cinemaId"
                        dataType="number"
                    /> */}

                    <Column
                        dataField="movieId"
                        caption={"Tên phim"}
                        dataType="string"
                        calculateDisplayValue={(dataRow: any) => {
                            return dataRow.movieName
                        }}
                        lookup={{
                            dataSource: movieOptions,
                            allowClearing: true,
                            displayExpr: "name",
                            valueExpr: "id",


                        }}
                        allowFiltering={true}

                        calculateSortValue={"movieName"}
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
                        dataField="ticketTypeId"
                        caption={"Tên vé"}
                        dataType="string"
                        calculateDisplayValue={(dataRow: any) => {
                            return dataRow.ticketTypeName
                        }}
                        calculateCellValue={(dataRow: any) => {
                            return dataRow.ticketTypeId
                        }}

                        // defaultSortOrder="asc"

                        editCellComponent={(props) => {
                            console.log(props);
                            return <DropdownWithDataGrid
                                id="ticket-type-select"
                                value={props.data?.value ?? null}
                                columns={ticketTypeColumns}
                                placeholder="Chọn loại vé ..."
                                // filter={props.payload}
                                isEditColumnComponent
                                name="id"
                                valueExpr={"id"}
                                apiUrl={"/api/ticketTypes/paging/admin"}
                                dataGridOnSelectionChanged={(e, newValue: any) => {
                                    props.data.setValue(newValue?.id)
                                    console.log(props.data.component.cellValue(0, 4))
                                    // props.data.component.cellValue(0, 4, newValue?.description);
                                    props.data.column.setCellValue = (newData: any, value: any, currentRowData: any) => {  
                                        newData.description = newValue?.description;    
                        }  
                                    // props.data.data = {...props.data.data, description: newValue?.description};
                                }}
                                syncDataGridSelection={function (e): void {
                                    props.data.setValue(e.value)
                                    
                                }}
                                gridBoxDisplayExpr={function (item: any): string {
                                    return item && `${item?.name}`;
                                }}
        
                            // disabled={props.action === ACTIONS.VIEW}
                            />
                        }}
                    />
                    <Column
                        dataField="price"
                        caption={"Giá vé"}
                        dataType="number"
                        format={"fixedPoint"}
                        editCellComponent={(e) => (
                            <NumberBox
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
                        dataField="description"
                        caption={"Mô tả"}
                        dataType="string"

                    />
                    <Column
                        dataField="validityDateFromId"
                        caption={"Thời gian từ"}
                        dataType="datetime"
                        format='HH:mm'
                        lookup={{
                            dataSource: showTimeOptions,
                            allowClearing: true,
                            displayExpr: (dataRow: any) => {
                                return moment.utc(dataRow.time).local().format("HH:mm A")
                            },
                            valueExpr: "id",


                        }}
                        calculateDisplayValue={(dataRow: any) => {
                            return moment.utc(dataRow.validityDateFrom).local().toDate()
                        }}
                        calculateCellValue={(dataRow: any) => {
                            return dataRow.validityDateFromId
                        }}
                        calculateSortValue={"validityDateFrom"}
                    />
                    <Column
                        dataField="validityDateToId"
                        caption={"Thời gian đến"}
                        dataType="datetime"
                        format='HH:mm'
                        calculateDisplayValue={(dataRow: any) => {
                            return moment.utc(dataRow.validityDateTo).local().toDate()
                        }}
                        calculateCellValue={(dataRow: any) => {
                            return dataRow.validityDateToId
                        }}
                        lookup={{
                            dataSource: showTimeOptions,
                            allowClearing: true,
                            displayExpr: (dataRow: any) => {
                                return moment.utc(dataRow.time).local().format("HH:mm A")
                            },
                            valueExpr: "id",


                        }}

                        calculateSortValue={"validityDateTo"}
                    />


                    <Toolbar>
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
                    </Toolbar>

                </DataGrid>


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
        </MainCard >
    );
}

export default TicketManagement;