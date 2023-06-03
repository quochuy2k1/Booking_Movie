import { Button, DataGrid, } from "devextreme-react";
import { Column, Selection, ColumnFixing, FilterBuilderPopup, FilterPanel, FilterRow, GroupPanel, Grouping, HeaderFilter, Pager, Paging, SearchPanel, Editing, Item, LoadPanel, Toolbar } from "devextreme-react/data-grid";
import React, { useEffect, useState } from "react";
import 'devextreme/data/odata/store';
import 'whatwg-fetch';
import themes from 'devextreme/ui/themes';
import CustomStore from 'devextreme/data/custom_store';
import MainCard from "../../../../ui-component/cards/MainCard";
import { Alert, Collapse, IconButton, Paper } from "@mui/material";
import { Close } from "@mui/icons-material";
import moment from "moment";
import { Label } from "semantic-ui-react";
import { createStore } from 'devextreme-aspnet-data-nojquery';
import DropdownWithDataGrid, { IDataGirdColumn } from "../../../../ui-component/common/Dropdown/DropdownWithDataGrid";
import { MovieModel } from "../../../../../slices/movie/movieSlice";
import { GetAllMoviePaging } from "../../../../../services/movie.service";
import { CinemaModel } from "../../../../../slices/cinema/cinemaSlice";
import { GetAllCinemaPaging } from "../../../../../services/cinema.service";
import { IAuditoriumBaseModel } from "../../../../../slices/auditoriums/AuditoriumSlice";
import { GetAllAuditoriumPaging } from "../../../../../services/auditorium.service";
import { ShowTimeModel } from "../../../../../slices/showTime/showTimeSlice";
import { GetAllShowTimePaging } from "../../../../../services/showTime.service";
import { MovieSchedule, ScreeningModel } from "../../../../../slices/screenings/ScreeningSlice";
import { GetAllScreeningTypePaging } from "../../../../../services/screening.service";
import { ScreeningTypeModel } from "../../../../../slices/screenings/screeningTypeSlice";


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

