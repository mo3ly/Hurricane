const Label = ({ className, children, ...props }) => (
    <label
        className={`${className} block mb-2 text-sm font-semibold tracking-wide text-gray-900 dark:text-gray-300`}
        {...props}>
        {children}
    </label>
)

export default Label
