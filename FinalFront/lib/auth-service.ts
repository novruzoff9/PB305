// Types for the authentication API
export interface LoginRequest {
  email: string;
  password: string;
  rememberMe: boolean;
}

export interface User {
  id: string;
  firstName: string;
  lastName: string;
  email: string;
  userName: string;
  createdAt: string;
  updatedAt: string | null;
}

export interface LoginResponse {
  token: string;
  user: User;
  expiresAt: string;
}

export interface ApiResponse<T> {
  data: T;
  isSuccess: boolean;
  statusCode: number;
  errors: string[] | null;
}

// Cookie management utilities
export const cookies = {
  set: (name: string, value: string, days: number = 7) => {
    const expires = new Date();
    expires.setTime(expires.getTime() + days * 24 * 60 * 60 * 1000);
    document.cookie = `${name}=${value};expires=${expires.toUTCString()};path=/;SameSite=Lax`;
  },

  get: (name: string): string | null => {
    const nameEQ = name + "=";
    const ca = document.cookie.split(';');
    for (let i = 0; i < ca.length; i++) {
      let c = ca[i];
      while (c.charAt(0) === ' ') c = c.substring(1, c.length);
      if (c.indexOf(nameEQ) === 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
  },

  remove: (name: string) => {
    document.cookie = `${name}=;expires=Thu, 01 Jan 1970 00:00:01 GMT;path=/`;
  }
};

// Authentication service
export const authService = {
  async login(credentials: LoginRequest): Promise<ApiResponse<LoginResponse>> {
    try {
      const response = await fetch('http://localhost:5000/api/Identity/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(credentials),
      });

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      const data: ApiResponse<LoginResponse> = await response.json();
      
      // If login successful, store token in cookies
      if (data.isSuccess && data.data.token) {
        // Calculate expiration date based on API response
        const expiresAt = new Date(data.data.expiresAt);
        const now = new Date();
        const daysUntilExpiry = Math.ceil((expiresAt.getTime() - now.getTime()) / (1000 * 60 * 60 * 24));
        
        // Store token and user data in cookies
        cookies.set('authToken', data.data.token, daysUntilExpiry);
        cookies.set('userData', JSON.stringify(data.data.user), daysUntilExpiry);
        cookies.set('tokenExpires', data.data.expiresAt, daysUntilExpiry);
      }

      return data;
    } catch (error) {
      console.error('Login error:', error);
      throw error;
    }
  },

  logout(): void {
    cookies.remove('authToken');
    cookies.remove('userData');
    cookies.remove('tokenExpires');
  },

  getToken(): string | null {
    return cookies.get('authToken');
  },

  getUser(): User | null {
    const userData = cookies.get('userData');
    if (userData) {
      try {
        return JSON.parse(userData);
      } catch (error) {
        console.error('Error parsing user data:', error);
        return null;
      }
    }
    return null;
  },

  isAuthenticated(): boolean {
    const token = this.getToken();
    const expiresAt = cookies.get('tokenExpires');
    
    if (!token || !expiresAt) {
      return false;
    }

    // Check if token is expired
    const expiry = new Date(expiresAt);
    const now = new Date();
    
    if (now >= expiry) {
      // Token expired, clear cookies
      this.logout();
      return false;
    }

    return true;
  },

  getAuthHeaders(): HeadersInit {
    const token = this.getToken();
    return token ? { 'Authorization': `Bearer ${token}` } : {};
  },

  async getProfile(): Promise<ApiResponse<User>> {
    try {
      const token = this.getToken();
      if (!token) {
        throw new Error('No authentication token found');
      }

      const response = await fetch('http://localhost:5000/api/Identity/profile', {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}`
        },
      });

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      const data: ApiResponse<User> = await response.json();
      
      // If profile fetch successful, update stored user data
      if (data.isSuccess && data.data) {
        const expiresAt = cookies.get('tokenExpires');
        if (expiresAt) {
          const expiry = new Date(expiresAt);
          const now = new Date();
          const daysUntilExpiry = Math.ceil((expiry.getTime() - now.getTime()) / (1000 * 60 * 60 * 24));
          cookies.set('userData', JSON.stringify(data.data), daysUntilExpiry);
        }
      }

      return data;
    } catch (error) {
      console.error('Profile fetch error:', error);
      throw error;
    }
  }
};