#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Softplan.Everson.API/Softplan.Everson.API.csproj", "src/Softplan.Everson.API/"]
COPY ["src/Softplan.Everson.Domain/Softplan.Everson.Domain.csproj", "src/Softplan.Everson.Domain/"]
RUN dotnet restore "src/Softplan.Everson.API/Softplan.Everson.API.csproj"
COPY . .
WORKDIR "/src/src/Softplan.Everson.API"
RUN dotnet build "Softplan.Everson.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Softplan.Everson.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Softplan.Everson.API.dll"]