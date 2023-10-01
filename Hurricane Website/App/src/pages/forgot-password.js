import Logo from '@/components/Logos/Logo'
import AuthCard from '@/components/Auth/AuthCard'
import AuthSessionStatus from '@/components/Auth/AuthSessionStatus'
import AuthValidationErrors from '@/components/Auth/AuthValidationErrors'
import Button from '@/components/Buttons/Button'
import GuestLayout from '@/components/Layouts/BasicLayout'
import Input from '@/components/Inputs/Input'
import Label from '@/components/Labels/Label'
import SeoDefault from '@/components/Seo/SeoDefault'
import Link from 'next/link'
import { useAuth } from '@/hooks/auth'
import { useState } from 'react'

const ForgotPassword = () => {
    const { forgotPassword } = useAuth({ middleware: 'guest' })

    const [email, setEmail] = useState('')
    const [errors, setErrors] = useState([])
    const [status, setStatus] = useState(null)
    const [loading, setLoading] = useState(false)

    const submitForm = event => {
        event.preventDefault()

        forgotPassword({ email, setLoading, setErrors, setStatus })
    }

    return (
        <GuestLayout>
            <SeoDefault title="Recover your password" />
            <AuthCard>
                <div className="mb-4 text-sm text-gray-600">
                    Forgot your password? No problem. Just let us know your
                    email address and we will email you a password reset link
                    that will allow you to choose a new one.
                </div>

                {/* Session Status */}
                <AuthSessionStatus className="mb-4" status={status} />

                {/* Validation Errors */}
                <AuthValidationErrors className="mb-4" errors={errors} />

                <form onSubmit={submitForm}>
                    {/* Email Address */}
                    <div>
                        <Label htmlFor="email">Email</Label>
                        <Input
                            id="email"
                            type="email"
                            name="email"
                            value={email}
                            className="block mt-1 w-full"
                            onChange={event => setEmail(event.target.value)}
                            required
                            autoFocus
                        />
                    </div>

                    <div className="flex items-center justify-end mt-4">
                        <Button loading={loading}>
                            Email Password Reset Link
                        </Button>
                    </div>
                </form>
            </AuthCard>
        </GuestLayout>
    )
}

export default ForgotPassword
