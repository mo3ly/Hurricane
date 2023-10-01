const AuthValidationErrors = ({ errors = [], ...props }) => (
    <>
        {errors.length > 0 && (
            <div {...props}>
                <ul className="mt-3 list-disc list-inside text-sm text-red-50 bg-red-600 p-3">
                    {errors.map(error => (
                        <li key={error}>{error}</li>
                    ))}
                </ul>
            </div>
        )}
    </>
)

export default AuthValidationErrors
