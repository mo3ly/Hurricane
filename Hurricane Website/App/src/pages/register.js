import AuthLayout from '@/components/Layouts/AuthLayout'
import ApplicationLogo from '@/components/Logos/ApplicationLogo'
import SeoDefault from '@/components/Seo/SeoDefault'
import AuthValidationErrors from '@/components/Auth/AuthValidationErrors'
import Button from '@/components/Buttons/Button'
import Input from '@/components/Inputs/Input'
import Label from '@/components/Labels/Label'
import Link from 'next/link'
import { useAuth } from '@/hooks/auth'
import { useState } from 'react'

const Register = () => {
    const { register } = useAuth({
        middleware: 'guest',
        redirectIfAuthenticated: '/dashboard',
    })

    const [name, setName] = useState('')
    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')
    const [passwordConfirmation, setPasswordConfirmation] = useState('')
    const [errors, setErrors] = useState([])
    const [loading, setLoading] = useState(false)

    const submitForm = event => {
        event.preventDefault()

        register({
            name,
            email,
            password,
            password_confirmation: passwordConfirmation,
            setLoading,
            setErrors,
        })
    }

    return (
        <AuthLayout>
            <SeoDefault title="Register" />
            <div className="min-h-screen flex flex-row">
                <div className="bg-white z-10 w-full max-h-screen overflow-y-auto md:w-1/2 sm:2/3 lg:w-1/2 xl:w-1/3 p-6">
                    {/* Logo */}
                    <ApplicationLogo
                        logoBackground={true}
                        className="text-center mx-4 sm:mx-12"
                    />

                    <div className="border-b border-black border-opacity-25 py-4 mx-4 sm:mx-12"></div>

                    {/* Validation Errors */}
                    <AuthValidationErrors
                        className="my mx-4 sm:mx-12"
                        errors={errors}
                    />

                    <form
                        onSubmit={submitForm}
                        className="my-6 mx-4 sm:mx-12 animate-hurricane-fade">
                        {/* Name */}
                        <div>
                            <Label htmlFor="name">Name</Label>

                            <Input
                                id="name"
                                type="text"
                                value={name}
                                className="block mt-1 w-full"
                                onChange={event => setName(event.target.value)}
                                required
                                autoFocus
                            />
                        </div>

                        {/* Email Address */}
                        <div className="mt-4">
                            <Label htmlFor="email">Email</Label>

                            <Input
                                id="email"
                                type="email"
                                value={email}
                                className="block mt-1 w-full"
                                onChange={event => setEmail(event.target.value)}
                                required
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
                                autoComplete="new-password"
                            />
                        </div>

                        {/* Confirm Password */}
                        <div className="mt-4">
                            <Label htmlFor="passwordConfirmation">
                                Confirm Password
                            </Label>

                            <Input
                                id="passwordConfirmation"
                                type="password"
                                value={passwordConfirmation}
                                className="block mt-1 w-full"
                                onChange={event =>
                                    setPasswordConfirmation(event.target.value)
                                }
                                required
                            />
                        </div>

                        {/* Rules agreement */}
                        <div className="block mt-4">
                            <label
                                htmlFor="rules_agree"
                                className="inline-flex items-center">
                                <input
                                    id="rules_agree"
                                    type="checkbox"
                                    name="remember"
                                    className=" hex-border text-hurricane-gold shadow-sm focus:border-hurricane-gold focus:ring focus:ring-hurricane-gold focus:ring-opacity-50"
                                />

                                <span className="ml-2 text-sm text-gray-600">
                                    Agree with our rule?
                                </span>
                            </label>
                        </div>

                        <div className="flex items-center justify-between mt-4">
                            <Link href="/login">
                                <a className="underline text-sm text-gray-600 hover:text-gray-900">
                                    Already registered?
                                </a>
                            </Link>

                            <Button loading={loading}>Register</Button>
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

export default Register
