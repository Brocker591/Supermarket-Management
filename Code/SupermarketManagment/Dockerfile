#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["../WebApp/WebApp.csproj", "WebApp/"]
COPY ["../CoreBusiness/CoreBusiness.csproj", "CoreBusiness/"]
COPY ["../Plugins.DataStore.InMemory/Plugins.DataStore.InMemory.csproj", "Plugins.DataStore.InMemory/"]
COPY ["../UseCases/UseCases.csproj", "UseCases/"]
COPY ["../Plugins.DataStore.SQL/Plugins.DataStore.SQL.csproj", "Plugins.DataStore.SQL/"]
RUN dotnet restore "WebApp/WebApp.csproj"
COPY . .
WORKDIR "/src/WebApp"
RUN dotnet build "WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.dll"]