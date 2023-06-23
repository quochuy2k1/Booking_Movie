import { Toast, } from "devextreme-react";
import React, { useEffect } from "react";
import 'devextreme/data/odata/store';
import 'whatwg-fetch';
import MainCard from "../../../../ui-component/cards/MainCard";
import { Alert, Collapse, Grid, IconButton, Paper } from "@mui/material";
import { Close } from "@mui/icons-material";
import DropdownWithDataGrid, { IDataGirdColumn } from "../../../../ui-component/common/Dropdown/DropdownWithDataGrid";
import { AuditoriumModel, IAuditoriumBaseModel } from "../../../../../slices/auditoriums/AuditoriumSlice";
import { ToastType } from "devextreme/ui/toast";
import classNames from "classnames";
import { areasTest } from "./data-test";
import "../../../../../client/features/auditoriums/auditorium.css"
import { Button, Container, Icon, Label, Tab } from "semantic-ui-react";
import SeatRangeAction from "./actions/SeatRangeAction";
import { SeatNoState } from "../../../../../slices/seats/SeatSlice";
import { STATUS_MESSAGE, STATUS_RESPONSE } from "../../../../../common/status-message";
import Notify from 'devextreme/ui/notify';
import DeleteByColumnAction from "./actions/DeleteByColumn";
import AddByColumnAction from "./actions/AddByColumn";
import AddByRowAction from "./actions/AddByRow";
import DeleteByRowAction from "./actions/DeleteByRow";
import { GetSeatByAuditorium, SeatNoSaveChanage } from "../../../../../services/auditorium.service";
import _ from 'lodash'

const url = `${import.meta.env.VITE_REACT_APP_API_BASE!}`

export interface ISeatNoChangeAction {
    action: string,
    seatNos: SeatNoState[]
}

interface IAction {
    open: boolean,
    type: string,
    payload: any

}

const defaultAction: IAction = {
    open: false,
    type: "",
    payload: null
}

interface IFilter {
    movieId?: string,
    cinemaId?: string,
    auditoriumId?: number,
}

