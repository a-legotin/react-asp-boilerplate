FROM node:lts-alpine3.15 as build-deps
WORKDIR /usr/src/app
COPY . .
RUN yarn install
RUN yarn run build

FROM node:lts-alpine3.15
COPY --from=build-deps /usr/src/app/build /usr/src/app
RUN yarn global add serve
WORKDIR /usr/src/app
CMD serve -p 80 -s . 