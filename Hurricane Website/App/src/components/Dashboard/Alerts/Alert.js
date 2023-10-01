import { useState } from 'react'
const Alert = ({ type = 'default', className, children }) => {
    const [open, setOpen] = useState(true)

    let colors = []

    switch (type) {
        case 'default':
            colors[0] = 'bg-gray-100'
            colors[1] = 'text-gray-700'
            colors[2] = 'bg-gray-100'
            colors[3] = 'text-gray-500'
            colors[4] = 'hover:bg-gray-200'
            break

        case 'info':
            colors[0] = 'bg-sky-100'
            colors[1] = 'text-sky-700'
            colors[2] = 'bg-sky-100'
            colors[3] = 'text-sky-500'
            colors[4] = 'hover:bg-sky-200'
            break

        case 'warning':
            colors[0] = 'bg-yellow-100'
            colors[1] = 'text-yellow-700'
            colors[2] = 'bg-yellow-100'
            colors[3] = 'text-yellow-500'
            colors[4] = 'hover:bg-yellow-200'
            break

        case 'success':
            colors[0] = 'bg-green-100'
            colors[1] = 'text-green-700'
            colors[2] = 'bg-green-100'
            colors[3] = 'text-green-500'
            colors[4] = 'hover:bg-green-200'
            break

        case 'danger':
            colors[0] = 'bg-red-100'
            colors[1] = 'text-red-700'
            colors[2] = 'bg-red-100'
            colors[3] = 'text-red-500'
            colors[4] = 'hover:bg-red-200'
            break
    }

    return (
        <>
            {open && (
                <div
                    className={`flex p-4 ${colors[0]} ${className}`}
                    role="alert">
                    <svg
                        className={`flex-shrink-0 w-5 h-5 ${colors[1]}`}
                        fill="currentColor"
                        viewBox="0 0 20 20"
                        xmlns="http://www.w3.org/2000/svg">
                        <path
                            fillRule="evenodd"
                            d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-7-4a1 1 0 11-2 0 1 1 0 012 0zM9 9a1 1 0 000 2v3a1 1 0 001 1h1a1 1 0 100-2v-3a1 1 0 00-1-1H9z"
                            clipRule="evenodd"></path>
                    </svg>
                    <div className={`ml-3 text-sm font-medium ${colors[1]}`}>
                        {children}
                    </div>
                    <button
                        onClick={() => setOpen(false)}
                        type="button"
                        className={`ml-auto -mx-1.5 -my-1.5 ${colors[3]} ${colors[4]} focus:ring-0 p-1.5 ${colors[5]} inline-flex h-8 w-8`}
                        aria-label="Close">
                        <span className="sr-only">Dismiss</span>
                        <svg
                            className="w-5 h-5"
                            fill="currentColor"
                            viewBox="0 0 20 20"
                            xmlns="http://www.w3.org/2000/svg">
                            <path
                                fillRule="evenodd"
                                d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"
                                clipRule="evenodd"></path>
                        </svg>
                    </button>
                </div>
            )}
        </>
    )
}

export default Alert
