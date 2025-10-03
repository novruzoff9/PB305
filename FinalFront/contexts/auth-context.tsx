"use client"

import React, { createContext, useContext, useEffect, useState } from 'react'
import { authService, User } from '@/lib/auth-service'

interface AuthContextType {
  user: User | null
  isAuthenticated: boolean
  isLoading: boolean
  login: (email: string, password: string, rememberMe: boolean) => Promise<boolean>
  logout: () => void
  refreshAuth: () => void
  refreshProfile: () => Promise<void>
}

const AuthContext = createContext<AuthContextType | undefined>(undefined)

export const useAuth = () => {
  const context = useContext(AuthContext)
  if (context === undefined) {
    throw new Error('useAuth must be used within an AuthProvider')
  }
  return context
}

export const AuthProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [user, setUser] = useState<User | null>(null)
  const [isLoading, setIsLoading] = useState(true)

  const refreshAuth = () => {
    if (authService.isAuthenticated()) {
      const userData = authService.getUser()
      setUser(userData)
    } else {
      setUser(null)
    }
    setIsLoading(false)
  }

  useEffect(() => {
    // Check authentication status on mount
    refreshAuth()
  }, [])

  const login = async (email: string, password: string, rememberMe: boolean): Promise<boolean> => {
    try {
      const response = await authService.login({ email, password, rememberMe })
      
      if (response.isSuccess) {
        setUser(response.data.user)
        return true
      }
      return false
    } catch (error) {
      console.error('Login error in context:', error)
      return false
    }
  }

  const logout = () => {
    authService.logout()
    setUser(null)
  }

  const refreshProfile = async () => {
    try {
      if (authService.isAuthenticated()) {
        const response = await authService.getProfile()
        if (response.isSuccess) {
          setUser(response.data)
        }
      }
    } catch (error) {
      console.error('Profile refresh error:', error)
    }
  }

  const value: AuthContextType = {
    user,
    isAuthenticated: !!user && authService.isAuthenticated(),
    isLoading,
    login,
    logout,
    refreshAuth,
    refreshProfile
  }

  return (
    <AuthContext.Provider value={value}>
      {children}
    </AuthContext.Provider>
  )
}