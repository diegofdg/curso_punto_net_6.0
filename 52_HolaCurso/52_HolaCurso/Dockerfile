#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["52_HolaCurso/52_HolaCurso.csproj", "52_HolaCurso/"]
RUN dotnet restore "52_HolaCurso/52_HolaCurso.csproj"
COPY . .
WORKDIR "/src/52_HolaCurso"
RUN dotnet build "52_HolaCurso.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "52_HolaCurso.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "52_HolaCurso.dll"]