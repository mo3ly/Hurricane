const AuthLayout = ({ children }) => {
    return (
        <>
            <div className="min-h-screen relative flex flex-col bg-neutral-800">
                <div className="relative">
                    <img
                        className="absolute object-cover w-full h-full -z-0"
                        src={'/images/wallpaper.png'}
                    />
                    {children}
                </div>
            </div>
        </>
    )
}

export default AuthLayout
