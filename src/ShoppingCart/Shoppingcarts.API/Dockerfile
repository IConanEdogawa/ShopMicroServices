#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 9096
EXPOSE 9097

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/ShoppingCart/Shoppingcarts.API/Shoppingcarts.API.csproj", "src/ShoppingCart/Shoppingcarts.API/"]
RUN dotnet restore "./src/ShoppingCart/Shoppingcarts.API/Shoppingcarts.API.csproj"
COPY . .
WORKDIR "/src/src/ShoppingCart/Shoppingcarts.API"
RUN dotnet build "./Shoppingcarts.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Shoppingcarts.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shoppingcarts.API.dll"]