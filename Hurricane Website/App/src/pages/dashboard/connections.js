import Alert from '@/components/Dashboard/Alerts/alert'
import Banner from '@/components/Dashboard/Banner/Banner'
import Card from '@/components/Dashboard/Cards/Card'
import ComboBox from '@/components/Dashboard/Combobox/ComboBox'
import Button from '@/components/Dashboard/Forms/Button'
import Input from '@/components/Dashboard/Forms/Input'
import Label from '@/components/Dashboard/Forms/Label'
import InputLabel from '@/components/Dashboard/Forms/InputLabel'
import Grid from '@/components/Dashboard/Grids/Grid'
import Toggle from '@/components/Dashboard/Toggles/Toggle'
import DashboardLayout from '@/components/Layouts/DashboardLayout'
import SeoDefault from '@/components/Seo/SeoDefault'
import { toast } from 'react-toastify'
import InputInfo from '@/components/Dashboard/Forms/InputInfo'

const connections = () => {
    return (
        <>
            <DashboardLayout isDark={false}>
                <SeoDefault title="Connections" />

                <Banner title={'Connections'} />

                <Grid>
                    <Card
                        title={'SQL Connection'}
                        info={'Setup yor SQL settings here.'}
                        row={2}>
                        <form className="p-4">
                            {/* Alerts */}
                            <Alert type={'success'} className="mb-6">
                                A simple alert with an{' '}
                                <a
                                    href="#"
                                    className="font-semibold underline hover:text-gray-800 dark:hover:text-white">
                                    example link
                                </a>
                                . Give it a click if you like.
                            </Alert>
                            {/* End Alerts */}
                            <div className="grid xl:grid-cols-2 xl:gap-6">
                                <div className="relative z-0 w-full mb-6 group">
                                    <Input
                                        type="text"
                                        name="floating_first_name"
                                        id="floating_first_name"
                                        placeholder=" "
                                        required
                                    />
                                    <InputLabel htmlFor="floating_first_name">
                                        First name
                                    </InputLabel>
                                    <InputInfo>
                                        <span className="font-semibold">
                                            Oh, snapp!
                                        </span>{' '}
                                        Some info.
                                    </InputInfo>
                                </div>
                                <div className="relative z-0 w-full mb-6 group">
                                    <Input
                                        type="text"
                                        name="floating_last_name"
                                        id="floating_last_name"
                                        placeholder=" "
                                        required
                                    />
                                    <InputLabel htmlFor="floating_last_name">
                                        Last name
                                    </InputLabel>
                                </div>
                            </div>
                            <div className="relative z-0 w-full mb-6 group">
                                <Input
                                    type="email"
                                    name="email"
                                    placeholder=" "
                                    required
                                />
                                <InputLabel htmlFor="email">
                                    Email address
                                </InputLabel>
                                <InputInfo type="danger">
                                    <span className="font-semibold">
                                        Oh, snapp!
                                    </span>{' '}
                                    Some error message.
                                </InputInfo>
                            </div>
                            <div className="relative z-0 w-full mb-6 group">
                                <Input
                                    type="password"
                                    name="floating_password"
                                    id="floating_password"
                                    placeholder=" "
                                    required
                                />
                                <InputLabel htmlFor="floating_password">
                                    Password
                                </InputLabel>
                                <InputInfo type="success">
                                    <span className="font-semibold">
                                        Oh, snapp!
                                    </span>{' '}
                                    Some success message.
                                </InputInfo>
                            </div>
                            <Button
                                type="button"
                                onClick={e => toast.success('This is a toast')}>
                                Save
                            </Button>
                        </form>
                    </Card>

                    <Card
                        title={'Server Connection'}
                        info={'Setup yor Server connection settings here.'}
                        row={2}>
                        <div className="p-4">
                            <div className="mb-6">
                                <Label>Select your server</Label>
                                <ComboBox
                                    data={[
                                        { id: 1, name: 'Wade Cooper' },
                                        { id: 2, name: 'Arlene Mccoy' },
                                        { id: 3, name: 'Devon Webb' },
                                        { id: 4, name: 'Tom Cook' },
                                        { id: 5, name: 'Tanya Fox' },
                                        { id: 6, name: 'Hellen Schmidt' },
                                        { id: 8, name: 'Hellen Schmidt 1' },
                                        { id: 9, name: 'Hellen Schmidt 2' },
                                        { id: 10, name: 'Hellen Schmidt 3' },
                                        { id: 11, name: 'Hellen Schmidt 4' },
                                        { id: 12, name: 'Hellen Schmidt 5' },
                                    ]}
                                />
                            </div>

                            {/* Toggle */}
                            <div className="mb-6">
                                <Label>Disable captcha</Label>
                                <Toggle />
                            </div>

                            {/* Check boxes */}
                            <div className="mb-6">
                                <fieldset>
                                    <Label>Choose your features</Label>
                                    <div className="mt-4 space-y-4">
                                        <div className="flex items-start">
                                            <div className="flex items-center h-5">
                                                <input
                                                    id="comments"
                                                    name="comments"
                                                    type="checkbox"
                                                    className="focus:ring-0 h-4 w-4 text-hurricane-light-gray border-gray-300 rounded"
                                                />
                                            </div>
                                            <div className="ml-3 text-sm">
                                                <label
                                                    htmlFor="comments"
                                                    className="font-medium text-gray-700">
                                                    Comments
                                                </label>
                                                <p className="text-gray-500">
                                                    Get notified when someones
                                                    posts a comment on a
                                                    posting.
                                                </p>
                                            </div>
                                        </div>
                                        <div className="flex items-start">
                                            <div className="flex items-center h-5">
                                                <input
                                                    id="candidates"
                                                    name="candidates"
                                                    type="checkbox"
                                                    className="focus:ring-0 h-4 w-4 text-hurricane-light-gray border-gray-300 rounded"
                                                />
                                            </div>
                                            <div className="ml-3 text-sm">
                                                <label
                                                    htmlFor="candidates"
                                                    className="font-medium text-gray-700">
                                                    Candidates
                                                </label>
                                                <p className="text-gray-500">
                                                    Get notified when a
                                                    candidate applies for a job.
                                                </p>
                                            </div>
                                        </div>
                                        <div className="flex items-start">
                                            <div className="flex items-center h-5">
                                                <input
                                                    id="offers"
                                                    name="offers"
                                                    type="checkbox"
                                                    className="focus:ring-0 h-4 w-4 text-hurricane-light-gray border-gray-300 rounded"
                                                />
                                            </div>
                                            <div className="ml-3 text-sm">
                                                <label
                                                    htmlFor="offers"
                                                    className="font-medium text-gray-700">
                                                    Offers
                                                </label>
                                                <p className="text-gray-500">
                                                    Get notified when a
                                                    candidate accepts or rejects
                                                    an offer.
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </fieldset>
                            </div>

                            {/* Radio boxes */}
                            <div className="mb-6">
                                <fieldset>
                                    <Label>How to play?</Label>

                                    <div className="mt-4 space-y-4">
                                        <div className="flex items-center">
                                            <input
                                                id="push-everything"
                                                name="push-notifications"
                                                type="radio"
                                                className="focus:ring-0 h-4 w-4 text-hurricane-light-gray border-gray-300"
                                            />
                                            <label
                                                htmlFor="push-everything"
                                                className="ml-3 block text-sm font-medium text-gray-700">
                                                Everything
                                            </label>
                                        </div>
                                        <div className="flex items-center">
                                            <input
                                                id="push-email"
                                                name="push-notifications"
                                                type="radio"
                                                className="focus:ring-0 h-4 w-4 text-hurricane-light-gray border-gray-300"
                                            />
                                            <label
                                                htmlFor="push-email"
                                                className="ml-3 block text-sm font-medium text-gray-700">
                                                Same as email
                                            </label>
                                        </div>
                                        <div className="flex items-center">
                                            <input
                                                id="push-nothing"
                                                name="push-notifications"
                                                type="radio"
                                                className="focus:ring-0 h-4 w-4 text-hurricane-light-gray border-gray-300"
                                            />
                                            <label
                                                htmlFor="push-nothing"
                                                className="ml-3 block text-sm font-medium text-gray-700">
                                                No push notifications
                                            </label>
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </div>
                    </Card>
                </Grid>
            </DashboardLayout>
        </>
    )
}

export default connections
