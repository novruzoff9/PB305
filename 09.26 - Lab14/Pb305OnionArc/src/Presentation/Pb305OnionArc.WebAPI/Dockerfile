# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Presentation/Pb305OnionArc.WebAPI/Pb305OnionArc.WebAPI.csproj", "src/Presentation/Pb305OnionArc.WebAPI/"]
COPY ["src/Infrastructure/Pb305OnionArc.Infrastructure/Pb305OnionArc.Infrastructure.csproj", "src/Infrastructure/Pb305OnionArc.Infrastructure/"]
COPY ["src/Core/Pb305OnionArc.Application/Pb305OnionArc.Application.csproj", "src/Core/Pb305OnionArc.Application/"]
COPY ["src/Core/Pb305OnionArc.Domain/Pb305OnionArc.Domain.csproj", "src/Core/Pb305OnionArc.Domain/"]
COPY ["src/Infrastructure/Pb305OnionArc.Persistance/Pb305OnionArc.Persistance.csproj", "src/Infrastructure/Pb305OnionArc.Persistance/"]
RUN dotnet restore "./src/Presentation/Pb305OnionArc.WebAPI/Pb305OnionArc.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Presentation/Pb305OnionArc.WebAPI"
RUN dotnet build "./Pb305OnionArc.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Pb305OnionArc.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pb305OnionArc.WebAPI.dll"]