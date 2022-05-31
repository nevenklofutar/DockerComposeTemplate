# https://referbruv.com/blog/dockerizing-an-angular-application-for-release-build-and-deploy/
# https://itnext.io/angular-development-in-docker-with-dev-containers-49d2cabad445
# https://dev.to/wkrzywiec/build-and-run-angular-application-in-a-docker-container-19pm

# ----- build image from Dockerfile in the same folder
# -t >> create name and tag for image
# docker build -t angular-image:1.0 .

# ----- run container from image -----
# -- name   name the container
# -- -d     run in background
# -p        expose port 80 from container to 8080 on host
# docker run --name angular-container -d -p 8080:80 angular-test:1.0

# ---------------------------------

# Step 1 – Selecting Base Image and Installing Angular

# BASE IMAGE with an alias #
FROM node:18.2.0-alpine3.15 as build
WORKDIR /app

# Install Angular CLI to run Build #
RUN npm install -g @angular/cli

# ---------------------------------
# Step 2 – Copying the files and Angular build

COPY ./package.json .
RUN npm install
COPY . .
RUN ng build

# ---------------------------------
# Step 3 – Copying the dist files onto NGINX

# BASE IMAGE with an alias #
FROM nginx as runtime

# Copy contents from the other container with alias "build" #
# onto the specified path in the current container#
COPY --from=build /app/dist/client /usr/share/nginx/html
