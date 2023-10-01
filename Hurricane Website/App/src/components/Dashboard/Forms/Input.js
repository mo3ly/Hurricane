const Input = ({ disabled = false, className, ...props }) => (
    <input
        disabled={disabled}
        className={`${className}  block py-2.5  w-full text-sm text-hurricane-dark-gray bg-transparent border border-gray-200 appearance-none focus:outline-none focus:ring-0 focus:border-hurricane-gold peer`}
        {...props}
    />
)
{
    /* border-hurricane-gold focus:border-hurricane-gold focus:ring focus:ring-hurricane-gold focus:ring-opacity-50 */
}

export default Input
