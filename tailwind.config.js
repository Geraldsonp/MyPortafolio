/** @type {import('tailwindcss').Config} */
module.exports = {
	content: ["./Pages/*.{razor,cshtml}","./Pages/**/*.{razor,cshtml}", "./Layout/**/*.{razor,cshtml}", "./node_modules/flowbite/**/*.js"],
	plugins: [
		require('flowbite/plugin')
	],
	theme: {
		extend: {
			colors: {
				"primary": "#1e1b4b"
			}
		}
	}
}
