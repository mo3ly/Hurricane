import Link from 'next/link'

const SidebarLinkDropDown = ({
    currentRoute,
    onClick,
    route,
    title,
    open,
    icon,
}) => {
    return (
        <a
            href="#"
            className={`block text-slate-200 hover:text-white truncate transition duration-150 ${
                currentRoute.includes(route) && 'hover:text-slate-200'
            }`}
            onClick={onClick}>
            <div className="flex items-center justify-between">
                <div className="flex items-center">
                    {icon}
                    <span
                        className={`text-base font-medium tracking-wider ml-3 lg:opacity-0 lg:sidebar-expanded:opacity-100 2xl:opacity-100 duration-200  ${
                            currentRoute.includes(route)
                                ? 'text-black'
                                : 'text-white'
                        }`}>
                        {title}
                    </span>
                </div>
                {/* Icon */}
                <div className="flex shrink-0 ml-2">
                    <svg
                        className={`w-3 h-3 shrink-0 ml-1 fill-current  transform duration-100 ${
                            open ? ' rotate-180' : 'rotate-0'
                        } ${
                            currentRoute.includes(route)
                                ? 'text-black'
                                : 'text-white'
                        }`}
                        viewBox="0 0 12 12">
                        <path d="M5.9 11.4L.5 6l1.4-1.4 4 4 4-4L11.3 6z" />
                    </svg>
                </div>
            </div>
        </a>
    )
}

export default SidebarLinkDropDown
