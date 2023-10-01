import Head from 'next/head'
import 'tailwindcss/tailwind.css'
import '../styles/globals.css'

const App = ({ Component, pageProps }) => {
    return (
        <>
            <Head>
                <meta
                    name="viewport"
                    content="width=device-width, initial-scale=1.0"
                />
            </Head>
            <Component {...pageProps} />
        </>
    )
}

export default App
