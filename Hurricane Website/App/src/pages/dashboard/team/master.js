import DashboardLayout from '@/components/Layouts/DashboardLayout'
import SeoDefault from '@/components/Seo/SeoDefault'

const Master = () => {
    return (
        <>
            <DashboardLayout isDark={false}>
                <SeoDefault title="Team Master" />

                <div className="border-b border-stone-200 bg-hurricane-gray">
                    <ul className="flex flex-wrap -mb-px text-sm font-medium text-center text-stone-300">
                        <li className="mr-2">
                            <a
                                href="#"
                                className="inline-flex p-4 rounded-t-lg border-b-2 border-transparent hover:text-stone-400 hover:border-stone-300 group">
                                <svg
                                    className="mr-2 w-5 h-5 text-stone-200 group-hover:text-stone-100"
                                    fill="currentColor"
                                    viewBox="0 0 20 20"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <path
                                        fill-rule="evenodd"
                                        d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-6-3a2 2 0 11-4 0 2 2 0 014 0zm-2 4a5 5 0 00-4.546 2.916A5.986 5.986 0 0010 16a5.986 5.986 0 004.546-2.084A5 5 0 0010 11z"
                                        clip-rule="evenodd"></path>
                                </svg>
                                Profile
                            </a>
                        </li>
                        <li className="mr-2">
                            <a
                                href="#"
                                className="inline-flex p-4 text-hurricane-gold rounded-t-lg border-b-2 border-hurricane-gold active group"
                                aria-current="page">
                                <svg
                                    className="mr-2 w-5 h-5 text-hurricane-gold "
                                    fill="currentColor"
                                    viewBox="0 0 20 20"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <path d="M5 3a2 2 0 00-2 2v2a2 2 0 002 2h2a2 2 0 002-2V5a2 2 0 00-2-2H5zM5 11a2 2 0 00-2 2v2a2 2 0 002 2h2a2 2 0 002-2v-2a2 2 0 00-2-2H5zM11 5a2 2 0 012-2h2a2 2 0 012 2v2a2 2 0 01-2 2h-2a2 2 0 01-2-2V5zM11 13a2 2 0 012-2h2a2 2 0 012 2v2a2 2 0 01-2 2h-2a2 2 0 01-2-2v-2z"></path>
                                </svg>
                                Dashboard
                            </a>
                        </li>
                        <li className="mr-2">
                            <a
                                href="#"
                                className="inline-flex p-4 rounded-t-lg border-b-2 border-transparent hover:text-stone-400 hover:border-stone-300 group">
                                <svg
                                    className="mr-2 w-5 h-5 text-stone-200 group-hover:text-stone-100 "
                                    fill="currentColor"
                                    viewBox="0 0 20 20"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <path d="M5 4a1 1 0 00-2 0v7.268a2 2 0 000 3.464V16a1 1 0 102 0v-1.268a2 2 0 000-3.464V4zM11 4a1 1 0 10-2 0v1.268a2 2 0 000 3.464V16a1 1 0 102 0V8.732a2 2 0 000-3.464V4zM16 3a1 1 0 011 1v7.268a2 2 0 010 3.464V16a1 1 0 11-2 0v-1.268a2 2 0 010-3.464V4a1 1 0 011-1z"></path>
                                </svg>
                                Settings
                            </a>
                        </li>
                        <li className="mr-2">
                            <a
                                href="#"
                                className="inline-flex p-4 rounded-t-lg border-b-2 border-transparent hover:text-stone-400 hover:border-stone-300 group">
                                <svg
                                    className="mr-2 w-5 h-5 text-stone-200 group-hover:text-stone-100 "
                                    fill="currentColor"
                                    viewBox="0 0 20 20"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <path d="M9 2a1 1 0 000 2h2a1 1 0 100-2H9z"></path>
                                    <path
                                        fill-rule="evenodd"
                                        d="M4 5a2 2 0 012-2 3 3 0 003 3h2a3 3 0 003-3 2 2 0 012 2v11a2 2 0 01-2 2H6a2 2 0 01-2-2V5zm3 4a1 1 0 000 2h.01a1 1 0 100-2H7zm3 0a1 1 0 000 2h3a1 1 0 100-2h-3zm-3 4a1 1 0 100 2h.01a1 1 0 100-2H7zm3 0a1 1 0 100 2h3a1 1 0 100-2h-3z"
                                        clip-rule="evenodd"></path>
                                </svg>
                                Contacts
                            </a>
                        </li>
                        <li>
                            <a className="inline-block p-4 text-stone-200 rounded-t-lg cursor-not-allowed">
                                Disabled
                            </a>
                        </li>
                    </ul>
                </div>
            </DashboardLayout>
        </>
    )
}

export default Master
