import { useEffect, useState } from 'react'
import { useAuth } from '@/hooks/auth'
import Sidebar from '@/components/Dashboard/SideBar/Sidebar'
import Header from '@/components/Dashboard/Header/Header'
import Footer from '@/components/Dashboard/Footer/Footer'
import { ToastContainer } from 'react-toastify'
import 'react-toastify/dist/ReactToastify.css'

const DashboardLayout = ({ isDark = true, children }) => {
    const { user } = useAuth({ middleware: 'auth' })

    const [sidebarOpen, setSidebarOpen] = useState(false)
    // add notifcation here with reactReducer

    return (
        <>
            <div className="h-screen relative flex flex-col bg-white">
                <div className="relative">
                    <img
                        className="absolute object-cover w-full h-full -z-0"
                        src={
                            isDark
                                ? '/images/wallpaper.png'
                                : '/images/wallpaper-white.png'
                        }
                    />

                    <div className="flex h-screen overflow-hidden">
                        {/* Sidebar */}
                        <Sidebar
                            sidebarOpen={sidebarOpen}
                            setSidebarOpen={setSidebarOpen}
                        />

                        {/* Content */}
                        <div className="relative flex flex-col flex-1 overflow-y-auto overflow-x-hidden z-10">
                            {/*  Dashboard header */}
                            <Header
                                user={user}
                                sidebarOpen={sidebarOpen}
                                setSidebarOpen={setSidebarOpen}
                            />

                            {/* Main content */}
                            {/* h-full max-h-screen  */}
                            <main className="flex flex-col flex-grow md:overflow-y-auto animate-hurricane-fade ">
                                <div className="px-4 sm:px-6 lg:px-8 py-8 w-full max-w-9xl mx-auto">
                                    {children}
                                </div>
                            </main>

                            {/* Footer */}
                            <Footer />
                        </div>
                    </div>
                </div>
                <ToastContainer />
            </div>
        </>
    )
}

export default DashboardLayout