interface IShowTimeModel {

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

const ScreeningManagement: React.FC = () => {
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

        GetAllCinemaPaging({ PageIndex: 0, PageSize: 100 })
            .then(res => {
                setCinemaOptions(res.data.result);
            });

        GetAllAuditoriumPaging({ PageIndex: 0, PageSize: 100 })
            .then(res => {
                setAuditoriumOptions(groupData(res.data.result));
            });

        GetAllShowTimePaging({ PageIndex: 0, PageSize: 100 })
            .then(res => {
                setShowTimeOptions(res.data.result);
            });

        GetAllScreeningTypePaging({ PageIndex: 0, PageSize: 100 })
            .then(res => {
                setScreeningTypeOptions(res.data.result);
            })
    }, [])

    useEffect(() => {
        const data = createStore({
            key: 'id',
            loadMethod: "POST",
            loadUrl: `${url}/api/movies/screening/paging/`,
            loadParams: {
                ...filter
            },
            insertUrl: `${url}/api/Screenings/add-new`,

            updateUrl: `${url}/api/Screenings/update`,
            // deleteUrl: `${url}/DeleteOrder`,
            onBeforeSend: (method, ajaxOptions) => {
                ajaxOptions.xhrFields = { withCredentials: true };
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
                            return item && `${item?.name} - ${item?.ReleaseDate ?? "No release date yet"}`;
                        }}

                    // disabled={props.action === ACTIONS.VIEW}
                    />

                    <DropdownWithDataGrid
                        id="cinema-select"
                        value={filter.cinemaId ?? null}
                        columns={cinemaColumns}
                        placeholder="Chọn rạp chiếu phim ..."
                        // filter={props.payload}
                        name="id"
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
                    id="gridContainer"
                    ref={dataGridRef}
                    dataSource={dataSource}
                    showBorders={true}
                    remoteOperations={{ grouping: false, filtering: true, sorting: true, paging: true }}
                    allowColumnResizing={true}
                    repaintChangesOnly
                    noDataText='Không có dữ liệu'
                    keyExpr={"id"}
                    // columnHidingEnabled={true}
                    columnMinWidth={50}
                    columnAutoWidth={true}
                    onEditingStart={(e) => {
                        console.log('EditingStart')
                    }}
                    onInitNewRow={(e) => {

                        const today = new Date();
                        const lastDayOfMonth = new Date(today.getFullYear(), today.getMonth() + 1, 0)
                        e.data.movieId = filter.movieId;
                        e.data.cinemaId = filter.cinemaId;
                        e.data.dateFrom = new Date();
                        e.data.dateTo = lastDayOfMonth;
                    }}
                    onRowInserting={(e) => {

                    }}
                    onRowInserted={(e) => {
                        // const tempData = [...dataTable01D0]
                        // tempData.push(e.data)
                        // setDataTable01D0(tempData)
                    }}

                    onRowUpdating={() => console.log('RowUpdating')}
                    onRowUpdated={(e) => console.log(e, 'RowUpdated')}
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

                        if ((e.parentType === "dataRow" || e.parentType === "filterRow") && e.dataField === "showTimeId") {
                            e.editorName = "dxTagBox"
                            e.editorOptions.dataSource = showTimeOptions;
                            e.editorOptions.showSelectionControls = true;
                            e.editorOptions.displayExpr = function (dataRow: any) {
                                return moment.utc(dataRow.time).local().format("HH:mm A")
                            };
                            e.editorOptions.tagComponent = function (e: any) {
                                console.log(e, "123456")
                            }
                            e.editorOptions.valueExpr = "id";
                            e.editorOptions.value = e.value || [];
                            e.editorOptions.onValueChanged = function (args: any) {
                                // console.log(args)
                                e.setValue(args.value);
                            }
                            console.log(e, "eee")

                            // Xử lý xóa tag
                            // 
                        }
                        if ((e.parentType === "dataRow" || e.parentType === "filterRow") && e.dataField === "cinemaId") {
                            e.editorName = "dxSelectBox";
                            e.editorOptions = {
                                ...e.editorOptions,
                                onValueChanged: function (args: any) {
                                    console.log(args);
                                    e.setValue(args.value);
                                    e.component.cellValue(e.row!.rowIndex, "auditoriumId", null);
                                    GetAllAuditoriumPaging({ PageIndex: 0, PageSize: 100, CinemaId: args.value })
                                        .then(res => {
                                            setAuditoriumOptions(groupData(res.data.result));



                                        })
                                }
                            };

                        }
                        if ((e.parentType === "dataRow" || e.parentType === "filterRow") && e.dataField === "auditoriumId") {
                            e.editorName = "dxSelectBox";
                            e.editorOptions = {
                                ...e.editorOptions,
                                readOnly: e.row?.data["cinemaId"] === null,
                                grouped: true,
                                onValueChanged: function (args: any) {
                                    console.log(args);
                                    e.setValue(args.value);

                                }
                            };

                            console.log(e, "eee")
                        }

                    }}

                >
                    <HeaderFilter visible={true} allowSearch={true}  >
                        {/* <RemoteOperations groupPaging={false} grouping={false}/> */}
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
                    />

                    <FilterRow visible={isHiddenFilter} />
                    <SearchPanel visible={isHiddenSearch} placeholder={"Tìm ..."} />
                    <Grouping contextMenuEnabled={true} allowCollapsing={true} />
                    <GroupPanel visible={isHiddenGroup} emptyPanelText={"Kéo vào thả cột muốn group vào đây"} />
                    <Pager allowedPageSizes={pageSizes} showPageSizeSelector={true} />
                    <LoadPanel enabled={true} />
                    <Paging defaultPageSize={5} />

                    <Column
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
                        
                    />
                    {/* <Column
                        dataField="cinemaId"
                        dataType="number"
                    /> */}

                    <Column
                        dataField="cinemaId"
                        caption={"Tên rạp chiếu phim"}
                        dataType="string"
                        calculateDisplayValue={(dataRow: any) => {
                            return dataRow.cinemaName
                        }}
                        lookup={{
                            dataSource: cinemaOptions,
                            allowClearing: true,
                            displayExpr: "name",
                            valueExpr: "id",


                        }}
                        allowFiltering={true}


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
                        dataField="movieId"
                        caption={"Tên bộ phim"}
                        dataType="string"
                        lookup={{
                            dataSource: movieOptions,
                            allowClearing: true,
                            displayExpr: "name",
                            valueExpr: "id"

                        }}
                        calculateDisplayValue={(dataRow: any) => {
                            return dataRow.movieName
                        }}
                    // cellComponent={(props) => <>{props.data.value}</>}
                    />
                    <Column
                        dataField="auditoriumId"
                        caption={"Tên phòng"}
                        dataType="string"
                        lookup={{
                            dataSource: auditoriumOptions,
                            allowClearing: true,
                            // calculateCellValue: (rowData: any) => {
                            //     return rowData.name;
                            // },
                            displayExpr: (items: any) => {
                                return items && `${items.name} - ${items.cinemaName}`
                            },
                            valueExpr: "id"

                        }}
                        calculateDisplayValue={(dataRow: any) => {
                            return dataRow.auditoriumName
                        }}
                        calculateCellValue={(dataRow: any) => {
                            return (dataRow?.auditoriumId && dataRow?.cinemaId) && `${dataRow?.auditoriumName} - ${dataRow?.cinemaName}`
                        }}
                    />
                    <Column
                        dataField="screeningTypeId"
                        caption={"Tên loại"}
                        dataType="string"
                        lookup={{
                            dataSource: screeningTypeOptions,
                            allowClearing: true,
                            // calculateCellValue: (rowData: any) => {
                            //     return rowData.name;
                            // },
                            displayExpr: (items: any) => {
                                return items && `${items.name}`
                            },
                            valueExpr: "id"

                        }}
                        calculateDisplayValue={(dataRow: any) => {
                            return dataRow.screeningTypeName
                        }}
                        calculateCellValue={(dataRow: any) => {
                            return dataRow.screeningTypeName;
                        }}
                    />
                    <Column
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
                    />
                    <Column
                        dataField="showTimeId"
                        caption={"Lịch chiếu"}
                        dataType="string"
                        // format="currency"
                        // lookup={
                        //     {
                        //         dataSource: [
                        //             { id: "08:00", showTime: moment("2023/05/30 08:00:00").toDate() },
                        //             { id: "10:00", showTime: moment("2023/05/30 10:00:00").toDate() },
                        //             { id: "13:00", showTime: moment("2023/05/30 13:00:00").toDate() }
                        //         ],
                        //         valueExpr: "id",
                        //         displayExpr: "id",
                        //         // calculateCellValue: function (data: any) {
                        //         //     // console.log(data, "d")
                        //         //     return moment(data.showTime).format("HH:MM");
                        //         // }

                        //     }
                        // }

                        cellComponent={(props) => props.data.row.data.movieSchedule.map(({ id, showTime }: MovieSchedule, idx: number) => (
                            <Label key={idx} color="olive" size="small">
                                {moment.utc(showTime).local().format("HH:mm A")},

                            </Label>))}
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



        </MainCard >
    );
}

export default ScreeningManagement;