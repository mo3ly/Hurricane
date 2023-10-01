import Link from 'next/link'
import { useAuth } from '@/hooks/auth'
import SeoDefault from '@/components/Seo/SeoDefault'
import ApplicationLogo from '@/components/Logos/ApplicationLogo'

export default function Home() {
    const { user } = useAuth({ middleware: 'guest' })

    return (
        <>
            <SeoDefault
                nameFirst={true}
                title="The ultimate guard for your server."
            />

            <div className="relative flex items-top justify-center min-h-screen bg-white sm:items-center sm:pt-0">
                <div className=" fixed top-0 right-0 px-6 py-">
                    {user ? (
                        <Link href="/dashboard">
                            <a className="ml-4 text-sm text-gray-700 underline">
                                Dashboard
                            </a>
                        </Link>
                    ) : (
                        <>
                            <Link href="/login">
                                <a className="text-sm text-gray-700 underline">
                                    Login
                                </a>
                            </Link>

                            <Link href="/register">
                                <a className="ml-4 text-sm text-gray-700 underline">
                                    Register
                                </a>
                            </Link>
                        </>
                    )}
                </div>

                <div className="max-w-6xl mx-auto sm:px-6 lg:px-8">
                    <div className="flex flex-col justify-center pt-8 sm:justify-start sm:pt-0">
                        {/* Logo */}
                        <ApplicationLogo
                            hideDesc={true}
                            logoBackground={true}
                            className="text-center mx-12"
                        />
                        <div className="bg-white p-3 my-5">
                            The informaion of the service will be displayed
                            here.
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}
