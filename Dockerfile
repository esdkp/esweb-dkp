FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh
