FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/CamelSystem.Web.Host/CamelSystem.Web.Host.csproj", "src/CamelSystem.Web.Host/"]
COPY ["src/CamelSystem.Web.Core/CamelSystem.Web.Core.csproj", "src/CamelSystem.Web.Core/"]
COPY ["src/CamelSystem.Application/CamelSystem.Application.csproj", "src/CamelSystem.Application/"]
COPY ["src/CamelSystem.Core/CamelSystem.Core.csproj", "src/CamelSystem.Core/"]
COPY ["src/CamelSystem.EntityFrameworkCore/CamelSystem.EntityFrameworkCore.csproj", "src/CamelSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/CamelSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CamelSystem.Web.Host", "src/CamelSystem.Web.Host"]
COPY ["src/CamelSystem.Web.Core", "src/CamelSystem.Web.Core"]
COPY ["src/CamelSystem.Application", "src/CamelSystem.Application"]
COPY ["src/CamelSystem.Core", "src/CamelSystem.Core"]
COPY ["src/CamelSystem.EntityFrameworkCore", "src/CamelSystem.EntityFrameworkCore"]
WORKDIR "/src/src/CamelSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CamelSystem.Web.Host.dll"]
