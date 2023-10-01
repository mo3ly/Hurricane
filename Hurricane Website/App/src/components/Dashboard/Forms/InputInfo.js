const InputInfo = ({ className, type = 'default', children, ...props }) => {
    let color

    switch (type) {
        case 'default':
            color = 'text-hurricane-dark-gray'
            break
        case 'info':
            color = 'text-sky-600'
            break
        case 'warning':
            color = 'text-yellow-600'
            break
        case 'success':
            color = 'text-green-600'
            break
        case 'danger':
            color = 'text-red-600'
            break
    }

    return (
        <p className={`${className} mt-2 ${color} text-xs`} {...props}>
            {children}
        </p>
    )
}

export default InputInfo
