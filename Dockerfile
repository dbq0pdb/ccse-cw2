# Base Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ccsecw2.csproj", "."]
RUN dotnet restore "ccsecw2.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "ccsecw2.csproj" -c Release -o /app

# Publish Stage
FROM build AS publish
RUN dotnet publish "ccsecw2.csproj" -c Release -o /app

# Final Stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ccsecw2.dll"]