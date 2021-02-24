#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["TaxaJuros/TaxaJuros.csproj", "TaxaJuros/"]
COPY ["TaxaJuros.Api.Domain/TaxaJuros.Api.Domain.csproj", "TaxaJuros.Api.Domain/"]
COPY ["TaxaJuros.Api.Core/TaxaJuros.Api.Core.csproj", "TaxaJuros.Api.Core/"]
COPY ["TaxaJuros.Api.Infraestructure/TaxaJuros.Api.Infraestructure.csproj", "TaxaJuros.Api.Infraestructure/"]
COPY ["TaxaJuros.Api.Application/TaxaJuros.Api.Application.csproj", "TaxaJuros.Api.Application/"]
RUN dotnet restore "TaxaJuros/TaxaJuros.csproj"
COPY . .
WORKDIR "/src/TaxaJuros"
RUN dotnet build "TaxaJuros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaxaJuros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet TaxaJuros.dll
