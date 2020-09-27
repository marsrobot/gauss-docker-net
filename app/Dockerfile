FROM mcr.microsoft.com/dotnet/core/sdk:3.1

EXPOSE 5000
EXPOSE 5001
EXPOSE 44394

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./

RUN dotnet build

ENTRYPOINT ["dotnet", "run"]