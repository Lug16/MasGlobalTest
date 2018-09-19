import React from 'react'

const Input = props => {
    return (
        <input
            className={`${props.className}`}
            onChange={props.onChange}
            placeholder={props.placeholder}
            type={props.type}
            value={props.value} />
    )
}

export default Input;