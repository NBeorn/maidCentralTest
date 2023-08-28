FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/maidCentralTest.Web.Host/maidCentralTest.Web.Host.csproj", "src/maidCentralTest.Web.Host/"]
COPY ["src/maidCentralTest.Web.Core/maidCentralTest.Web.Core.csproj", "src/maidCentralTest.Web.Core/"]
COPY ["src/maidCentralTest.Application/maidCentralTest.Application.csproj", "src/maidCentralTest.Application/"]
COPY ["src/maidCentralTest.Core/maidCentralTest.Core.csproj", "src/maidCentralTest.Core/"]
COPY ["src/maidCentralTest.EntityFrameworkCore/maidCentralTest.EntityFrameworkCore.csproj", "src/maidCentralTest.EntityFrameworkCore/"]
WORKDIR "/src/src/maidCentralTest.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/maidCentralTest.Web.Host", "src/maidCentralTest.Web.Host"]
COPY ["src/maidCentralTest.Web.Core", "src/maidCentralTest.Web.Core"]
COPY ["src/maidCentralTest.Application", "src/maidCentralTest.Application"]
COPY ["src/maidCentralTest.Core", "src/maidCentralTest.Core"]
COPY ["src/maidCentralTest.EntityFrameworkCore", "src/maidCentralTest.EntityFrameworkCore"]
WORKDIR "/src/src/maidCentralTest.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "maidCentralTest.Web.Host.dll"]
