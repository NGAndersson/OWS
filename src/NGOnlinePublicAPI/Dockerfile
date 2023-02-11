#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NGOnlinePublicAPI/NGOnlinePublicAPI.csproj", "NGOnlinePublicAPI/"]
COPY ["OWSShared/OWSShared.csproj", "OWSShared/"]
RUN dotnet restore "NGOnlinePublicAPI/NGOnlinePublicAPI.csproj"
COPY . .
WORKDIR "/src/NGOnlinePublicAPI"
RUN dotnet build "NGOnlinePublicAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NGOnlinePublicAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NGOnlinePublicAPI.dll"]