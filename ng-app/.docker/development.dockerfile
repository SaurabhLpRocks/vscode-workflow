FROM node:10.15.1-alpine
LABEL author="Saurabh Palatkar"


# set working directory
RUN mkdir /usr/share/app
WORKDIR /usr/share/app

# install and cache app dependencies
COPY package.json package.json
RUN npm i -g @angular/cli@8.0.3
COPY package-lock.json package-lock.json
RUN npm i


# add the app
COPY . .

# add `node_modules/.bin` to $PATH
ENV PATH /node_modules/.bin:$PATH
EXPOSE 80
EXPOSE 9222
CMD ["sh", "-c", "ng serve --host=0.0.0.0 --watch --poll=2000"]
# CMD ["sh", "-c", "npm start --host=0.0.0.0 --watch --poll=2000 --inspect=0.0.0.0:9222 --remote-debugging-port=9222 --nolazy"]
# CMD ["sh", "-c", "npm rebuild node-sass --force && ng serve --host=0.0.0.0 --watch --poll=2000"]