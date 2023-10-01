import DashboardLayout from '@/components/Layouts/DashboardLayout'
import SeoDefault from '@/components/Seo/SeoDefault'

const Party = () => {
    return (
        <>
            <DashboardLayout isDark={false}>
                <SeoDefault title="Game Party" />

                <div className="text-black tracking-wide">Game - Party</div>
            </DashboardLayout>
        </>
    )
}

export default Party
