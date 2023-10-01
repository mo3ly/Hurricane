import TooltipInfo from '../Tooltips/TooltipInfo'

const Card = ({
    title,
    className,
    isDark = false,
    info,
    row = 1,
    children,
}) => {
    switch (row) {
        case 1:
            row = 'col-span-full'
            break
        case 2:
            row = 'col-span-full xl:col-span-6'
            break
        case 3:
            row = 'col-span-full xl:col-span-4'
            break
        case 4:
            row = 'flex flex-col col-span-full sm:col-span-6 xl:col-span-4'
            break
    }

    return (
        <div
            className={`${row} ${
                isDark
                    ? 'bg-hurricane-gray border-hurricane-dark-gray'
                    : 'bg-white border-gray-200'
            } border ${className}`}>
            {title && (
                <header
                    className={`px-5 py-4 border-b flex items-center ${
                        isDark
                            ? 'border-black border-opacity-30'
                            : 'border-gray-100'
                    }`}>
                    <h2
                        className={`font-semibold tracking-wider ${
                            isDark
                                ? 'text-hurricane-gold'
                                : 'text-hurricane-dark-gray'
                        }`}>
                        {title}
                    </h2>
                    {info && (
                        <TooltipInfo
                            className="ml-2"
                            containerClassName="min-w-80"
                            isDark={isDark}>
                            <div className="text-sm text-center">{info}</div>
                        </TooltipInfo>
                    )}
                </header>
            )}
            <div className="p-3">{children}</div>
        </div>
    )
}

export default Card
