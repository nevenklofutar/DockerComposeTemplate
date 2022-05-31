# https://dev.to/berviantoleo/web-api-in-net-6-docker-41d5

# ----- build image from Dockerfile in the same folder
# -t >> create name and tag for image
# docker build -t dotnet-image:1.0 .

# ----- run container from image -----
# -- name   name the container
# -- -d     run in background
# -p        expose port 80 from container to 8081 on host
# docker run --name dotnet-container -d -p 8081:80 dotnet-image:1.0

# ---------------------------------

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /app
COPY . .
RUN dotnet restore ./Api.sln
RUN dotnet publish -o /app/published-app ./Api.sln

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/published-app /app

ENTRYPOINT [ "dotnet", "/app/Api.dll" ]
