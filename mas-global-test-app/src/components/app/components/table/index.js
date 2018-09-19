import React from 'react'

const Table = props => {
    const renderHeader = () => {
        const labels = Object.values(props.header);
        return <thead>
            <tr>
                {
                    labels.map((label, i) => {
                        return <th key={i}>{label}</th>
                    })
                }
            </tr>
        </thead>
    };


    const renderBody = () => {
        const keys = Object.keys(props.header);
        return <tbody>
            {
                props.data.map((data,j) => {
                    return <tr key={j}>
                        {
                            keys.map((key, i) => {
                                return <td key={i}>{data[key]}</td>
                            })
                        }
                    </tr>
                })
            }
        </tbody>
    }

    return (
        <table className="table table-hover">
            {renderHeader()}
            {renderBody()}
        </table>
    )
}

export default Table;