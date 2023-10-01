import SeoDefault from '@/components/Seo/SeoDefault'
import Document, { Html, Head, Main, NextScript } from 'next/document'

class MyDocument extends Document {
    static async getInitialProps(ctx) {
        const initialProps = await Document.getInitialProps(ctx)
        return { ...initialProps }
    }

    render() {
        return (
            <Html>
                <Head>
                    <SeoDefault />

                    <link
                        href="//db.onlinewebfonts.com/c/b3a5566bf1f995a754d7c4f86b2e6779?family=Beaufort"
                        rel="stylesheet"
                        type="text/css"
                    />
                    <link
                        rel="preload"
                        href="/fonts/Spiegel/spiegel.ttf"
                        as="font"
                        crossOrigin=""
                    />
                </Head>
                <body className="antialiased">
                    <Main />
                    <NextScript />
                </body>
            </Html>
        )
    }
}

export default MyDocument
