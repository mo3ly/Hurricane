import Link from 'next/link'
import { BsRecordCircle } from 'react-icons/bs'

const SidebarSubLink = ({ title, route, currentRoute }) => {
    return (
        <li className="mb-1 last:mb-0">
            <Link
                href={route}
                className="block  transition duration-150 truncate">
                <span
                    className={`cursor-pointer text-sm inline-flex font-medium lg:opacity-0 lg:sidebar-expanded:opacity-100 2xl:opacity-100 duration-200 ${
                        currentRoute === route
                            ? 'text-hurricane-dark-gray font-bold'
                            : 'text-neutral-500 hover:text-hurricane-gold'
                    }`}>
                    <BsRecordCircle className="h-3 w-3 mt-1 mr-2" /> {title}
                </span>
            </Link>
        </li>
    )
}
export default SidebarSubLink
