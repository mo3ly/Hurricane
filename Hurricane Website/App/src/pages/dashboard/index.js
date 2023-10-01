import Banner from '@/components/Dashboard/Banner/Banner'
import Card from '@/components/Dashboard/Cards/Card'
import Grid from '@/components/Dashboard/Grids/Grid'
import Table from '@/components/Dashboard/Tables/Table'
import DashboardLayout from '@/components/Layouts/DashboardLayout'
import SeoDefault from '@/components/Seo/SeoDefault'

const Dashboard = () => {
    return (
        <>
            <DashboardLayout isDark={false}>
                <SeoDefault title="Dashboard" />

                {/* Banner */}
                <Banner
                    title={'Welcome 👋'}
                    description={
                        'We would like to take you in a quiz tour to let you know understand our service:'
                    }
                />
                <Grid>
                    {/* Card */}
                    <Card title={'Suppliers'} row={1}>
                        <Table
                            columns={[
                                'Source',
                                'Visitors',
                                'Revenues',
                                'Sales',
                                'Conversion',
                            ]}>
                            {/* Row */}

                            {['1', '2', '3'].map(i => (
                                <tr>
                                    <td className="p-2">
                                        <div className="flex items-center">
                                            <svg
                                                className="shrink-0 mr-2 sm:mr-3"
                                                width="36"
                                                height="36"
                                                viewBox="0 0 36 36">
                                                <circle
                                                    fill="#24292E"
                                                    cx="18"
                                                    cy="18"
                                                    r="18"
                                                />
                                                <path
                                                    d="M18 10.2c-4.4 0-8 3.6-8 8 0 3.5 2.3 6.5 5.5 7.6.4.1.5-.2.5-.4V24c-2.2.5-2.7-1-2.7-1-.4-.9-.9-1.2-.9-1.2-.7-.5.1-.5.1-.5.8.1 1.2.8 1.2.8.7 1.3 1.9.9 2.3.7.1-.5.3-.9.5-1.1-1.8-.2-3.6-.9-3.6-4 0-.9.3-1.6.8-2.1-.1-.2-.4-1 .1-2.1 0 0 .7-.2 2.2.8.6-.2 1.3-.3 2-.3s1.4.1 2 .3c1.5-1 2.2-.8 2.2-.8.4 1.1.2 1.9.1 2.1.5.6.8 1.3.8 2.1 0 3.1-1.9 3.7-3.7 3.9.3.4.6.9.6 1.6v2.2c0 .2.1.5.6.4 3.2-1.1 5.5-4.1 5.5-7.6-.1-4.4-3.7-8-8.1-8z"
                                                    fill="#FFF"
                                                />
                                            </svg>
                                            <div className="text-slate-800">
                                                Github.com
                                            </div>
                                        </div>
                                    </td>
                                    <td className="p-2">
                                        <div className="text-center">2.4K</div>
                                    </td>
                                    <td className="p-2">
                                        <div className="text-center text-green-500">
                                            $3,877
                                        </div>
                                    </td>
                                    <td className="p-2">
                                        <div className="text-center">267</div>
                                    </td>
                                    <td className="p-2">
                                        <div className="text-center text-sky-500">
                                            4.7%
                                        </div>
                                    </td>
                                </tr>
                            ))}
                        </Table>
                    </Card>
                </Grid>
            </DashboardLayout>
        </>
    )
}

export default Dashboard
