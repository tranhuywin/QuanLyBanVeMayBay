#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ConnectApi_QuanLy/ConnectApi_QuanLy.csproj", "ConnectApi_QuanLy/"]
COPY ["DTO_QuanLy/DTO_QuanLy.csproj", "DTO_QuanLy/"]
COPY ["BUS_QuanLy/BUS_QuanLy.csproj", "BUS_QuanLy/"]
COPY ["DAL_QuanLy/DAL_QuanLy.csproj", "DAL_QuanLy/"]
RUN dotnet restore "ConnectApi_QuanLy/ConnectApi_QuanLy.csproj"
COPY . .
WORKDIR "/src/ConnectApi_QuanLy"
RUN dotnet build "ConnectApi_QuanLy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConnectApi_QuanLy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConnectApi_QuanLy.dll"]