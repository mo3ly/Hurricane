const Table = ({ columns, children }) => {
    return (
        <div className="overflow-x-auto">
            <table className="table-auto w-full">
                {/* Table header */}
                <thead className="text-xs uppercase text-stone-600  bg-gray-100 rounded-sm">
                    <tr>
                        {columns.map((column, i) => (
                            <th key={i} className="p-2">
                                <div
                                    className={`font-semibold ${
                                        i == 0 ? 'text-left' : 'text-center'
                                    }`}>
                                    {column}
                                </div>
                            </th>
                        ))}
                    </tr>
                </thead>
                {/* Table body */}
                <tbody className="text-sm font-medium divide-y divide-slate-100">
                    {children}
                </tbody>
            </table>
        </div>
    )
}

export default Table
