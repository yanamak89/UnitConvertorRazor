# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .
RUN dotnet publish -c Release -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app .

# Render sets PORT env automatically
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}

EXPOSE ${PORT}

ENTRYPOINT ["dotnet", "UnitConvertorRazor.dll"]
