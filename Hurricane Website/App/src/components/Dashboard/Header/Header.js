import { useState } from 'react'
import UserMenu from './UserMenu'
import { BiSearchAlt } from 'react-icons/bi'
import Notifications from './Notifications'
const Header = ({ user, sidebarOpen, setSidebarOpen }) => {
    const [searchModalOpen, setSearchModalOpen] = useState(false)

    return (
        <header className="sticky top-0 bg-white border-b border-gray-200 z-30">
            <div className="px-4 sm:px-6 lg:px-8">
                <div className="flex items-center justify-between h-16 -mb-px">
                    {/* Header: Left side */}
                    <div className="flex">
                        {/* Hamburger button */}
                        <button
                            className=" text-hurricane-gray hover:text-hurricane-dark-gray lg:hidden"
                            aria-controls="sidebar"
                            aria-expanded={sidebarOpen}
                            onClick={() => setSidebarOpen(!sidebarOpen)}>
                            <span className="sr-only">Open sidebar</span>
                            <svg
                                className="w-6 h-6 fill-current"
                                viewBox="0 0 24 24"
                                xmlns="http://www.w3.org/2000/svg">
                                <rect x="4" y="5" width="16" height="2" />
                                <rect x="4" y="11" width="16" height="2" />
                                <rect x="4" y="17" width="16" height="2" />
                            </svg>
                        </button>
                        <div className="font-heading font-extrabold text-hurricane-gray uppercase text-xl md:text-2xl xxl:text-4xl italic tracking-wide animate-hurricane-text-down ml-3 sm:ml-0">
                            {process.env.NEXT_PUBLIC_NAME}
                        </div>
                    </div>

                    {/* Header: Right side */}
                    <div className="flex items-center">
                        {/*
                        <button
                            className={`w-8 h-8 bg-gray-200 text-hurricane-gray flex items-center justify-center  transition duration-150 rounded-full ml-3 ${
                                searchModalOpen && 'bg-slate-200'
                            }`}
                            onClick={e => {
                                e.stopPropagation()
                                setSearchModalOpen(true)
                            }}
                            aria-controls="search-modal">
                            <span className="sr-only">Search</span>
                            <BiSearchAlt className="w-6 h-6" />
                        </button>
                        <SearchModal id="search-modal" searchId="search" modalOpen={searchModalOpen} setModalOpen={setSearchModalOpen} />
                        */}
                        <Notifications />
                        {/*  Divider */}
                        <hr className="w-px h-6 bg-slate-200 mx-3" />
                        <UserMenu user={user} />
                    </div>
                </div>
            </div>
        </header>
    )
}

export default Header
