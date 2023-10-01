const Input = ({ disabled = false, className, ...props }) => (
    <input
        disabled={disabled}
        className={`${className}  hex-border text-black  border-0 focus:border-transparent focus:ring-0`}
        {...props}
    />
)
{
    /* border-hurricane-gold focus:border-hurricane-gold focus:ring focus:ring-hurricane-gold focus:ring-opacity-50 */
}

export default Input
