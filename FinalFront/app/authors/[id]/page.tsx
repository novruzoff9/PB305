"use client"

import Link from "next/link"
import { Button } from "@/components/ui/button"
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from "@/components/ui/card"
import { ArrowLeft } from "lucide-react"
import { useEffect, useState } from "react"
import { authorsService, Author } from "@/lib/authors-service"

export default function AuthorPage({ params }: { params: { id: string } }) {
  const [author, setAuthor] = useState<Author | null>(null)
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    async function fetchAuthor() {
      try {
        setLoading(true)
        const authorData = await authorsService.getAuthorById(params.id)
        
        if (authorData && !authorData.isDeleted) {
          setAuthor(authorData)
        } else {
          setError('Author not found')
        }
      } catch (err) {
        setError('Error loading author')
        console.error('Error:', err)
      } finally {
        setLoading(false)
      }
    }

    fetchAuthor()
  }, [params.id])

  if (loading) {
    return (
      <div className="min-h-screen flex items-center justify-center">
        <div className="text-center">
          <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-gray-900 mx-auto mb-4"></div>
          <p className="text-lg">Loading author...</p>
        </div>
      </div>
    )
  }

  if (error || !author) {
    return (
      <div className="min-h-screen flex items-center justify-center">
        <div className="text-center">
          <h1 className="text-4xl font-bold mb-4">Author not found</h1>
          <p className="text-lg mb-4 text-muted-foreground">{error}</p>
          <Link href="/">
            <Button>Return Home</Button>
          </Link>
        </div>
      </div>
    )
  }

  return (
    <div className="min-h-screen">
      <main className="container mx-auto px-4 py-12">
        <Link href="/">
          <Button variant="ghost" className="mb-8">
            <ArrowLeft className="mr-2 h-4 w-4" />
            Back to Authors
          </Button>
        </Link>

        <div className="mb-12">
          <h1 className="text-6xl font-bold mb-6 text-balance">{author.name}</h1>
          <p className="text-xl text-muted-foreground max-w-3xl leading-relaxed">
            Born: {new Date(author.birthDate).toLocaleDateString('en-US', {
              year: 'numeric',
              month: 'long',
              day: 'numeric'
            })}
          </p>
        </div>

        <div className="mb-8">
          <h2 className="text-3xl font-bold mb-6">Author Information</h2>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
          <Card className="hover:border-accent transition-colors">
            <CardHeader>
              <CardTitle className="text-2xl">Profile</CardTitle>
              <CardDescription className="text-muted-foreground">Author Details</CardDescription>
            </CardHeader>
            <CardContent>
              <div className="space-y-2">
                <p className="text-sm text-muted-foreground">
                  <strong>ID:</strong> {author.id}
                </p>
                <p className="text-sm text-muted-foreground">
                  <strong>Birth Date:</strong> {new Date(author.birthDate).toLocaleDateString()}
                </p>
                <p className="text-sm text-muted-foreground">
                  <strong>Status:</strong> {author.isDeleted ? 'Deleted' : 'Active'}
                </p>
              </div>
            </CardContent>
          </Card>

          <Card className="hover:border-accent transition-colors">
            <CardHeader>
              <CardTitle className="text-2xl">Biography</CardTitle>
              <CardDescription className="text-muted-foreground">About the Author</CardDescription>
            </CardHeader>
            <CardContent>
              <p className="text-sm text-muted-foreground leading-relaxed">
                Information about {author.name} and their literary contributions will be available soon.
              </p>
            </CardContent>
          </Card>
        </div>
      </main>
    </div>
  )
}
