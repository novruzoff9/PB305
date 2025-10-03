import Link from "next/link"
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from "@/components/ui/card"
import { Button } from "@/components/ui/button"

const allBooks = [
  // Ernest Hemingway
  {
    id: 1,
    title: "The Old Man and the Sea",
    author: "Ernest Hemingway",
    authorId: "hemingway",
    year: 1952,
    genre: "Fiction",
  },
  {
    id: 2,
    title: "A Farewell to Arms",
    author: "Ernest Hemingway",
    authorId: "hemingway",
    year: 1929,
    genre: "War Fiction",
  },
  {
    id: 3,
    title: "For Whom the Bell Tolls",
    author: "Ernest Hemingway",
    authorId: "hemingway",
    year: 1940,
    genre: "War Fiction",
  },

  // Jane Austen
  { id: 4, title: "Pride and Prejudice", author: "Jane Austen", authorId: "austen", year: 1813, genre: "Romance" },
  { id: 5, title: "Sense and Sensibility", author: "Jane Austen", authorId: "austen", year: 1811, genre: "Romance" },
  { id: 6, title: "Emma", author: "Jane Austen", authorId: "austen", year: 1815, genre: "Romance" },

  // George Orwell
  { id: 7, title: "1984", author: "George Orwell", authorId: "orwell", year: 1949, genre: "Dystopian" },
  { id: 8, title: "Animal Farm", author: "George Orwell", authorId: "orwell", year: 1945, genre: "Political Satire" },
  { id: 9, title: "Homage to Catalonia", author: "George Orwell", authorId: "orwell", year: 1938, genre: "Memoir" },

  // Virginia Woolf
  { id: 10, title: "Mrs Dalloway", author: "Virginia Woolf", authorId: "woolf", year: 1925, genre: "Modernist" },
  { id: 11, title: "To the Lighthouse", author: "Virginia Woolf", authorId: "woolf", year: 1927, genre: "Modernist" },
  { id: 12, title: "Orlando", author: "Virginia Woolf", authorId: "woolf", year: 1928, genre: "Fantasy" },

  // F. Scott Fitzgerald
  {
    id: 13,
    title: "The Great Gatsby",
    author: "F. Scott Fitzgerald",
    authorId: "fitzgerald",
    year: 1925,
    genre: "Tragedy",
  },
  {
    id: 14,
    title: "Tender Is the Night",
    author: "F. Scott Fitzgerald",
    authorId: "fitzgerald",
    year: 1934,
    genre: "Fiction",
  },
  {
    id: 15,
    title: "This Side of Paradise",
    author: "F. Scott Fitzgerald",
    authorId: "fitzgerald",
    year: 1920,
    genre: "Fiction",
  },

  // Toni Morrison
  { id: 16, title: "Beloved", author: "Toni Morrison", authorId: "morrison", year: 1987, genre: "Historical Fiction" },
  { id: 17, title: "Song of Solomon", author: "Toni Morrison", authorId: "morrison", year: 1977, genre: "Fiction" },
  { id: 18, title: "The Bluest Eye", author: "Toni Morrison", authorId: "morrison", year: 1970, genre: "Fiction" },
]

export default function AllBooksPage() {
  return (
    <div className="min-h-screen">
      <main className="container mx-auto px-4 py-12">
        <div className="mb-12">
          <h1 className="text-5xl font-bold mb-4 text-balance">All Books</h1>
          <p className="text-xl text-muted-foreground max-w-2xl">
            Browse our complete collection of literary masterpieces from renowned authors.
          </p>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-6">
          {allBooks.map((book) => (
            <Card key={book.id} className="hover:border-accent transition-colors">
              <CardHeader>
                <CardTitle className="text-lg leading-tight">{book.title}</CardTitle>
                <CardDescription className="text-muted-foreground">
                  <Link href={`/authors/${book.authorId}`} className="hover:text-foreground transition-colors">
                    {book.author}
                  </Link>
                </CardDescription>
              </CardHeader>
              <CardContent>
                <div className="space-y-2 text-sm text-muted-foreground">
                  <p>Published: {book.year}</p>
                  <p>Genre: {book.genre}</p>
                </div>
                <Link href={`/authors/${book.authorId}`} className="mt-4 block">
                  <Button variant="outline" className="w-full bg-transparent">
                    View Author
                  </Button>
                </Link>
              </CardContent>
            </Card>
          ))}
        </div>
      </main>

      <footer className="border-t border-border mt-24">
        <div className="container mx-auto px-4 py-8">
          <p className="text-center text-sm text-muted-foreground">© 2025 Literary Collection. All rights reserved.</p>
        </div>
      </footer>
    </div>
  )
}
