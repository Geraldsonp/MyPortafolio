/** @type {import('tailwindcss').Config} */
module.exports = {
	content: ["./Pages/**/*.{razor,cshtml}", "./Layout/**/*.{razor,cshtml}", "./Components/**/*.{razor,cshtml, css}"],
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
			},
			spacing: {
				'12': '1.5rem',
				'14': '2rem',
				'16': '2.5rem',
				'20': '3.5rem',
				'24': '4.5rem',
				'32': '7.5rem',
				'40': '9.5rem',
				'48': '11.5rem',
			  }
		}
	},
	plugins: [],
}
