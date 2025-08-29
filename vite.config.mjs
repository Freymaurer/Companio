import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import tailwindcss from '@tailwindcss/vite'
import pkg from './package.json'

export default defineConfig({
    define: {
        __APP_VERSION__: JSON.stringify(pkg.version),
        __APP_NAME__: JSON.stringify(pkg.displayName)
    },
    base: "./",
    plugins: [react(), tailwindcss()],
    root: "./src",
    build: {
        outDir: "../dist",
    }
})
