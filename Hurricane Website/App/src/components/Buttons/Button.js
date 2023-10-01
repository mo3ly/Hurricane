import { AiOutlineLoading3Quarters } from 'react-icons/ai'

const Button = ({
    children,
    type = 'submit',
    loading = false,
    disabled = false,
    className,
    ...props
}) => (
    <div className="hex-border p-1">
        <button
            disabled={loading || disabled}
            type={type}
            className={`
                ${className} 
                inline-flex hex-bg-2 items-center justify-center min-w-32 px-4 py-1 bg-gray-pattern hover:translate-x-1  active:bg-gray-900 border border-transparent 
                text-base text-white uppercase tracking-widest focus:outline-none disabled:opacity-25 transition ease-in-out duration-75 
                ${loading && 'cursor-not-allowed opacity-50'}
            `}
            {...props}>
            {loading ? (
                <div className="inline-flex">
                    loading &nbsp;
                    <AiOutlineLoading3Quarters className="animate-spin mt-1" />
                </div>
            ) : (
                children
            )}
        </button>
    </div>
)

export default Button
