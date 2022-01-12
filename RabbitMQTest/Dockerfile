FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RabbitMQTest/RabbitMQTest.csproj", "RabbitMQTest/"]
RUN dotnet restore "RabbitMQTest/RabbitMQTest.csproj"
COPY . .
WORKDIR "/src/RabbitMQTest"
RUN dotnet build "RabbitMQTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RabbitMQTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RabbitMQTest.dll"]
