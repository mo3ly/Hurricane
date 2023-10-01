import React, { useState, useEffect, useRef } from 'react'
import { useRouter } from 'next/router'
import Link from 'next/link'
import Logo from '@/components/Logos/Logo'
import SidebarLink from './SidebarLink'
import SidebarLinkGroup from './SidebarLinkGroup'
import SidebarLinkDropDown from './SidebarLinkDropDown'
import SidebarSubLink from './SidebarSubLink'
import { GoDashboard, GoGear } from 'react-icons/go'
import { FiServer } from 'react-icons/fi'
import { MdOutlineGames } from 'react-icons/md'
import { BiShapeCircle } from 'react-icons/bi'
import { AiOutlineHistory } from 'react-icons/ai'

const Sidebar = ({ sidebarOpen, setSidebarOpen }) => {
    const router = useRouter()
    const trigger = useRef(null)
    const sidebar = useRef(null)

    const storedSidebarExpanded = null
    if (typeof window !== 'undefined')
        storedSidebarExpanded = localStorage.getItem('sidebar-expanded')

    const [sidebarExpanded, setSidebarExpanded] = useState(
        storedSidebarExpanded === null
            ? false
            : storedSidebarExpanded === 'true',
    )

    // close on click outside
    useEffect(() => {
        const clickHandler = ({ target }) => {
            if (!sidebar.current || !trigger.current) return
            if (
                !sidebarOpen ||
                sidebar.current.contains(target) ||
                trigger.current.contains(target)
            )
                return
            setSidebarOpen(false)
        }
        document.addEventListener('click', clickHandler)
        return () => document.removeEventListener('click', clickHandler)
    })

    // close if the esc key is pressed
    useEffect(() => {
        const keyHandler = ({ keyCode }) => {
            if (!sidebarOpen || keyCode !== 27) return
            setSidebarOpen(false)
        }
        document.addEventListener('keydown', keyHandler)
        return () => document.removeEventListener('keydown', keyHandler)
    })

    useEffect(() => {
        if (typeof window !== 'undefined') {
            localStorage.setItem('sidebar-expanded', sidebarExpanded)
        }
        if (sidebarExpanded) {
            document.querySelector('body').classList.add('sidebar-expanded')
        } else {
            document.querySelector('body').classList.remove('sidebar-expanded')
        }
    }, [sidebarExpanded])

    return (
        <div>
            {/* Sidebar backdrop (mobile only) */}
            <div
                className={`fixed inset-0 bg-hurricane-gray bg-opacity-50 z-40 lg:hidden lg:z-auto transition-opacity duration-200 ${
                    sidebarOpen
                        ? 'opacity-100'
                        : 'opacity-0 pointer-events-none'
                }`}
                aria-hidden="true"></div>

            {/* Sidebar */}
            <div
                id="sidebar"
                ref={sidebar}
                className={`bg-gray-curved-pattern overflow-x-hidden flex flex-col absolute z-40 left-0 top-0 lg:static lg:left-auto lg:top-auto lg:translate-x-0 transform h-screen overflow-y-scroll lg:overflow-y-auto no-scrollbar w-64 lg:w-20 lg:sidebar-expanded:!w-64 2xl:!w-64 shrink-0 p-4 transition-all duration-200 ease-in-out ${
                    sidebarOpen ? 'translate-x-0' : '-translate-x-64'
                }`}>
                {/* Sidebar header */}
                <div className="flex justify-between mb-10 pr-3 sm:px-2">
                    {/* Close button */}
                    <button
                        ref={trigger}
                        className="lg:hidden text-hurricane-gold hover:text-hurricane-gray"
                        onClick={() => setSidebarOpen(!sidebarOpen)}
                        aria-controls="sidebar"
                        aria-expanded={sidebarOpen}>
                        <span className="sr-only">Close sidebar</span>
                        <svg
                            className="w-6 h-6 fill-current"
                            viewBox="0 0 24 24"
                            xmlns="http://www.w3.org/2000/svg">
                            <path d="M10.7 18.7l1.4-1.4L7.8 13H20v-2H7.8l4.3-4.3-1.4-1.4L4 12z" />
                        </svg>
                    </button>
                    {/* Logo */}
                    <Link href="/" className="block">
                        <Logo className="w-14 h-14 fill-current text-white animate-hurricane " />
                    </Link>
                </div>

                {/* Links */}
                <div className="space-y-8">
                    {/* Pages group */}
                    <div>
                        <h3 className="text-sm tracking-wider uppercase text-hurricane-gold font-semibold pl-3">
                            <span
                                className="hidden lg:block lg:sidebar-expanded:hidden 2xl:hidden text-center w-6"
                                aria-hidden="true">
                                •••
                            </span>
                            <span className="lg:hidden lg:sidebar-expanded:block 2xl:block">
                                Pages
                            </span>
                        </h3>
                        <ul className="mt-3">
                            {/* Dashboard */}
                            <SidebarLink
                                title={'Dashboard'}
                                route={'/dashboard'}
                                currentRoute={router.pathname}
                                icon={
                                    <GoDashboard
                                        className={`${
                                            router.pathname === '/dashboard'
                                                ? 'text-black'
                                                : 'text-white'
                                        } mb-1 shrink-0  h-6 w-6`}
                                    />
                                }
                            />
                            {/* Servers */}
                            <SidebarLink
                                title={'Servers'}
                                route={'/dashboard/servers'}
                                currentRoute={router.pathname}
                                icon={
                                    <FiServer
                                        className={`${
                                            router.pathname ===
                                            '/dashboard/servers'
                                                ? 'text-black'
                                                : 'text-white'
                                        } mb-1 shrink-0  h-6 w-6`}
                                    />
                                }
                            />
                            {/* Connection */}
                            <SidebarLink
                                title={'Connections'}
                                route={'/dashboard/connections'}
                                currentRoute={router.pathname}
                                isNew
                                icon={
                                    <GoGear
                                        className={`${
                                            router.pathname ===
                                            '/dashboard/connections'
                                                ? 'text-black'
                                                : 'text-white'
                                        } mb-1 shrink-0  h-6 w-6`}
                                    />
                                }
                            />
                            {/* Game */}
                            <SidebarLinkGroup
                                activecondition={router.pathname.includes(
                                    '/game',
                                )}>
                                {(handleClick, open) => {
                                    return (
                                        <>
                                            <SidebarLinkDropDown
                                                icon={
                                                    <MdOutlineGames
                                                        className={`${
                                                            router.pathname.includes(
                                                                '/game',
                                                            )
                                                                ? 'text-black'
                                                                : 'text-white'
                                                        } mb-1 shrink-0  h-6 w-6`}
                                                    />
                                                }
                                                onClick={e => {
                                                    e.preventDefault()
                                                    sidebarExpanded
                                                        ? handleClick()
                                                        : setSidebarExpanded(
                                                              true,
                                                          )
                                                }}
                                                currentRoute={router.pathname}
                                                title={'Game'}
                                                route={'/game'}
                                                open={open}
                                            />
                                            <div className="lg:hidden lg:sidebar-expanded:block 2xl:block">
                                                <ul
                                                    className={`pl-9 mt-1 ${
                                                        !open && 'hidden'
                                                    }`}>
                                                    <SidebarSubLink
                                                        title={'Party'}
                                                        route={
                                                            '/dashboard/game/party'
                                                        }
                                                        currentRoute={
                                                            router.pathname
                                                        }
                                                    />
                                                    <SidebarSubLink
                                                        title={'Academy'}
                                                        route={
                                                            '/dashboard/game/academy'
                                                        }
                                                        currentRoute={
                                                            router.pathname
                                                        }
                                                    />
                                                </ul>
                                            </div>
                                        </>
                                    )
                                }}
                            </SidebarLinkGroup>
                            {/* team */}
                            <SidebarLinkGroup
                                activecondition={router.pathname.includes(
                                    '/team',
                                )}>
                                {(handleClick, open) => {
                                    return (
                                        <>
                                            <SidebarLinkDropDown
                                                icon={
                                                    <BiShapeCircle
                                                        className={`${
                                                            router.pathname.includes(
                                                                '/team',
                                                            )
                                                                ? 'text-black'
                                                                : 'text-white'
                                                        } mb-1 shrink-0  h-6 w-6`}
                                                    />
                                                }
                                                onClick={e => {
                                                    e.preventDefault()
                                                    sidebarExpanded
                                                        ? handleClick()
                                                        : setSidebarExpanded(
                                                              true,
                                                          )
                                                }}
                                                currentRoute={router.pathname}
                                                title={'Team'}
                                                route={'/team'}
                                                open={open}
                                            />
                                            <div className="lg:hidden lg:sidebar-expanded:block 2xl:block">
                                                <ul
                                                    className={`pl-9 mt-1 ${
                                                        !open && 'hidden'
                                                    }`}>
                                                    <SidebarSubLink
                                                        title={'Master'}
                                                        route={
                                                            '/dashboard/team/master'
                                                        }
                                                        currentRoute={
                                                            router.pathname
                                                        }
                                                    />
                                                    <SidebarSubLink
                                                        title={'Member'}
                                                        route={
                                                            '/dashboard/team/member'
                                                        }
                                                        currentRoute={
                                                            router.pathname
                                                        }
                                                    />
                                                </ul>
                                            </div>
                                        </>
                                    )
                                }}
                            </SidebarLinkGroup>
                        </ul>
                        {/* Logs group */}
                        <div className="mt-5">
                            <h3 className="text-sm tracking-wider uppercase text-hurricane-gold font-semibold pl-3">
                                <span
                                    className="hidden lg:block lg:sidebar-expanded:hidden 2xl:hidden text-center w-6"
                                    aria-hidden="true">
                                    •••
                                </span>
                                <span className="lg:hidden lg:sidebar-expanded:block 2xl:block">
                                    Logs
                                </span>
                            </h3>
                            <ul className="mt-3">
                                {/* Login history */}
                                <SidebarLink
                                    title={'Login history'}
                                    route={'/dashboard/logs/login'}
                                    currentRoute={router.pathname}
                                    icon={
                                        <AiOutlineHistory
                                            className={`${
                                                router.pathname ===
                                                '/dashboard/logs/login'
                                                    ? 'text-black'
                                                    : 'text-white'
                                            } mb-1 shrink-0  h-6 w-6`}
                                        />
                                    }
                                />
                            </ul>
                        </div>
                    </div>
                </div>

                {/* Expand / collapse button */}
                <div className="pt-3 hidden lg:inline-flex 2xl:hidden justify-end mt-auto">
                    <div className="px-3 py-2">
                        <button
                            onClick={() =>
                                setSidebarExpanded(!sidebarExpanded)
                            }>
                            <span className="sr-only">
                                Expand / collapse sidebar
                            </span>
                            <svg
                                className="w-6 h-6 fill-current sidebar-expanded:rotate-180"
                                viewBox="0 0 24 24">
                                <path
                                    className=" text-hurricane-gold"
                                    d="M19.586 11l-5-5L16 4.586 23.414 12 16 19.414 14.586 18l5-5H7v-2z"
                                />
                                <path
                                    className="text-hurricane-gold"
                                    d="M3 23H1V1h2z"
                                />
                            </svg>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Sidebar
