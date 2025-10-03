import type React from "react"
import type { Metadata } from "next"
import { GeistSans } from "geist/font/sans"
import { GeistMono } from "geist/font/mono"
import { Analytics } from "@vercel/analytics/next"
import "./globals.css"
import { Sidebar } from "@/components/sidebar"
import { Header } from "@/components/header"
import { AuthProvider } from "@/contexts/auth-context"
import { Suspense } from "react"

export const metadata: Metadata = {
  title: "Literary Collection",
  description: "Explore authors and their books",
  generator: "v0.app",
}

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode
}>) {
  return (
    <html lang="en" className="dark">
      <body className={`font-sans ${GeistSans.variable} ${GeistMono.variable}`}>
        <AuthProvider>
          <Suspense fallback={<div>Loading...</div>}>
            <div className="flex h-screen">
              <Sidebar />
              <div className="flex-1 flex flex-col ml-64">
                <Header />
                <main className="flex-1 overflow-auto">{children}</main>
              </div>
            </div>
          </Suspense>
        </AuthProvider>
        <Analytics />
      </body>
    </html>
  )
}
