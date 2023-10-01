import { useState } from 'react'

const SidebarLinkGroup = ({ children, activecondition }) => {
    const [open, setOpen] = useState(activecondition)

    const handleClick = () => {
        setOpen(!open)
    }

    return (
        <li
            className={`px-3 py-2 mb-0.5 last:mb-0  ${
                activecondition && 'duration-200 transition-colors bg-white'
            }`}>
            {children(handleClick, open)}
        </li>
    )
}

export default SidebarLinkGroup
