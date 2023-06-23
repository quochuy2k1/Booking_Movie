import React, { useCallback, useEffect, useMemo } from "react";
import { useParams } from "react-router-dom";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { addClassSelect, GetSeatByAuditoriumAsync, loadClassSelect, removeClassSelectByIndex } from "../../../slices/auditoriums/AuditoriumSlice";
import "./auditorium.css"
import classNames from "classnames";
import { SeatNoState } from "../../../slices/seats/SeatSlice";
import { bookSeat, cancelBookSeat } from "../../../slices/seats/seatReservedSlice";

// interface AuditoriumPropsParams {
//     cinemaId: string
// }



const Auditorium: React.FC<{}> = () => {
    const { cinemaId } = useParams<string>();
    const dispatch = useAppDispatch();
    const { areas, length, status, classSelect } = useAppSelector(state => state.auditorium)
    const { auditoriumId } = useAppSelector(state => state.bookingClient.booking.screening)
    const { chooseTotal } = useAppSelector(state => state.ticket)

    // const onOpen = () => setOpen(true)

    const GetSeatsByAuditorium = useCallback(async () => {
        // const result = await dispatch(GetSeatByAuditoriumAsync(cinemaId));
        await dispatch(GetSeatByAuditoriumAsync(auditoriumId.toString()));

    }, [auditoriumId, dispatch])

    useEffect(() => {
        GetSeatsByAuditorium();
        // 
        let classSelectSessionStore: string | null = sessionStorage.getItem("class-select");
        // xoá seat đã chọn khi load lại trang
        if ((status === "" && classSelectSessionStore !== null) || (status === "idle" && chooseTotal === 0)) {
            sessionStorage.removeItem("class-select");
            classSelectSessionStore = null;
        }
        console.log(classSelectSessionStore, "class selected")
        // khi di chuyển đến tab khác sẽ lấy từ session storage
        // 
        if (classSelect.length === 0 && classSelectSessionStore !== null) {
            dispatch(loadClassSelect(JSON.parse(classSelectSessionStore) as SeatNoState[]));

        }

        console.log(classSelect, "class selected")
    }, [GetSeatsByAuditorium, dispatch, chooseTotal]);

    const selectSeat = useMemo(() => (e: React.MouseEvent<HTMLDivElement>, seat: SeatNoState): void => {
        const { columnIndex, rowIndex, status } = seat;
        // console.log(e, columnIndex, rowIndex)


        // khi length của class select khác 0 và nhỏ hơn hoặc bằng tổng ticket đã chọn và status của seat bằng false (chưa chọn)
        if (classSelect.length <= chooseTotal && chooseTotal !== 0 && !status) {
            // nếu bằng thì xoá phần tử đầu tiên
            if (classSelect.length === chooseTotal) {
                // const newState = [...classSelect];
                // newState.splice(0, 1);
                // setClassSelect(newState)
                dispatch(removeClassSelectByIndex({ index: 0 }))

                //
                const firstSeat = [...classSelect][0];
                dispatch(cancelBookSeat(firstSeat));

            }
            // thêm ghế
            // setClassSelect(pre => ([...pre, seat]))
            dispatch(addClassSelect(seat));
            // thêm đặt ghế
            dispatch(bookSeat(seat));
            // xoá khi nhấn vào lần 2
            const index = classSelect.findIndex(select => select.columnIndex === columnIndex && select.rowIndex === rowIndex)
            if (index !== -1) {
                // const newState = [...classSelect];
                // newState.splice(index, 1);
                // setClassSelect(newState)
                dispatch(removeClassSelectByIndex({ index: index }))
                dispatch(cancelBookSeat(seat));

            }
            console.log(index, "index")
            sessionStorage.setItem("class-select", JSON.stringify(classSelect));

        }
    }, [chooseTotal, classSelect, dispatch])


    return (
        <>

            <div className="  bg-gray-700 flex flex-col relative pb-10 pt-5 rounded overflow-scroll md:overflow-visible ">
                <div className="flex pb-5">
                    <div className="flex align-middle px-2"><div className="w-5 h-5 rounded-sm bg-zinc-800"></div><span className="px-1 text-white">Ghế có thể chọn</span></div>
                    <div className="flex align-middle px-2"><div className="w-5 h-5 rounded-sm bg-red-600"></div><span className="px-1 text-white">Ghế đã mua</span></div>
                    <div className="flex align-middle px-2"><div className="w-5 h-5 rounded-sm bg-orange-400"></div><span className="px-1 text-white">Ghế đã chọn</span></div>
                    <div className="flex align-middle px-2"><div className="w-5 h-5 rounded-sm bg-violet-800"></div><span className="px-1 text-white">Ghế không thể chọn</span></div>
                </div>
                <div className="screen w-1/2 h-16 flex  mx-auto text-white font-semibold "><div className="flex mx-auto py-1">Màn hình</div></div>
                <div className="">
                    {

                        status === "idle" && areas.map((seats, idx) => (
                            <div className="flex relative justify-center " key={idx}>

                                {
                                    !seats.physicalName.includes("0") ? <span className="w-8 h-8 font-bold text-gray-700 bg-white rounded-lg text-center relative my-2 py-1 left-0">{seats.physicalName}</span> : <span className="w-8 h-8"></span>

                                }
                                <div className="flex flex-row relative " style={{ width: `${(length + 3) * 37}px` }}>
                                    <div className="relative cursor-pointer" >
                                        {seats.seats.map((seat, idex) => {



                                            return seat.number !== 0 && <div
                                                key={idex}
                                                className={classNames("moon font-semibold h-7 w-7 hover:bg-orange-400 hover:text-white rounded-lg py-1 text-center absolute", { "bg-red-600 text-white cursor-not-allowed": seat.status }, { "bg-orange-400 text-white": (classSelect.findIndex(select => select.columnIndex === seat.columnIndex && select.rowIndex === seat.rowIndex) !== -1) })}
                                                style={{ transform: `translate(${(seat.columnIndex! - 0.7) * 100 + 20 + (seat.columnIndex! - 0) * 70}%, ${10}%)` }}
                                                onClick={(event: React.MouseEvent<HTMLDivElement>) => selectSeat(event, seat)}>{seat.number}</div>
                                        })}
                                    </div>


                                </div>
                                {
                                    !seats.physicalName.includes("0") ? (
                                        <span className="w-8 h-8 py-1 font-bold bg-white rounded-lg text-gray-700 text-center my-2 relative right-0">
                                            {seats.physicalName}
                                        </span>
                                    ) : (
                                        <span className="w-8 h-8"></span>
                                    )
                                }
                            </div>
                        ))
                    }
                </div>
            </div>


            {/* <Button icon labelPosition='left'
                onClick={() => {
                    const seat_selected = [...classSelect].sort(compare);
                    console.log(seat_selected)
                    for (let i = 0; i < seat_selected.length - 1; i++) {
                        if (seat_selected[i].rowIndex === seat_selected[i + 1].rowIndex
                            && Math.abs(seat_selected[i].columnIndex - seat_selected[i + 1].columnIndex) === 2) {
                            setOpen(true)
                            break;
                        }
                    }
                }}>
                <Icon name='arrow alternate circle right' />
                Kế tiếp
            </Button> */}

            {/* <Confirm
                content="Việc chọn vị trí ghế của bạn không được để trống 1 ghế ở bên trái, giữa hoặc bên phải trên cùng hàng ghế mà bạn vừa chọn."
                open={openNotification}
                confirmButton="Vâng"
                onConfirm={onClose}
                cancelButton={false}
                className="bg-gray-700 text-white text-lg"
                size="tiny"

            /> */}

        </>
    )
}

export default Auditorium;