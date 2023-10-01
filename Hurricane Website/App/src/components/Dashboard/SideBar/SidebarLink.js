import Link from 'next/link'

const SidebarLink = ({ currentRoute, route, title, icon, isNew = false }) => {
    return (
        <Link href={route}>
            <li
                className={`px-3 py-2 mb-0.5 last:mb-0 duration-200 cursor-pointer ${
                    currentRoute === route
                        ? 'bg-white hover:bg-hurricane-gold'
                        : 'hover:bg-hurricane-dark-gray hover:bg-opacity-50'
                }`}>
                <div className="flex items-center justify-between">
                    <div className={`block  truncate transition duration-150`}>
                        <div className="flex items-center cursor-pointer">
                            <>{icon}</>
                            <span
                                className={`text-base font-medium tracking-wider ml-3 lg:opacity-0 lg:sidebar-expanded:opacity-100 2xl:opacity-100 duration-200  ${
                                    currentRoute === route
                                        ? 'text-black'
                                        : 'text-white'
                                }`}>
                                {title}
                            </span>
                        </div>
                    </div>

                    {isNew && (
                        <div className="flex shrink-0 ml-2">
                            <div className="px-1 font-bold bg-hurricane-gold text-xs">
                                New
                            </div>
                        </div>
                    )}
                </div>
            </li>
        </Link>
    )
}

export default SidebarLink
