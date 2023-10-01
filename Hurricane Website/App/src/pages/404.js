import Link from 'next/link'
import SeoDefault from '@/components/Seo/SeoDefault'
import Logo from '@/components/Logos/Logo'
import Button from '@/components/Dashboard/Forms/Button'

const NotFoundPage = () => (
    <>
        <SeoDefault title="Page is not found" />

        <div className="relative flex justify-center min-h-screen content-center bg-white items-center pt-0">
            <div className="max-w-6xl mx-auto px-8">
                <div className="flex flex-col justify-center items-center text-center pt-0">
                    {/* Logo */}
                    <Link href="/">
                        <a>
                            <Logo
                                className={`h-24 mb-5 block  animate-hurricane text-center w-auto fill-current mx-auto text-black`}
                            />
                        </a>
                    </Link>
                    <div className="font-heading font-extrabold text-hurricane-dark-gray uppercase text-3xl md:text-4xl xxl:text-5xl italic tracking-wide animate-hurricane-text-up">
                        {process.env.NEXT_PUBLIC_NAME}
                    </div>

                    <div className="font-heading font-extrabold uppercase mt-3 mb-8 text-red-600 text-2xl md:text-3xl xxl:text-4xl tracking-wide animate-hurricane-text-down">
                        404 | page is not found!
                    </div>
                </div>

                <div className="text-center">
                    <Link href="/">
                        <Button>Return to home page</Button>
                    </Link>
                </div>
            </div>
        </div>
    </>
)

export default NotFoundPage
