import DashboardLayout from '@/components/Layouts/DashboardLayout'
import SeoDefault from '@/components/Seo/SeoDefault'

const Academy = () => {
    return (
        <>
            <DashboardLayout isDark={false}>
                <SeoDefault title="Game academy" />

                <div className="text-black tracking-wide">Game - Academy</div>
            </DashboardLayout>
        </>
    )
}

export default Academy
