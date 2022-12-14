import React from "react";

import { Dropdown, DropdownProps } from 'semantic-ui-react';
import "./dropdown.css"
export interface dataDropdownOption {
    key: string | number,
    value: string | number | boolean,
    flag?: string,
    text: string
}

interface IDropdownProps {
    dataOption?: dataDropdownOption[],
    inline?: boolean | undefined,
    selection?: boolean,
    search?: boolean,
    multiple?: boolean,
    loading?: boolean,
    placeholder?: string,
    defaultValue?:  string | number | boolean | (string | number | boolean)[] | undefined,
    onSelectChange?:  (e: React.SyntheticEvent<HTMLElement>, data: DropdownProps) => void | undefined
}

const DropdownComponent: React.FC<IDropdownProps> = ({ dataOption, inline, selection, search, multiple, loading, defaultValue, placeholder, onSelectChange}) => {
    console.log(dataOption, "dât option", defaultValue, "default value dropdown component")

    return <>
        <Dropdown
            inline={inline}
            loading={loading}
            options={dataOption}
            multiple={multiple}
            selection={selection}
            search={search}
            clearable
            labeled
            fluid
            placeholder={placeholder}
            defaultValue={defaultValue}
            onChange={onSelectChange}
        />
    </>
}

export default DropdownComponent;