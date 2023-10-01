import Logo from '@/components/Logos/Logo'
import Link from 'next/link'

const ApplicationLogo = ({
    hideDesc = false,
    logoBackground = false,
    ...props
}) => {
    return (
        <div {...props}>
            <Link href="/">
                <a>
                    <Logo
                        className={`${
                            logoBackground
                                ? 'h-50 -mb-36 opacity-5'
                                : 'h-24 mb-5'
                        } block  animate-hurricane text-center w-auto fill-current mx-auto text-black`}
                    />
                </a>
            </Link>
            <div className="uppercase italic font-semibold tracking-wider -mb-2 animate-hurricane-text-up">
                Your Ultimate Guard
            </div>
            <div className="font-heading font-extrabold text-hurricane-gold -drop-shadow uppercase md:text-6xl xxl:text-7xl text-5xl italic tracking-wide animate-hurricane-text-down">
                {process.env.NEXT_PUBLIC_NAME}
            </div>
            {!hideDesc && (
                <p className="text-sm mt-2 tracking-widest animate-hurricane-fade">
                    Enhance your server’s security level and bring the latest
                    in-game features to your clients
                </p>
            )}
        </div>
    )
}
export default ApplicationLogo
