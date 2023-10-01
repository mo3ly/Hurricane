import Head from 'next/head'
// TODO:
// fill these with the correct data
const SeoDefault = ({ nameFirst = false, title }) => {
    return (
        <Head>
            <title>
                {title && !nameFirst ? title + ' — ' : ''}
                {process.env.NEXT_PUBLIC_NAME}
                {title && nameFirst ? ' | ' + title : ''}
            </title>

            <meta name="application-name" content="Hurricane" />
            <meta name="apple-mobile-web-app-capable" content="yes" />
            <meta
                name="apple-mobile-web-app-status-bar-style"
                content="default"
            />
            <meta name="apple-mobile-web-app-title" content="Hurricane" />
            <meta name="description" content="Best Hurricane in the world" />
            <meta name="format-detection" content="telephone=no" />
            <meta name="mobile-web-app-capable" content="yes" />
            <meta
                name="msapplication-config"
                content="/icons/browserconfig.xml"
            />
            <meta name="msapplication-TileColor" content="#ffffff" />
            <meta name="msapplication-tap-highlight" content="no" />
            <meta name="theme-color" content="#ffffff" />

            <link rel="apple-touch-icon" href="/icons/touch-icon-iphone.png" />
            <link
                rel="apple-touch-icon"
                sizes="152x152"
                href="/icons/touch-icon-ipad.png"
            />
            <link
                rel="apple-touch-icon"
                sizes="180x180"
                href="/icons/touch-icon-iphone-retina.png"
            />
            <link
                rel="apple-touch-icon"
                sizes="167x167"
                href="/icons/touch-icon-ipad-retina.png"
            />

            <link
                rel="icon"
                type="image/png"
                sizes="32x32"
                href="/icons/favicon-32x32.png"
            />
            <link
                rel="icon"
                type="image/png"
                sizes="16x16"
                href="/icons/favicon-16x16.png"
            />
            <link rel="manifest" href="/manifest.json" />
            <link
                rel="mask-icon"
                href="/icons/safari-pinned-tab.svg"
                color="#ffffff"
            />
            <link rel="shortcut icon" href="/favicon.ico" />

            <meta name="twitter:card" content="summary" />
            <meta name="twitter:url" content="https://yourdomain.com" />
            <meta name="twitter:title" content="Hurricane" />
            <meta
                name="twitter:description"
                content="Best Hurricane in the world"
            />
            <meta
                name="twitter:image"
                content="https://yourdomain.com/icons/android-chrome-192x192.png"
            />
            <meta name="twitter:creator" content="@DavidWShadow" />
            <meta property="og:type" content="website" />
            <meta property="og:title" content="Hurricane" />
            <meta
                property="og:description"
                content="Best Hurricane in the world"
            />
            <meta property="og:site_name" content="Hurricane" />
            <meta property="og:url" content="https://yourdomain.com" />
            <meta
                property="og:image"
                content="https://yourdomain.com/icons/apple-touch-icon.png"
            />
        </Head>
    )
}

export default SeoDefault
