"use client"

import Link from "next/link"
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from "@/components/ui/card"
import { Button } from "@/components/ui/button"
import { useEffect, useState } from "react"
import { authorsService, Author } from "@/lib/authors-service"

export default function HomePage() {
  const [authors, setAuthors] = useState<Author[]>([])
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    async function fetchAuthors() {
      try {
        setLoading(true)
        const response = await authorsService.getAuthors()
        
        if (response.isSuccess) {
          // Filter out deleted authors
          const activeAuthors = response.data.filter(author => !author.isDeleted)
          setAuthors(activeAuthors)
        } else {
          setError('Failed to fetch authors')
        }
      } catch (err) {
        setError('Error loading authors')
        console.error('Error:', err)
      } finally {
        setLoading(false)
      }
    }

    fetchAuthors()
  }, [])

  if (loading) {
    return (
      <div className="min-h-screen flex items-center justify-center">
        <div className="text-center">
          <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-gray-900 mx-auto mb-4"></div>
          <p className="text-lg">Loading authors...</p>
        </div>
      </div>
    )
  }

  if (error) {
    return (
      <div className="min-h-screen flex items-center justify-center">
        <div className="text-center">
          <h1 className="text-2xl font-bold mb-4 text-red-600">Error</h1>
          <p className="text-lg mb-4">{error}</p>
          <Button onClick={() => window.location.reload()}>Try Again</Button>
        </div>
      </div>
    )
  }

  return (
    <div className="min-h-screen">
      <main className="container mx-auto px-4 py-12">
        <div className="mb-12">
          <h2 className="text-5xl font-bold mb-4 text-balance">Discover great authors and their timeless works.</h2>
          <p className="text-xl text-muted-foreground max-w-2xl">
            Explore our curated collection of literary masters and dive into their most celebrated books.
          </p>
        </div>

        {authors.length === 0 ? (
          <div className="text-center py-12">
            <p className="text-xl text-muted-foreground">No authors found.</p>
          </div>
        ) : (
          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
            {authors.map((author) => (
              <Card key={author.id} className="overflow-hidden hover:border-accent transition-colors">
                <div className="aspect-square overflow-hidden bg-secondary">
                  <img
                    src="/placeholder.svg"
                    alt={author.name}
                    className="w-full h-full object-cover"
                  />
                </div>
                <CardHeader>
                  <CardTitle className="text-2xl">{author.name}</CardTitle>
                  <CardDescription className="text-muted-foreground">
                    Born: {new Date(author.birthDate).toLocaleDateString()}
                  </CardDescription>
                </CardHeader>
                <CardContent>
                  <p className="text-sm text-muted-foreground mb-4 leading-relaxed">
                    Click to explore the works of {author.name}.
                  </p>
                  <Link href={`/authors/${author.id}`}>
                    <Button className="w-full">View Books</Button>
                  </Link>
                </CardContent>
              </Card>
            ))}
          </div>
        )}
      </main>

      <footer className="border-t border-border mt-24">
        <div className="container mx-auto px-4 py-8">
          <p className="text-center text-sm text-muted-foreground">© 2025 Literary Collection. All rights reserved.</p>
        </div>
      </footer>
    </div>
  )
}
