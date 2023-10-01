const defaultTheme = require('tailwindcss/defaultTheme')
const plugin = require('tailwindcss/plugin')

module.exports = {
    content: ['./src/**/*.js'],
    darkMode: 'media',
    theme: {
        extend: {
            fontSize: {
                md: '1.1rem',
                xxs: '.6rem',
            },
            fontFamily: {
                sans: ['Spiegel', ...defaultTheme.fontFamily.sans],
                heading: ['Beaufort', ...defaultTheme.fontFamily.sans],
            },
            backgroundImage: {
                'gray-pattern':
                    'linear-gradient(270deg, #333333 70%, #0f0f0f 30%)',
                'gray-reverse-pattern':
                    'linear-gradient(0deg, #333333 70%, #0f0f0f 30%)',
                'gray-curved-pattern':
                    'linear-gradient(160deg, #333333 70%, #0f0f0f 30%)',
                'red-pattern':
                    'linear-gradient(90deg, #66d2ff 20%, #37b2d1 20%, #37b2d1 80%, #66d2ff 80%)',
                'white-flat-pattern':
                    'linear-gradient(145deg, #ffffff 95%, #f9f9f9 5%)',
            },
            colors: {
                'hurricane-gold': '#d0a85c',
                'hurricane-light-gold': '#e7bc6d',
                'hurricane-dark-gold': '#ad8335',
                'hurricane-gray': '#333333',
                'hurricane-light-gray': '#444444',
                'hurricane-lighter-gray': '#555555',
                'hurricane-dark-gray': '#0f0f0f',
            },
            minWidth: {
                32: '8rem',
                36: '9rem',
                44: '11rem',
                56: '14rem',
                60: '15rem',
                72: '18rem',
                80: '20rem',
            },
            maxWidth: {
                '8xl': '88rem',
                '9xl': '96rem',
            },
            zIndex: {
                60: '60',
            },
            screens: {
                xs: '480px',
            },
            borderWidth: {
                3: '3px',
            },
        },
    },
    variants: {
        extend: {
            opacity: ['disabled'],
        },
    },
    plugins: [
        require('@tailwindcss/forms'),
        // add custom variant for expanding sidebar
        plugin(({ addVariant, e }) => {
            addVariant('sidebar-expanded', ({ modifySelectors, separator }) => {
                modifySelectors(
                    ({ className }) =>
                        `.sidebar-expanded .${e(
                            `sidebar-expanded${separator}${className}`,
                        )}`,
                )
            })
        }),
    ],
}
