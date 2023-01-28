#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlackCarrot.Search/BlackCarrot.Search.csproj", "BlackCarrot.Search/"]
COPY ["BlackCarrot.Data/BlackCarrot.Data.csproj", "BlackCarrot.Data/"]
RUN dotnet restore "BlackCarrot.Search/BlackCarrot.Search.csproj"
COPY . .
WORKDIR "/src/BlackCarrot.Search"
RUN dotnet build "BlackCarrot.Search.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlackCarrot.Search.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlackCarrot.Search.dll"]