const InputLabel = ({ className, children, ...props }) => (
    <label
        className={`${className} peer-focus:font-medium absolute text-sm bg-white text-stone-500 duration-300 transform -translate-y-6 scale-75 top-3 origin-[0] peer-focus:left-0 peer-focus:text-hurricane-gold peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-placeholder-shown:left-2 peer-placeholder-shown:-z-10 peer-focus:scale-75 peer-focus:-translate-y-6 peer-focus:z-10`}
        {...props}>
        {children}
    </label>
)

export default InputLabel
