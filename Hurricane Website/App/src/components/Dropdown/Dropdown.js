import React, { useState } from 'react'
import { Menu, Transition } from '@headlessui/react'

const Dropdown = ({
    align = 'right',
    width = 48,
    contentClasses = 'py-1 bg-white',
    trigger,
    children,
}) => {
    let alignmentClasses

    switch (width) {
        case '48':
            width = 'w-48'
            break
        case '52':
            width = 'w-52'
            break
        case '60':
            width = 'w-60'
            break
        case '64':
            width = 'w-64'
            break
    }

    switch (align) {
        case 'left':
            alignmentClasses = 'origin-top-left left-0'
            break
        case 'top':
            alignmentClasses = 'origin-top'
            break
        case 'right':
        default:
            alignmentClasses = 'origin-top-right right-0'
            break
    }

    const [open, setOpen] = useState(false)

    return (
        <Menu as="div" className="relative">
            {({ open }) => (
                <>
                    <Menu.Button as={React.Fragment}>{trigger}</Menu.Button>

                    <Transition
                        show={open}
                        enter="duration-200 ease-out"
                        enterFrom="opacity-0 scale-95"
                        enterTo="opacity-100 scale-100"
                        leave="duration-100 ease-in"
                        leaveFrom="opacity-100 scale-100"
                        leaveTo="opacity-0 scale-95">
                        <div
                            className={`absolute z-50 mt-2 ${width} shadow ${alignmentClasses}`}>
                            <Menu.Items
                                className={`focus:outline-none ring-1 ring-black ring-opacity-10 ${contentClasses}`}
                                static>
                                {children}
                            </Menu.Items>
                        </div>
                    </Transition>
                </>
            )}
        </Menu>
    )
}

export default Dropdown
