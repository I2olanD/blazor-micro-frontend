FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CounterApp.csproj", "."]
RUN dotnet restore
COPY . .
RUN dotnet build "CounterApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CounterApp.csproj" -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
RUN ["cp", "./CounterApp.dll", "./wwwroot/CounterApp.dll"]
ENTRYPOINT [ "dotnet", "CounterApp.dll" ]