# Set the base image as the .NET 7.0 SDK (this includes the runtime)
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env

# Copy everything and publish the release (publish implicitly restores and builds)
WORKDIR /app
COPY . ./
RUN dotnet publish ./src/SemVer.Json/SemVer.Json.csproj -c Release -o out --no-self-contained

FROM mcr.microsoft.com/dotnet/runtime:10.0-alpine
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "/SemVer.Json.dll" ]