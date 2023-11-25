/** @type {import('tailwindcss').Config} */
module.exports = {
	content: ["./Pages/**/*.{razor,cshtml}", "./Layout/**/*.{razor,cshtml}", "./Components/**/*.{razor,cshtml}"],
	theme: {
		extend: {
			colors: {
				'BG1': '#292F36',
				'BG2': '#1A1E23',
				'Brand1': '#12F7D6',
				'Brand2': '#98FAE',
				'Gray': '#43454D',
				'White': '#FFFFFF',
				'HTML': '#E54F26',
				'CSS': '#0C73B8',
				'JS': '#E7A020',
				'React': '#28A9E0'
			},
			fontFamily: {
				'IBM': '"IBM Plex Mono", monospace',
				'Ubuntu': 'Ubuntu, sans- serif'
			}
		}
	},
	plugins: [],
}
