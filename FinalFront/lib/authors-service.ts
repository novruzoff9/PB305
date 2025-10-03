// Types for the API response
export interface Author {
  id: string;
  name: string;
  birthDate: string;
  isDeleted: boolean;
  deletedAt?: string;
  deletedBy?: string;
}

export interface ApiResponse<T> {
  data: T;
  isSuccess: boolean;
  statusCode: number;
  errors: string[] | null;
}

// Import auth service for headers
import { authService } from './auth-service';

// API service for authors
export const authorsService = {
  async getAuthors(): Promise<ApiResponse<Author[]>> {
    try {
      const headers = {
        'Content-Type': 'application/json',
        ...authService.getAuthHeaders()
      };

      const response = await fetch('http://localhost:5000/api/Author', {
        headers
      });
      
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      
      const data: ApiResponse<Author[]> = await response.json();
      return data;
    } catch (error) {
      console.error('Error fetching authors:', error);
      throw error;
    }
  },

  async getAuthorById(id: string): Promise<Author | null> {
    try {
      const response = await this.getAuthors();
      if (response.isSuccess) {
        return response.data.find(author => author.id === id) || null;
      }
      return null;
    } catch (error) {
      console.error('Error fetching author by id:', error);
      return null;
    }
  }
};