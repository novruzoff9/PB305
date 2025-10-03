"use client"

import Link from "next/link"
import { usePathname } from "next/navigation"
import { BookOpen, Users } from "lucide-react"
import { cn } from "@/lib/utils"

const navItems = [
  {
    title: "Authors",
    href: "/",
    icon: Users,
  },
  {
    title: "All Books",
    href: "/books",
    icon: BookOpen,
  },
]

export function Sidebar() {
  const pathname = usePathname()

  return (
    <aside className="fixed left-0 top-0 h-screen w-64 border-r border-border bg-background">
      <div className="flex h-full flex-col">
        <div className="border-b border-border p-6">
          <h2 className="text-xl font-bold">Literary Collection</h2>
        </div>

        <nav className="flex-1 space-y-1 p-4">
          {navItems.map((item) => {
            const Icon = item.icon
            const isActive = pathname === item.href

            return (
              <Link
                key={item.href}
                href={item.href}
                className={cn(
                  "flex items-center gap-3 rounded-lg px-3 py-2 text-sm font-medium transition-colors",
                  isActive
                    ? "bg-accent text-accent-foreground"
                    : "text-muted-foreground hover:bg-accent/50 hover:text-foreground",
                )}
              >
                <Icon className="h-5 w-5" />
                {item.title}
              </Link>
            )
          })}
        </nav>

        <div className="border-t border-border p-4">
          <Link href="/login">
            <button className="w-full rounded-lg border border-border px-4 py-2 text-sm font-medium hover:bg-accent transition-colors">
              Login
            </button>
          </Link>
        </div>
      </div>
    </aside>
  )
}
