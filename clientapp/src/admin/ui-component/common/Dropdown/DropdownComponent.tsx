import React from "react";

import { Dropdown, DropdownProps } from 'semantic-ui-react';
import "./dropdown.css"
interface dataCountryOption {
    key: string,
    value: string,
    flag?: string,
    text: string
}

interface IDropdownProps {
    dataOption?: dataCountryOption[],
    inline?: boolean | undefined,
    onSelectChange?:  (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => void | undefined
}

const DropdownComponent: React.FC<IDropdownProps> = ({ dataOption, inline, onSelectChange}) => {


    return <>
        <Dropdown
            inline={inline}
            options={dataOption}
            defaultValue={dataOption![0].value}
            onChange={onSelectChange}
        />
    </>
}

export default DropdownComponent;