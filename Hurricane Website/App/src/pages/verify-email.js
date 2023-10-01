import Logo from '@/components/Logos/Logo'
import AuthCard from '@/components/Auth/AuthCard'
import Button from '@/components/Buttons/Button'
import GuestLayout from '@/components/Layouts/BasicLayout'
import Link from 'next/link'
import { useAuth } from '@/hooks/auth'
import { useState } from 'react'
import SeoDefault from '@/components/Seo/SeoDefault'

const VerifyEmail = () => {
    const { logout, resendEmailVerification } = useAuth({
        middleware: 'auth',
    })

    const [status, setStatus] = useState(null)
    const [loading, setLoading] = useState(false)

    return (
        <GuestLayout>
            <AuthCard>
                <SeoDefault title={'verify your email'} />

                <div className="mb-4 text-sm text-gray-600">
                    Thanks for signing up! Before getting started, could you
                    verify your email address by clicking on the link we just
                    emailed to you? If you didn't receive the email, we will
                    gladly send you another.
                </div>

                {status === 'verification-link-sent' && (
                    <div className="mb-4 font-medium text-sm text-green-600">
                        A new verification link has been sent to the email
                        address you provided during registration.
                    </div>
                )}

                <div className="mt-4 flex items-center justify-between">
                    <Button
                        loading={loading}
                        onClick={() =>
                            resendEmailVerification({ setStatus, setLoading })
                        }>
                        Resend Verification Email
                    </Button>

                    <button
                        type="button"
                        className="underline text-sm text-gray-600 hover:text-gray-900"
                        onClick={logout}>
                        Logout
                    </button>
                </div>
            </AuthCard>
        </GuestLayout>
    )
}

export default VerifyEmail
