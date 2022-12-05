import React, { useEffect } from "react";
import { Button, Grid, Header, Input, Segment } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { incrementQuantityCombo, decrementQuantityCombo, GetCombosAsync } from "../../../slices/combos/comboSlice";




const ComboList: React.FC<{}> = () => {

    const dispatch = useAppDispatch();
    const { combos } = useAppSelector(state => state.combo)
    const  status  = useAppSelector(state => state.combo.status)

   
    useEffect(() => {
        if(status === ""){
            dispatch(GetCombosAsync());

        }
    }, [dispatch, status])
    return (
        <>
            <Segment className="bg-gray-700">
                <Header as="h3" dividing className="text-white uppercase">Chọn thức ăn</Header>
                <Grid className="bg-gray-600" textAlign="left" verticalAlign="middle" container>
                    <Grid.Column computer={4} className="text-white font-extrabold text-xl ">
                        Combo
                    </Grid.Column>

                    <Grid.Column textAlign="right" computer={3} className="text-white font-extrabold text-xl">
                        Giá
                    </Grid.Column>


                    <Grid.Column textAlign="right" computer={4} className="text-white font-extrabold text-xl">
                        Số lượng

                    </Grid.Column>

                    <Grid.Column computer={5} textAlign="right" className="text-white font-extrabold text-xl">
                        Tổng giá
                    </Grid.Column>

                </Grid>
                {combos && combos.map((combo, idx) => (
                    <Grid key={idx} className={idx % 2 !==0 ? "bg-gray-600" : ""} textAlign="left" verticalAlign="middle" container>
                        <Grid.Column computer={4} className="text-white">
                            {combo.name}
                        </Grid.Column>

                        <Grid.Column textAlign="right" computer={3} className="text-white">
                            {combo.price.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}đ
                        </Grid.Column>


                        <Grid.Column textAlign="right" computer={4}>
                            <div className="flex justify-end">

                                <Button className="m-0" icon='plus' onClick={() => { dispatch(incrementQuantityCombo({id: combo.id})) }}></Button>
                                <Input className=" w-14 px-1" value={combo!.quantity}/>
                                <Button icon='minus' onClick={() => { dispatch(decrementQuantityCombo({id: combo.id})) }} ></Button>
                            </div>

                        </Grid.Column>

                        <Grid.Column textAlign="right" computer={5} className="text-white">
                            {combo.total?.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}đ
                        </Grid.Column>

                    </Grid>
                ))}
            </Segment>
        </>
    )
}

export default ComboList;