import React, { useState } from "react"
import { DropdownProps, Select } from "semantic-ui-react"

const SortOptions = [
    { key: '0', value: '0', text: 'Lược xem nhiều nhất' },
    { key: '1', value: '1', text: 'Đánh giá' },
]

interface IProps {
    sort: number,
    onSelectSort: (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => void
}

const SelectSort: React.FC<IProps> = ({ sort, onSelectSort }) => {

    return (
        <>
            <Select placeholder='Sắp xếp theo' options={SortOptions} onChange={onSelectSort} value={sort} className="bg-gray-700 text-white"/>

        </>
    )
}

export default SelectSort;