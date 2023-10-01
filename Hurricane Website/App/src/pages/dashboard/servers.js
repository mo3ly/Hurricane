import DashboardLayout from '@/components/Layouts/DashboardLayout'
import SeoDefault from '@/components/Seo/SeoDefault'
import Card from '@/components/Dashboard/Cards/Card'
import Table from '@/components/Dashboard/Tables/Table'
import TableRow from '@/components/Dashboard/Tables/TableRow'
import Grid from '@/components/Dashboard/Grids/Grid'
import { FiPaperclip } from 'react-icons/fi'
const Servers = () => {
    return (
        <>
            <DashboardLayout isDark={false}>
                <SeoDefault title="Servers" />

                <Grid>
                    <Card title="Connections" row={2}>
                        <Table columns={['Id', 'Module', 'User Id']}>
                            {[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12].map(i => (
                                <TableRow>
                                    {[i, '2.4K', '$3,877'].map((item, i) => (
                                        <td className="p-2">
                                            <div
                                                className={`${
                                                    i == 0
                                                        ? 'text-left'
                                                        : 'text-center'
                                                }`}>
                                                {item}
                                            </div>
                                        </td>
                                    ))}
                                </TableRow>
                            ))}
                        </Table>
                    </Card>

                    {/* Downloads */}
                    <Card title="Downloads" row={2}>
                        <dl>
                            <div className="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                                <dt className="text-sm font-medium text-gray-500">
                                    Full name
                                </dt>
                                <dd className="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">
                                    Margot Foster
                                </dd>
                            </div>
                            <div className="bg-white px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                                <dt className="text-sm font-medium text-gray-500">
                                    Application for
                                </dt>
                                <dd className="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">
                                    Backend Developer
                                </dd>
                            </div>
                            <div className="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                                <dt className="text-sm font-medium text-gray-500">
                                    Email address
                                </dt>
                                <dd className="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">
                                    margotfoster@example.com
                                </dd>
                            </div>
                            <div className="bg-white px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                                <dt className="text-sm font-medium text-gray-500">
                                    Salary expectation
                                </dt>
                                <dd className="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">
                                    $120,000
                                </dd>
                            </div>
                            <div className="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                                <dt className="text-sm font-medium text-gray-500">
                                    About
                                </dt>
                                <dd className="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">
                                    Fugiat ipsum ipsum deserunt culpa aute sint
                                    do nostrud anim incididunt cillum culpa
                                    consequat. Excepteur qui ipsum aliquip
                                    consequat sint. Sit id mollit nulla mollit
                                    nostrud in ea officia proident. Irure
                                    nostrud pariatur mollit ad adipisicing
                                    reprehenderit deserunt qui eu.
                                </dd>
                            </div>
                            <div className="bg-white px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                                <dt className="text-sm font-medium text-gray-500">
                                    Attachments
                                </dt>
                                <dd className="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">
                                    <ul
                                        role="list"
                                        className="border border-gray-200 rounded-md divide-y divide-gray-200">
                                        <li className="pl-3 pr-4 py-3 flex items-center justify-between text-sm">
                                            <div className="w-0 flex-1 flex items-center">
                                                <FiPaperclip
                                                    className="flex-shrink-0 h-5 w-5 text-gray-400"
                                                    aria-hidden="true"
                                                />
                                                <span className="ml-2 flex-1 w-0 truncate">
                                                    resume_back_end_developer.pdf
                                                </span>
                                            </div>
                                            <div className="ml-4 flex-shrink-0">
                                                <a
                                                    href="#"
                                                    className="font-medium text-hurricane-dark-gold hover:text-hurricane-gold">
                                                    Download
                                                </a>
                                            </div>
                                        </li>
                                        <li className="pl-3 pr-4 py-3 flex items-center justify-between text-sm">
                                            <div className="w-0 flex-1 flex items-center">
                                                <FiPaperclip
                                                    className="flex-shrink-0 h-5 w-5 text-gray-400"
                                                    aria-hidden="true"
                                                />
                                                <span className="ml-2 flex-1 w-0 truncate">
                                                    coverletter_back_end_developer.pdf
                                                </span>
                                            </div>
                                            <div className="ml-4 flex-shrink-0">
                                                <a
                                                    href="#"
                                                    className="font-medium text-hurricane-dark-gold hover:text-hurricane-gold">
                                                    Download
                                                </a>
                                            </div>
                                        </li>
                                    </ul>
                                </dd>
                            </div>
                        </dl>
                    </Card>
                </Grid>
            </DashboardLayout>
        </>
    )
}

export default Servers
