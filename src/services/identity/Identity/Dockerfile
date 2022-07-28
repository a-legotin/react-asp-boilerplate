FROM  mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS build
WORKDIR /src
COPY ["src/services/identity/Identity/Identity.csproj", "services/identity/Identity/"]

RUN dotnet restore "services/identity/Identity/Identity.csproj"
COPY src/. .
WORKDIR "/src/services/identity/Identity"
RUN dotnet build "Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:8081
ENTRYPOINT ["dotnet", "Identity.dll"]
