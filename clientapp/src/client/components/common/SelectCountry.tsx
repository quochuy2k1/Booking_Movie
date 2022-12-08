import React, { useState } from "react"
import { DropdownProps, Select } from "semantic-ui-react"

const countryOptions = [
    { key: 'af', value: 'Mỹ', text: 'Mỹ' },
    { key: 'ax', value: 'Úc', text: 'Úc' },
    { key: 'al', value: 'Trung Quốc', text: 'Trung Quốc' },
    { key: 'dz', value: 'Hàn Quốc', text: 'Hàn Quốc' },
    { key: 'as', value: 'Việt Nam', text: 'Việt Nam' },
]

interface IProps {
    onSelectCountry: (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => void
}

const SelectCountry: React.FC<IProps> = ({onSelectCountry }) => {


   
    return (
        <>
            <Select placeholder='Quốc gia' options={countryOptions} onChange={onSelectCountry}  className="bg-gray-700 text-white"/>

        </>
    )
}

export default SelectCountry;