const defaultFilter: IFilter = {
    movieId: undefined,
    cinemaId: undefined,
    auditoriumId: undefined,
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


const auditoriumColumns: IDataGirdColumn[] = [
    {
        column_name: "cinemaName",
        data_type: "string",
        default_hiden: undefined,
        format_type: undefined,
        name_vn: "Tên rạp chiếu phim",
        allowFilter: true,
        isShowGrouping: true,
        number_order: 0

    },
    {
        column_name: "name",
        data_type: "string",
        default_hiden: undefined,
        format_type: undefined,
        name_vn: "Tên phòng chiếu phim",
        allowFilter: true,
        width: 360,
        number_order: 5

    },
]
//#endregion


const AuditoriumManagement: React.FC = () => {
    const [openError, setOpenError] = React.useState<boolean>(false);
    const token = localStorage.getItem("token");
    const [toast, setToast] = React.useState<IToast>(defaultToast);

    const [seatNoOrigirin, setSeatNoOrigirnin] = React.useState<SeatNoState[]>([])
    const [areas, setAreas] = React.useState<AuditoriumModel[]>([])
    const [seatNoChanging, setSeatNoChanging] = React.useState<ISeatNoChangeAction[]>([])
    const [length, setLength] = React.useState<number>(Math.max(...areas.map(auditorim => auditorim.seats.length)));
    const [columns, setColumns] = React.useState<number[]>([]);
    const [rows, setRows] = React.useState<number[]>([]);
    const [actSr, setActSr] = React.useState<IAction>(defaultAction);
    const [actDc, setActDc] = React.useState<IAction>(defaultAction);
    const [actDr, setActDr] = React.useState<IAction>(defaultAction);
    const [actAc, setActAc] = React.useState<IAction>(defaultAction);
    const [actAr, setActAr] = React.useState<IAction>(defaultAction);

    // 

    const [filter, setFilter] = React.useState<IFilter>(defaultFilter);

    // 
    useEffect(() => {
        if (filter.auditoriumId) {
            GetSeatByAuditorium(filter.auditoriumId!.toString()).then(response => {
                setSeatNoOrigirnin(Object.values(JSON.parse(JSON.stringify(response.data))).flatMap((group: any) => group.seats));
                console.log(response.data, Object.values(response.data).flatMap(group => group.seats), "data")
                setAreas([...response.data]);
                // const maxLength = Math.max(...response.data.(x => !x.physicalName!.includes("0"))!.seats.map(seatNo => seatNo.columnIndex!));
                let maxColumnIndex: number | undefined = -Infinity;
                for (const auditoriumModel of response.data) {
                    for (const seat of auditoriumModel.seats) {
                      if (seat.columnIndex! > maxColumnIndex!) {
                        maxColumnIndex = seat.columnIndex;
                      }
                    }
                    
                    // Kiểm tra nếu maxColumnIndex đã đạt giá trị tối đa (columnIndex = 1000)
                    if (maxColumnIndex === 1000) {
                      break;
                    }
                  }
                setLength(maxColumnIndex ?? 0)

                // 

                const rowTemp: number[] = [];
                const colTemp: number[] = []
                response.data.forEach((auditorium, AuditoriumIndex) => {
                    let rowNum: number = 0;

                    if (auditorium.physicalName.includes("0")) {
                        rowNum = parseFloat(`${auditorium.physicalName.charCodeAt(0) - 64}.1`)
                    }
                    else rowNum = parseInt(`${auditorium.physicalName.charCodeAt(0) - 64}`)
                    console.log(rowNum, "rowNum")
                    if (rowNum > 0) {
                        rowTemp.push(rowNum)
                    }


                });

                for (let i = 1; i <= maxColumnIndex!; i++) {
                    colTemp.push(i);
                }


                setColumns(colTemp);
                setRows(rowTemp);
            }).catch(error => {
                setColumns([])
                setRows([])
                setAreas([])
            })
        }



    }, [filter.auditoriumId])



    const handleChangeFilterInput = (e: any) => {
        const { name, value } = e.target;

        setFilter(pre => ({ ...filter, [name]: value } as IFilter));
    };


    //#region compareDiff


    function findArrayDifferences(oldArray: SeatNoState[], newArray: SeatNoState[]) {
        const differences: ISeatNoChangeAction[] = [
            { action: "insert", seatNos: [] },
            { action: "update", seatNos: [] },
            { action: "delete", seatNos: [] },
        ];
        newArray.forEach(newItem => {
            const matchingItem = oldArray.find(oldItem => oldItem.seatId === newItem.seatId);
            const matchingUpdateItem = oldArray.find(oldItem => newItem.seatId === oldItem.seatId && newItem.columnIndex !== oldItem.columnIndex);
            if(matchingUpdateItem){
                differences[1].seatNos.push(newItem)
            }
            if (!matchingItem) {

                differences[0].seatNos.push(newItem);
            } else if (!compareObjects(matchingItem, newItem)) {
                //   differences.push({ action: 'update', seatNos: [newItem] });
            }
        });



        oldArray.forEach(oldItem => {
            const matchingDelItem = newArray.find(newItem => oldItem.seatNoId === newItem.seatNoId );
           

            if (!matchingDelItem) {
                differences[2].seatNos.push(oldItem);
            }
        });

        return differences;
    }

    // Hàm so sánh hai đối tượng
    function compareObjects<T>(obj1: T, obj2: T) {
        return JSON.stringify(obj1) === JSON.stringify(obj2);
    }
    //#endregion

    //#endregion


    const handleSeatRange = (colRange: number, rowRange: number) => {
        const cols: number[] = [];
        const rows: number[] = [];

        const areasTemp: AuditoriumModel[] = [];
        const seatNosTemp: SeatNoState[] = [];
        areasTemp.push({
            physicalName: "0",
            seats: [
                {
                    seatId: "00",
                    row: "0",
                    number: 0
                },

            ],
        } as AuditoriumModel)

        for (let i = 1; i <= colRange; i++) {
            cols.push(i);
        }
        for (let i = 1; i <= rowRange; i++) {
            rows.push(i);
        }

        for (let i = 1; i <= rowRange; i++) {
            const physicalName = String.fromCharCode(i + 64);
            const seatNoTemp: SeatNoState[] = [];

            for (let j = 1; j <= colRange; j++) {
                const seatNo: SeatNoState = {
                    id: `${physicalName}${j}`,
                    number: j,
                    row: physicalName,
                    columnIndex: j,
                    rowIndex: i,
                    seatId: `${physicalName}${j}`,
                    auditoriumId: filter?.auditoriumId,
                    status: false
                }
                seatNoTemp.push(seatNo);
                seatNosTemp.push(seatNo);

            }

            areasTemp.push({
                physicalName: physicalName,
                seats: seatNoTemp
            } as AuditoriumModel)

        }
        console.log(areasTemp, "area")
        setLength(Math.max(...areasTemp.map(auditorim => auditorim.seats.length)))
        setAreas(areasTemp);

        setSeatNoOrigirnin([]);

        setColumns(cols);
        setRows(rows);
    }

    const handleRemoveColumn = (row: number, col: number, rowIndex: number, colIndex: number) => {
        console.log(row, col, rowIndex, colIndex)
        const areasTemp = [...areas];
        try {
            areasTemp.map((auditorium, auditoriumIndex) => {
                if (auditorium.physicalName === String.fromCharCode(row + 64)) {
                    auditorium.seats.map((seatNo, seatNoIndex) => {
                        if (seatNo.columnIndex === col && seatNo.rowIndex === row) {
                            areasTemp[auditoriumIndex].seats.splice(seatNoIndex, 1);

                            for (let i = seatNoIndex; i < areasTemp[auditoriumIndex].seats.length; i++) {
                                const newNumIndex = areasTemp[auditoriumIndex].seats[i].number! - 1;
                                // const newColIndex = areasTemp[auditoriumIndex].seats[i].columnIndex! - 1;
                                // areasTemp[auditoriumIndex].seats[i].columnIndex! = newIndex;
                                areasTemp[auditoriumIndex].seats[i].number! = newNumIndex;
                                areasTemp[auditoriumIndex].seats[i].id! = `${areasTemp[auditoriumIndex].physicalName}${newNumIndex}`;
                                areasTemp[auditoriumIndex].seats[i].seatId! = `${areasTemp[auditoriumIndex].physicalName}${newNumIndex}`;
                                // console.log(areasTemp[auditoriumIndex].seats[i].columnIndex)

                            }

                        }
                    })
                }
            });
            Notify({
                message: STATUS_MESSAGE["DELETE_SUCCESS"] + ` Ghế ${String.fromCharCode(row + 64)}${col}`,
                // height: 45,
                width: 300,
                minWidth: 300,
                type: "success",
                displayTime: 3500,
                animation: {
                    show: {
                        type: 'fade', duration: 400, from: 0, to: 1,
                    },
                    hide: { type: 'fade', duration: 40, to: 0 },
                },
            }, {
                position: "top right",
                direction: "down-stack",
            });
            // setToast({
            //     visible: true,
            //     type: "success",
            //     message: STATUS_MESSAGE["DELETE_SUCCESS"] + ` Ghế ${String.fromCharCode(row + 64)}${col}`

            // });
            // setLength(Math.max(...areasTemp.map(auditorim => auditorim.seats.length)))
            setAreas(areasTemp);
        } catch (error) {
            console.error(error)
        }
    }
    const handleRemoveMultiableColumn = (colDel: number[]) => {

        const areasTemp = [...areas];
        try {
            for (let auditoriumIndex = 0; auditoriumIndex < areasTemp.length; auditoriumIndex++) {
                const auditorium = areasTemp[auditoriumIndex];
                for (let seatNoIndex = 0; seatNoIndex < auditorium.seats.length; seatNoIndex++) {
                    const seatNo = auditorium.seats[seatNoIndex];
                    if (colDel.includes(seatNo.columnIndex!) && auditorium.physicalName !== "0") {
                        areasTemp[auditoriumIndex].seats.splice(seatNoIndex, 1);
                        for (let i = seatNoIndex; i < areasTemp[auditoriumIndex].seats.length; i++) {
                            const newNumIndex = areasTemp[auditoriumIndex].seats[i].number! - 1;
                            // const newColIndex = areasTemp[auditoriumIndex].seats[i].columnIndex! - 1;
                            // areasTemp[auditoriumIndex].seats[i].columnIndex! = newIndex;
                            areasTemp[auditoriumIndex].seats[i].number! = newNumIndex;
                            areasTemp[auditoriumIndex].seats[i].id! = `${areasTemp[auditoriumIndex].physicalName}${newNumIndex}`;
                            areasTemp[auditoriumIndex].seats[i].seatId! = `${areasTemp[auditoriumIndex].physicalName}${newNumIndex}`;
                            // console.log(areasTemp[auditoriumIndex].seats[i].columnIndex)

                        }
                        seatNoIndex--; // Giảm chỉ số để duyệt qua phần tử mới

                        // for (let i = seatNoIndex; i < auditorium.seats.length; i++) {
                        //     areasTemp[auditoriumIndex].seats[i].columnIndex! -= 1;
                        //     // console.log(areasTemp[auditoriumIndex].seats[i].columnIndex)
                        // }
                    }
                }
            }

            Notify({
                message: STATUS_MESSAGE["DELETE_SUCCESS"] + ` Tất cả ghế ở cột ${colDel.join(", ")}`,
                // height: 45,
                width: 300,
                minWidth: 300,
                type: "success",
                displayTime: 3500,
                animation: {
                    show: {
                        type: 'fade', duration: 400, from: 0, to: 1,
                    },
                    hide: { type: 'fade', duration: 40, to: 0 },
                },
            }, {
                position: "top right",
                direction: "down-stack",
            });
            // setToast({
            //     visible: true,
            //     type: "success",
            //     message: STATUS_MESSAGE["DELETE_SUCCESS"] + ` Ghế ${String.fromCharCode(row + 64)}${col}`

            // });
            // setLength(Math.max(...areasTemp.map(auditorim => auditorim.seats.length)))
            setAreas(areasTemp);
        } catch (error) {

        }
    }
    const handleAddMultiableColumn = (colAdd: number[]) => {

        const areasTemp = [...areas];
        try {
            for (let auditoriumIndex = 0; auditoriumIndex < areasTemp.length; auditoriumIndex++) {
                const auditorium = areasTemp[auditoriumIndex];
                const physicalName = auditorium.physicalName;
                const seatNoTemp: SeatNoState[] = [...areasTemp[auditoriumIndex].seats];
                // for (let seatNoIndex = 0; seatNoIndex < auditorium.seats.length; seatNoIndex++) {
                // const seatNo = auditorium.seats[seatNoIndex];
                colAdd.sort().forEach(col => {
                    if (!auditorium.physicalName.includes("0")) {
                        for (let i = col - 1; i > -1; i--) {
                            const seatNoPre = col === 1 ? seatNoTemp[0] : seatNoTemp.find(x => x.columnIndex === i);

                            if (seatNoPre) {
                                const newNumIndex = col === 1 ? seatNoPre.number! : seatNoPre.number! + 1;

                                const seatNo: SeatNoState = {
                                    id: `${physicalName}${newNumIndex}`,
                                    number: newNumIndex,
                                    row: physicalName,
                                    columnIndex: col,
                                    rowIndex: auditoriumIndex,
                                    seatId: `${physicalName}${newNumIndex}`,
                                    auditoriumId: filter?.auditoriumId,
                                    status: false
                                }

                                // seatNoTemp.push(seatNo);
                                if(seatNoTemp[col === 1 ? seatNoPre.number! - 1 : seatNoPre.number!].columnIndex !== col){
                                    seatNoTemp.splice(col === 1 ? seatNoPre.number! - 1 : seatNoPre.number!, 0, seatNo);
                                    for (let i = seatNoPre.number! + (col === 1 ? 0 : 1); i < seatNoTemp.length; i++) {
                                        const newIndex = seatNoTemp[i].number! + 1;
                                        // seatNoTemp[i].columnIndex! = newIndex;
                                        seatNoTemp[i].number! = newIndex;
                                        seatNoTemp[i].id! = `${physicalName}${newIndex}`;
                                        seatNoTemp[i].seatId! = `${physicalName}${newIndex}`;
                                        // console.log(seatNoTemp[i].columnIndex)
    
                                    }
                                }
                               
                                break;
                            }
                        }
                    }
                })
                // if (!colAdd.includes(seatNo.columnIndex!)) {



                //     seatNoIndex--; // Giảm chỉ số để duyệt qua phần tử mới

                //     // for (let i = seatNoIndex; i < auditorium.seats.length; i++) {
                //     //     areasTemp[auditoriumIndex].seats[i].columnIndex! -= 1;
                //     //     // console.log(areasTemp[auditoriumIndex].seats[i].columnIndex)
                //     // }
                // }
                // }

                areasTemp[auditoriumIndex].seats = seatNoTemp;

            }

            Notify({
                message: STATUS_MESSAGE["ADD_SUCCESS"] + ` Tất cả ghế ở cột ${colAdd.join(", ")}`,
                // height: 45,
                width: 300,
                minWidth: 300,
                type: "success",
                displayTime: 3500,
                animation: {
                    show: {
                        type: 'fade', duration: 400, from: 0, to: 1,
                    },
                    hide: { type: 'fade', duration: 40, to: 0 },
                },
            }, {
                position: "top right",
                direction: "down-stack",
            });
            // setToast({
            //     visible: true,
            //     type: "success",
            //     message: STATUS_MESSAGE["DELETE_SUCCESS"] + ` Ghế ${String.fromCharCode(row + 64)}${col}`

            // });
            // setLength(Math.max(...areasTemp.map(auditorim => auditorim.seats.length)))
            setAreas(areasTemp);
        } catch (error) {

        }
    }
    const handleAddColumn = (row: number, col: number, rowIndex: number, colIndex: number) => {
        console.log(row, col, rowIndex, colIndex)
        const areasTemp = [...areas];
        try {
            const physicalName = areasTemp[rowIndex + 1].physicalName;
            const seatNoTemp: SeatNoState[] = [...areasTemp[rowIndex + 1].seats];
            // console.log(seatNoPre,areasTemp[rowIndex + 1], "pre")


            for (let i = col - 1; i > -1; i--) {
                // i === 0 có nghĩa là seat A1 nên giữ nguyên không cộng 1
                const seatNoPre = col === 1 ? areasTemp[rowIndex + 1].seats[0] : areasTemp[rowIndex + 1].seats.find(x => x.columnIndex === i);
                if (seatNoPre) {
                    const newNumIndex = col === 1 ? seatNoPre.number! : seatNoPre.number! + 1;
                    const seatNo: SeatNoState = {
                        id: `${physicalName}${newNumIndex}`,
                        number: newNumIndex,
                        row: physicalName,
                        columnIndex: col,
                        rowIndex: row,
                        seatId: `${physicalName}${newNumIndex}`,
                        auditoriumId: filter?.auditoriumId,
                        status: false
                    }
                    const auditorium = areasTemp[rowIndex + 1];

                    // if (colIndex <= 1) {
                    //     seatNoTemp.splice(seatNoPre.number!, 0, seatNo);
                    //     for (let i = seatNoPre.number! + 1; i < seatNoTemp.length; i++) {
                    //         const newIndex = seatNoTemp[i].number! + 1;
                    //         // seatNoTemp[i].columnIndex! = newIndex;
                    //         seatNoTemp[i].number! = newIndex;
                    //         seatNoTemp[i].id! = `${String.fromCharCode(row + 64)}${newIndex}`;
                    //         seatNoTemp[i].seatId! = `${String.fromCharCode(row + 64)}${newIndex}`;
                    //         // console.log(seatNoTemp[i].columnIndex)

                    //     }

                    // }
                    // else {
                    seatNoTemp.splice(col === 1 ? seatNoPre.number! - 1 : seatNoPre.number!, 0, seatNo);
                    for (let i = seatNoPre.number! + (col === 1 ? 0 : 1); i < seatNoTemp.length; i++) {
                        const newIndex = seatNoTemp[i].number! + 1;
                        // seatNoTemp[i].columnIndex! = newIndex;
                        seatNoTemp[i].number! = newIndex;
                        seatNoTemp[i].id! = `${physicalName}${newIndex}`;
                        seatNoTemp[i].seatId! = `${physicalName}${newIndex}`;
                        // console.log(seatNoTemp[i].columnIndex)

                    }
                    // }
                    areasTemp[rowIndex + 1].seats = seatNoTemp;


                    break;

                }

            }


            Notify({
                message: STATUS_MESSAGE["ADD_SUCCESS"] + ` Ghế ${String.fromCharCode(row + 64)}${col}`,
                // height: 45,
                width: 300,
                minWidth: 300,
                type: "success",
                displayTime: 3500,
                animation: {
                    show: {
                        type: 'fade', duration: 400, from: 0, to: 1,
                    },
                    hide: { type: 'fade', duration: 40, to: 0 },
                },
            }, {
                position: "top right",
                direction: "down-stack",
            });

            // setLength(Math.max(...areasTemp.map(auditorim => auditorim.seats.length)))
            setAreas(areasTemp);
        } catch (error) {

        }
    }
    const handleAddMultiableRow = (rowAdd: string[]) => {
        const areasTemp = [...areas];
        const colsTemp: number[] = [...columns];
        const rowsTemp: number[] = [...rows];
        try {
            let rowDiff: string[] = rowAdd.filter(x => !areasTemp.some(y => {
                if (x.includes("0")) {
                    return y.physicalName === `${String.fromCharCode(parseInt(x) + 64)}0`

                }
                return y.physicalName === String.fromCharCode(parseInt(x) + 64)
            }));

            const rowDiffSorted = rowDiff.sort((a, b) => parseFloat(b) - parseFloat(a));

            for (let i = 0; i < rowDiffSorted.length; i++) {
                const row = rowDiffSorted[i];
                let physicalName = "";
                const seatNoTemp: SeatNoState[] = [];

                if (row.includes("0")) {
                    //#region review
                    physicalName = `${String.fromCharCode(parseInt(row) + 64)}0`;
                    const seatNo: SeatNoState = {
                        id: `${physicalName}`,
                        rowIndex: parseInt(row),
                        row: `${physicalName}`,
                        number: 0,
                        seatId: `${physicalName}`,
                        auditoriumId: filter?.auditoriumId,
                        status: false
                    };
                    seatNoTemp.push(seatNo);
                    const indexReviewAfter = areasTemp.findIndex(x => x.physicalName === String.fromCharCode(parseInt(row) + 64));
                    if (indexReviewAfter > -1) {
                        areasTemp.splice(indexReviewAfter + 1, 0, {
                            physicalName: physicalName,
                            seats: [seatNo]
                        } as AuditoriumModel);
                    }

                    //#endregion

                    //#region edit
                    const indexEditAfter = rowsTemp.findIndex(x => x === parseInt(row));
                    if (indexEditAfter > -1) {
                        rowsTemp.splice(indexEditAfter + 1, 0, parseFloat(`${parseInt(row)}.1`));
                    }

                    //#endregion
                } else {
                    //#region review
                    physicalName = String.fromCharCode(parseInt(row) + 64);
                    for (let j = 0; j < columns.length; j++) {
                        const col = columns[j];
                        const seatNo: SeatNoState = {
                            id: `${physicalName}${col}`,
                            number: col,
                            row: physicalName,
                            columnIndex: col,
                            rowIndex: parseInt(row),
                            seatId: `${physicalName}${col}`,
                            auditoriumId: filter?.auditoriumId,
                            status: false
                        };
                        seatNoTemp.push(seatNo);
                    }

                    areasTemp.push({
                        physicalName: physicalName,
                        seats: seatNoTemp
                    } as AuditoriumModel);
                    //#endregion

                    //#region edit
                    rowsTemp.push(parseInt(row));
                    //#endregion
                }
            }


            Notify({
                message: STATUS_MESSAGE["ADD_SUCCESS"] + ` Tất cả ghế ở cột ${rowDiff.join(", ")}`,
                // height: 45,
                width: 300,
                minWidth: 300,
                type: "success",
                displayTime: 3500,
                animation: {
                    show: {
                        type: 'fade', duration: 400, from: 0, to: 1,
                    },
                    hide: { type: 'fade', duration: 40, to: 0 },
                },
            }, {
                position: "top right",
                direction: "down-stack",
            });
            // setToast({
            //     visible: true,
            //     type: "success",
            //     message: STATUS_MESSAGE["DELETE_SUCCESS"] + ` Ghế ${String.fromCharCode(row + 64)}${col}`

            // });
            // setLength(Math.max(...areasTemp.map(auditorim => auditorim.seats.length)))
            console.log(areasTemp, "area temp")
            setColumns(colsTemp);
            setRows(rowsTemp.sort((a, b) => a - b));
            setAreas(areasTemp.sort((a, b) => a.physicalName.charCodeAt(0) - b.physicalName.charCodeAt(0)));
        } catch (error) {

        }
    }

    const handleRemoveMultiableRow = (rowDel: string[]) => {
        const areasTemp = [...areas];
        const rowsTemp: number[] = [...rows];



        rowDel.forEach(row => {
            let physicalName = "";

            if (row.includes(".1")) {
                physicalName = `${String.fromCharCode(parseInt(row) + 64)}0`;

            }
            else {
                physicalName = String.fromCharCode(parseInt(row) + 64);

            }
            const physicalIndexDel = areasTemp.findIndex(x => x.physicalName === physicalName);
            if (physicalIndexDel > -1) {
                areasTemp.splice(physicalIndexDel, 1);
            }

            const rowIndexDel = rowsTemp.findIndex(x => x.toString() === row);
            if (rowIndexDel > -1) {
                rowsTemp.splice(rowIndexDel, 1);
            }
        });



        setRows(rowsTemp);
        setAreas(areasTemp);
    }

    const handleSaveChanges = () => {
        const flattenedArray = Object.values([...areas]).flatMap(group => group.seats);
        const differences = findArrayDifferences(seatNoOrigirin, flattenedArray);
        console.log(seatNoOrigirin, flattenedArray, areas, differences)
        if(filter?.auditoriumId && token){
            SeatNoSaveChanage(filter?.auditoriumId.toString(), token, differences)
            .then((response) => {
                Notify({
                    message: STATUS_MESSAGE[response.data.message],
                    // height: 45,
                    width: 300,
                    minWidth: 300,
                    type: STATUS_RESPONSE[response.data.status],
                    displayTime: 3500,
                    animation: {
                        show: {
                            type: 'fade', duration: 400, from: 0, to: 1,
                        },
                        hide: { type: 'fade', duration: 40, to: 0 },
                    },
                }, {
                    position: "top right",
                    direction: "down-stack",
                });
            })

        }
    }


    return (
        <MainCard>

            {
                actSr && <SeatRangeAction
                    open={actSr.open}
                    onSubmit={(colRange, rowRange) => {
                        handleSeatRange(colRange, rowRange);
                    }}
                    handlClose={() => {
                        setActSr(defaultAction)
                    }}

                />
            }
            {
                actAc && <AddByColumnAction
                    open={actAc.open}
                    columns={columns}
                    onSubmit={(colAdd) => {
                        handleAddMultiableColumn(colAdd)
                    }}
                    handlClose={() => {
                        setActAc(defaultAction)
                    }}

                />
            }
            {
                actAr && <AddByRowAction
                    open={actAr.open}
                    rows={["1", "1.0", "2", "2.0", "3", "3.0", "4", "4.0", "5", "5.0", "6", "6.0", "7", "7.0", "8", "8.0", "9", "9.0", "10", "10.0", "11", "11.0"]}
                    onSubmit={(rowAdd) => {
                        handleAddMultiableRow(rowAdd)
                    }}
                    handlClose={() => {
                        setActAr(defaultAction)
                    }}

                />
            }
            {
                actDc && <DeleteByColumnAction
                    open={actDc.open}
                    columns={columns}
                    onSubmit={(colDel) => {
                        handleRemoveMultiableColumn(colDel)
                    }}
                    handlClose={() => {
                        setActDc(defaultAction)
                    }}

                />
            }
            {
                actDr && <DeleteByRowAction
                    open={actDr.open}
                    rows={rows.map(row => row.toString())}
                    onSubmit={(rowDel) => {
                        handleRemoveMultiableRow(rowDel)
                    }}
                    handlClose={() => {
                        setActDr(defaultAction)
                    }}

                />
            }
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
            <Paper elevation={1} square className='p-5 my-1'>
                <div className='flex flex-col items-center gap-2'>

                    <Grid container spacing={2}>
                        <Grid item xs={4} md={3}>
                            <DropdownWithDataGrid
                                id="movie-select"
                                value={filter.auditoriumId ?? null}
                                columns={auditoriumColumns}
                                placeholder="Chọn phòng chiếu phim ..."
                                // filter={props.payload}
                                name="id"
                                valueExpr={"id"}
                                apiUrl={"/api/Auditoriums/paging/admin"}
                                dataGridOnSelectionChanged={(e, newValue: any) => {
                                    handleChangeFilterInput({
                                        target: {
                                            name: "auditoriumId",
                                            value: newValue?.id ?? null,
                                        },
                                    })
                                }}
                                syncDataGridSelection={function (e): void {
                                    handleChangeFilterInput({
                                        target: {
                                            name: "auditoriumId",
                                            value: e?.value ?? null,
                                        },
                                    });
                                }}
                                gridBoxDisplayExpr={function (item: any): string {
                                    return item && `${item?.cinemaName} - ${item?.name}`;
                                }}

                            // disabled={props.action === ACTIONS.VIEW}
                            />
                        </Grid>
                    </Grid>



                    <Grid container rowSpacing={1} columnSpacing={{ xs: 0, }}>
                        <Grid item xs={4} md={"auto"}>
                            <Button icon color='blue'
                                disabled={!filter?.auditoriumId}
                                onClick={() => {
                                    setActSr({
                                        open: true,
                                        type: ""
                                    } as IAction)
                                }} labelPosition='left'>
                                <Icon name='arrows alternate horizontal' /> Chọn phạm vi
                            </Button>
                        </Grid>
                        {/*  */}
                        <Grid item xs={4} md={"auto"}>
                            <Button icon color='green'
                                disabled={!filter?.auditoriumId}
                                onClick={() => {
                                setActAc({
                                    open: true,
                                    type: ""
                                } as IAction)
                            }} labelPosition='left'>
                                <Icon name='add' /> Thêm theo cột
                            </Button>
                        </Grid>
                        {/*  */}
                        <Grid item xs={4} md={"auto"}>
                            <Button icon color='green' 
                                disabled={!filter?.auditoriumId}
                                onClick={() => {
                                setActAr({
                                    open: true,
                                    type: ""
                                } as IAction)
                            }} labelPosition='left'>
                                <Icon name='add' /> Thêm theo dòng
                            </Button>
                        </Grid>
                        {/*  */}
                        <Grid item xs={4} md={"auto"}>
                            <Button icon color='red'
                                disabled={!filter?.auditoriumId}
                                onClick={() => {
                                setActDc({
                                    open: true,
                                    type: ""
                                } as IAction)
                            }} labelPosition='left'>
                                <Icon name='delete' /> Xóa theo cột
                            </Button>
                        </Grid>
                        {/*  */}
                        <Grid item xs={4} md={"auto"}>
                            <Button icon color='red'
                                disabled={!filter?.auditoriumId}
                                onClick={() => {
                                setActDr({
                                    open: true,
                                    type: ""
                                } as IAction)
                            }} labelPosition='left'>
                                <Icon name='delete' /> Xóa theo dòng
                            </Button>
                        </Grid>
                    </Grid>

                </div>

            </Paper>
            <div style={{ width: '100%', overflowY: 'scroll', marginTop: "0.5rem" }}>
                <Tab className="" menu={{ secondary: true, pointing: true }} panes={[
                    {
                        menuItem: 'Chỉnh sửa',
                        render: () => <Tab.Pane className="bg-transparent" attached={false}>
                            <div className="flex flex-col gap-2">
                                <div>
                                    <Button icon color='facebook' onClick={handleSaveChanges} labelPosition='left'>
                                        <Icon name='save' /> Lưu thay đổi
                                    </Button>
                                </div>
                                <div className="  bg-gray-700 flex flex-col relative pb-10 pt-5 rounded overflow-scroll md:overflow-visible ">


                                    <div className="">
                                        {

                                            rows.length > 0 ? rows.map((row, rowIndex) => {
                                                return <div className="flex relative justify-center py-2" key={rowIndex}>

                                                    {
                                                        row.toString().includes(".1") ? <span className="w-8 h-8 mx-2 font-bold text-gray-700 bg-white rounded-lg text-center relative my-2 py-1 left-0">{`${String.fromCharCode(row + 64)}0`}</span>
                                                            : <span className="w-8 h-8 mx-2 font-bold text-gray-700 bg-white rounded-lg text-center relative my-2 py-1 left-0">{String.fromCharCode(row + 64)}</span>

                                                    }
                                                    <div className="flex flex-row relative " style={{ minWidth: `${(length + 3) * 37}px` }}>
                                                        <div className="relative cursor-pointer flex flex-row" >
                                                            {columns.map((col, colIndex) => {
                                                                const index = areas[rowIndex + 1]?.seats.findIndex(x => x?.columnIndex === col);
                                                                if (row.toString().includes(".1")) {
                                                                    return <div className="mx-4 h-7 w-7"></div>
                                                                }
                                                                // console.log( areas[rowIndex]?.seats, "areas[row]");

                                                                return <div className="relative">
                                                                    {index !== -1
                                                                        ? <Label as={Button} onClick={() => handleRemoveColumn(row, col, rowIndex, colIndex)} circular color={"red"} floating className="p-1">
                                                                            {"x"}
                                                                        </Label> : <Label as={Button} onClick={() => handleAddColumn(row, col, rowIndex, colIndex)} circular color={"green"} floating className="p-1">
                                                                            {"+"}
                                                                        </Label>}
                                                                    {<div
                                                                        key={colIndex}
                                                                        className={classNames("moon mx-4 font-semibold h-7 w-7 hover:bg-orange-400 hover:text-white rounded-lg py-1 text-center")}

                                                                        onClick={(event: React.MouseEvent<HTMLDivElement>) => { }} >{index !== -1 ? areas[rowIndex + 1]?.seats[index]?.number : 0} </div>

                                                                    }
                                                                </div>
                                                            })}
                                                        </div>


                                                    </div>
                                                    {
                                                        row.toString().includes(".1") ? <span className="w-8 h-8 mx-2 font-bold text-gray-700 bg-white rounded-lg text-center relative my-2 py-1 left-0">{`${String.fromCharCode(row + 64)}0`}</span>
                                                            : <span className="w-8 h-8 mx-2 font-bold text-gray-700 bg-white rounded-lg text-center relative my-2 py-1 left-0">{String.fromCharCode(row + 64)}</span>

                                                    }
                                                </div>
                                            }) : <Container className="text-center font-semibold text-white">Layout ghế chưa có.</Container>
                                        }
                                    </div>
                                </div>


                            </div>
                        </Tab.Pane>,
                    },
                    {
                        menuItem: 'Review',
                        render: () => <Tab.Pane attached={false}>
                            <>

                                <div className="  bg-gray-700 flex flex-col relative pb-10 pt-5 rounded overflow-scroll md:overflow-visible ">

                                    <div className="screen w-1/2 h-16 flex  mx-auto text-white font-semibold "><div className="flex mx-auto py-1">Màn hình</div></div>
                                    <div className="">
                                        {

                                            areas.length > 0 ? areas.map((seats, rowIndex) => (
                                                <div className="flex relative justify-center " key={rowIndex}>


                                                    <span className="w-8 h-8 font-bold text-gray-700 bg-white rounded-lg text-center relative my-2 py-1 left-0">{seats.physicalName}</span>


                                                    <div className="flex flex-row relative " style={{ width: `${(length + 3) * 37}px` }}>
                                                        <div className="relative cursor-pointer" >
                                                            {seats.seats.map((seat, colIndex) => {



                                                                return seat.number !== 0 && <div
                                                                    key={colIndex}
                                                                    className={classNames("moon font-semibold h-7 w-7 hover:bg-orange-400 hover:text-white rounded-lg py-1 text-center absolute")}
                                                                    style={{ transform: `translate(${(seat.columnIndex! - 0.7) * 100 + 20 + (seat.columnIndex! - 0) * 70}%, ${10}%)` }}
                                                                    onClick={(event: React.MouseEvent<HTMLDivElement>) => { }}>{seat.number}</div>
                                                            })}
                                                        </div>


                                                    </div>

                                                    <span className="w-8 h-8 py-1 font-bold bg-white rounded-lg text-gray-700 text-center my-2 relative right-0">
                                                        {seats.physicalName}
                                                    </span>


                                                </div>
                                            )) : <Container className="text-center font-semibold text-white">Layout ghế chưa có.</Container>
                                        }
                                    </div>
                                </div>




                            </>
                        </Tab.Pane>,
                    },]} />



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

export default AuditoriumManagement;