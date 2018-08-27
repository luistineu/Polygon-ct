FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Polygon-CalculosTrabalhistas/Polygon.WebApi.csproj Polygon-CalculosTrabalhistas.Polygon-CalculosTrabalhistas/
COPY Polygon.Domain/Polygon.Domain.csproj Polygon-CalculosTrabalhistas.Domain/
COPY Polygon.Repositories.Mongo/Polygon.Repositories.Mongo.csproj Polygon.Repositories.Mongo/

COPY . .
WORKDIR /src/Polygon-CalculosTrabalhistas.Polygon-CalculosTrabalhistas


FROM build AS publish


FROM base AS final
WORKDIR /app

ENTRYPOINT ["dotnet", "Polygon-CalculosTrabalhistas.Polygon-CalculosTrabalhistas.dll"]