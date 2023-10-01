import React, { useState } from 'react'
import { Transition } from '@headlessui/react'

const TooltipInfo = ({ children, className, containerClassName, isDark }) => {
    const [infoOpen, setInfoOpen] = useState(false)

    return (
        <div
            className={`relative ${className}`}
            onMouseEnter={() => setInfoOpen(true)}
            onMouseLeave={() => setInfoOpen(false)}
            onFocus={() => setInfoOpen(true)}
            onBlur={() => setInfoOpen(false)}>
            <button
                className="block"
                aria-haspopup="true"
                aria-expanded={infoOpen}
                onClick={e => e.preventDefault()}>
                <svg
                    className={`w-4 h-4 fill-current  ${
                        isDark ? 'text-white' : 'text-hurricane-lighter-gray'
                    }`}
                    viewBox="0 0 16 16">
                    <path d="M8 0C3.6 0 0 3.6 0 8s3.6 8 8 8 8-3.6 8-8-3.6-8-8-8zm0 12c-.6 0-1-.4-1-1s.4-1 1-1 1 .4 1 1-.4 1-1 1zm1-3H7V4h2v5z" />
                </svg>
            </button>
            <div className="z-60 absolute bottom-full left-1/2 transform -translate-x-1/2">
                <Transition
                    show={infoOpen}
                    tag="div"
                    className={`bg-white border border-gray-200 p-3 shadow-md overflow-hidden mb-2 ${containerClassName}`}
                    enter="duration-200 ease-out"
                    enterFrom="opacity-0 scale-95"
                    enterTo="opacity-100 scale-100"
                    leave="duration-100 ease-in"
                    leaveFrom="opacity-100 scale-100"
                    leaveTo="opacity-0 scale-95">
                    {children}
                </Transition>
            </div>
        </div>
    )
}

export default TooltipInfo
