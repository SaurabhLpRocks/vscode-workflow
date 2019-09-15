FROM node:10.15.1-alpine as angular-built
WORKDIR /usr/src/app
RUN npm i -g @angular/cli@8.0.3
COPY package.json package.json
COPY package-lock.json package-lock.json
RUN npm install --silent
COPY . .
RUN ng build --prod --build-optimizer

FROM nginx:alpine
LABEL author="Saurabh Palatkar"
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=angular-built /usr/src/app/dist/ng-app /usr/share/nginx/html
EXPOSE 80
CMD [ "nginx", "-g", "daemon off;" ]