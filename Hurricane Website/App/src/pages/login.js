import AuthLayout from '@/components/Layouts/AuthLayout'
import AuthSessionStatus from '@/components/Auth/AuthSessionStatus'
import AuthValidationErrors from '@/components/Auth/AuthValidationErrors'
import Button from '@/components/Buttons/Button'
import SeoDefault from '@/components/Seo/SeoDefault'
import Input from '@/components/Inputs/Input'
import Label from '@/components/Labels/Label'
import Link from 'next/link'
import { useAuth } from '@/hooks/auth'
import { useEffect, useState } from 'react'
import { useRouter } from 'next/router'
import ApplicationLogo from '@/components/Logos/ApplicationLogo'

const Login = () => {
    const router = useRouter()

    const { login } = useAuth({
        middleware: 'guest',
        redirectIfAuthenticated: '/dashboard',
    })

    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')
    const [errors, setErrors] = useState([])
    const [status, setStatus] = useState(null)
    const [loading, setLoading] = useState(false)

    useEffect(() => {
        if (router.query.reset?.length > 0 && errors.length === 0) {
            setStatus(atob(router.query.reset))
        } else {
            setStatus(null)
        }
    })

    const submitForm = async event => {
        event.preventDefault()

        login({ email, password, setLoading, setErrors, setStatus })
    }

    return (
        <AuthLayout>
            <SeoDefault title="Login" />

            <div className=" min-h-screen flex flex-row">
                <div className="bg-white z-10 w-full max-h-screen overflow-y-auto md:w-1/2 sm:2/3 lg:w-1/2 xl:w-1/3 p-6">
                    {/* Logo */}
                    <ApplicationLogo className="text-center mx-4 sm:mx-12" />

                    <div className="border-b border-black border-opacity-25 py-4 mx-4 sm:mx-12"></div>

                    {/* Session Status */}
                    <AuthSessionStatus className="my-2 mx-12" status={status} />

                    {/* Validation Errors */}
                    <AuthValidationErrors
                        className="my mx-4 sm:mx-12"
                        errors={errors}
                    />

                    <form
                        onSubmit={submitForm}
                        className="my-6 mx-4 sm:mx-12 animate-hurricane-fade">
                        {/* Email Address */}
                        <div>
                            <Label htmlFor="email">Email</Label>

                            <Input
                                id="email"
                                type="email"
                                value={email}
                                className="block mt-1 w-full"
                                onChange={event => setEmail(event.target.value)}
                                required
                                autoFocus
                            />
                        </div>

                        {/* Password */}
                        <div className="mt-4">
                            <Label htmlFor="password">Password</Label>

                            <Input
                                id="password"
                                type="password"
                                value={password}
                                className="block mt-1 w-full"
                                onChange={event =>
                                    setPassword(event.target.value)
                                }
                                required
                                autoComplete="current-password"
                            />
                        </div>

                        {/* Remember Me */}
                        <div className="flex items-center content-center justify-between mt-4">
                            <div className="block mt-4">
                                <label
                                    htmlFor="remember_me"
                                    className="inline-flex items-center">
                                    <input
                                        id="remember_me"
                                        type="checkbox"
                                        name="remember"
                                        className=" hex-border text-hurricane-gold shadow-sm focus:border-hurricane-gold focus:ring focus:ring-hurricane-gold focus:ring-opacity-50"
                                    />

                                    <span className="ml-2 text-sm text-gray-600">
                                        Remember me
                                    </span>
                                </label>
                            </div>
                            <Link href="/forgot-password">
                                <a className="text-sm text-gray-600 hover:text-gray-600 mt-3">
                                    Forgot your password?
                                </a>
                            </Link>
                        </div>

                        <div className="flex items-center justify-between mt-4">
                            <Link href="/register">
                                <a className="underline text-sm text-gray-600 hover:text-gray-900">
                                    Create an account!
                                </a>
                            </Link>

                            <Button loading={loading}>Login</Button>
                        </div>
                    </form>
                </div>

                {/* Content */}
                <div className="w-2/3 md:1/2 sm:1/3 p-3 hidden lg:block z-10">
                    <div className="text-white tracking-wide"></div>
                </div>
            </div>
        </AuthLayout>
    )
}

export default Login
