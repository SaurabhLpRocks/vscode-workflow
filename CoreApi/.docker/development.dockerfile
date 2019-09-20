# FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 as base
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS base
# WORKDIR /app
# ENV ASPNETCORE_URLS http://+:5000;https://+:5001
# EXPOSE 5000 5001
# FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY ["CoreApi.csproj", "./"]
RUN dotnet restore "./CoreApi.csproj"
COPY . .
# RUN dotnet build "CoreApi.csproj" -c Release -o /app
# FROM build AS publish
# RUN dotnet publish "CoreApi.csproj" -c Release -o /app
# FROM base AS final
# WORKDIR /app
# COPY — from=publish /app ./
EXPOSE 5000 5001
ENTRYPOINT ["dotnet", "watch", "--project=CoreApi.csproj", "run"]