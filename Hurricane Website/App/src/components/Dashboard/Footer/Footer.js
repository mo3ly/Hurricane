const Footer = ({}) => {
    return (
        <div className="w-full bg-white text-hurricane-dark-gray border-t tracking-wide border-gray-200 px-4 sm:px-6 lg:px-8 py-2 text-sm">
            Copyright ©
            <span className="px-1 uppercase font-heading italic">
                {process.env.NEXT_PUBLIC_NAME}
            </span>
            &nbsp;2022 — Powered by Exoria
        </div>
    )
}

export default Footer
