import { DataGrid, DropDownBox } from "devextreme-react";
import { EventInfo, NativeEventInfo } from "devextreme/events";
import dxDropDownBox from "devextreme/ui/drop_down_box";
import { ValueChangedInfo } from "devextreme/ui/editor/editor";
import React from "react";
import { ToVietNamCurrency } from "../../../../common/utils/number.util";
import dxDataGrid, { DataType, SelectionChangedInfo } from "devextreme/ui/data_grid";
import { Column, FilterRow, Paging, RemoteOperations, Scrolling, SearchPanel, Selection } from "devextreme-react/data-grid";
import { Box } from "@mui/material";
import { createStore } from "devextreme-aspnet-data-nojquery";
import { Image } from 'semantic-ui-react'
import CustomStore from "devextreme/data/custom_store";


export interface IDataGirdColumn {
    id?: string | undefined;
    column_name?: string | undefined;
    name_vn?: string | undefined;
    name_en?: string | undefined;
    data_type?: string | undefined;
    format_type?: string | undefined;
    number_order?: number | undefined;
    isShowGrouping?: boolean | undefined;
    width?: number | undefined;
    default_hiden?: boolean | undefined;
    align?: string | undefined;
    type?: "image" | "status";
    allowFilter?: boolean;
    showgrouping?: boolean | undefined;
}

interface Iprops {
    id?: string;
    name?: string;
    className?: any;
    style?: any;
    columns?: IDataGirdColumn[];
    apiUrl?: string;
    dataGridOnSelectionChanged?: (e: any, newValue: any) => void;
    gridBoxDisplayExpr?: (item: any) => string;
    // renderOption?: ((props: React.HTMLAttributes<HTMLLIElement>, option: ICustomer, state: AutocompleteRenderOptionState) => React.ReactNode) | undefined
    syncDataGridSelection?: (e: NativeEventInfo<dxDropDownBox, Event> & ValueChangedInfo) => void;
    value?: any;
    width?: any;
    valueExpr?: any;
    keyExpr?: any;
    disabled?: boolean;
    placeholder?: string,
    table_name?: string;
    filter?: any,
    isEditColumnComponent?: boolean
}

const url = `${import.meta.env.VITE_REACT_APP_API_BASE!}`


export const DropdownWithDataGrid: React.FC<Iprops> = (props) => {


    const [columns, setColumns] = React.useState<IDataGirdColumn[]>([]);
    const [isGridBoxOpened, setIsGridBoxOpened] = React.useState<boolean>(false);
    const [valueEditColumn, setValueEditColumn] = React.useState<any>(props.value);

    // 
    const dropDownRef = React.useRef<DropDownBox>(null);
    const dataGridRef = React.useRef<DataGrid>(null);
    const [dataSource, setDataSource] = React.useState<CustomStore<any, any>>();
    //   
    

    React.useEffect(() => {

        const data = createStore({
            key: 'id',
            loadMode: "raw",
            loadMethod: "POST",
            loadUrl: `${url}${props.apiUrl}`,
            loadParams: {
                ...props.filter
            },
            //#endregion
            onBeforeSend: (method, ajaxOptions) => {
                ajaxOptions.xhrFields = { withCredentials: true };
            },
            onLoaded(result) {
    
            },
        });

        setDataSource(data);
    }, [])


    const formatDataType = (format_type?: string, value?: any) => {
        switch (format_type) {
            case 'MONEY_VND':
                return ToVietNamCurrency(value);
            default:
                return value;

        }
    }

    const onGridBoxOpened = (e: any) => {
        if (e.name === 'opened') {
            setIsGridBoxOpened(e.value)
        }
    }

    const dataGridOnSelectionChanged = (e: EventInfo<dxDataGrid<any, any>> & SelectionChangedInfo<any, any>) => {
        // this.setState({
        //   gridBoxValue: e.selectedRowKeys,
        //   isGridBoxOpened: false,
        // });
        props.dataGridOnSelectionChanged && props.dataGridOnSelectionChanged({}, e.selectedRowsData[0])
        setValueEditColumn(e.selectedRowsData[0][props.valueExpr])
        setIsGridBoxOpened(false);
    }
    const syncDataGridSelection = (e: NativeEventInfo<dxDropDownBox, Event> & ValueChangedInfo) => {
        props.syncDataGridSelection && props.syncDataGridSelection(e);
        setValueEditColumn(e.value)
    }
    const dataGridRender = () => {
        return (
            <DataGrid
                ref={dataGridRef}
                width={props.width}
                dataSource={dataSource}
                keyExpr={props.keyExpr}
                // columns={columns}
                hoverStateEnabled={true}
                // selectedRowKeys={selectedRowKeys}
                remoteOperations={true}
                onSelectionChanged={dataGridOnSelectionChanged}

            >
                {
                    props.columns && props.columns.map((row, index) => {



                        return <Column
                            key={index}
                            caption={row.name_vn}
                            dataField={row.column_name ? row.column_name : ""}
                            dataType={row.data_type as DataType}
                            format={row.format_type}
                            width={row.width ? row.width : 150}
                            visible={row.column_name?.toLocaleLowerCase() !== "Id".toLocaleLowerCase()}
                            allowFiltering={row.allowFilter}
                            grouped={row.isShowGrouping}
                            cellComponent={(props) => {
                                if (row.type === 'image') {

                                    return <Image src={props.data.value} size='medium' rounded />
                                }
                                return <>{props.data.value}</>;
                            }}
                        >

                        </Column>
                    })
                }
                <Selection mode="single" />
                <Scrolling mode="virtual" />
                <SearchPanel visible={true} />
                {/* <Paging enabled={true} pageSize={10} /> */}
                <FilterRow visible={true} />
                {/* <RemoteOperations paging={true}> */}

                {/* </RemoteOperations> */}
            </DataGrid>
        );
    }

    return (
        <>


            <Box sx={{ display: 'flex', flexDirection: 'column', position: 'relative' }}>
                <DropDownBox
                    ref={dropDownRef}
                    value={props.isEditColumnComponent ? valueEditColumn : props.value}
                    opened={isGridBoxOpened}
                    valueExpr={props.valueExpr}
                    deferRendering={false}   
                    displayExpr={props.gridBoxDisplayExpr}
                    placeholder={props.placeholder}
                    showClearButton={true}
                    dataSource={dataSource}
                    onValueChanged={syncDataGridSelection}
                    onOptionChanged={onGridBoxOpened}
                    contentRender={dataGridRender}
                    dropDownOptions={{
                        width: "auto",
                        height: "auto"

                    }}
                />
            </Box>



        </>
    );
}

export default DropdownWithDataGrid;