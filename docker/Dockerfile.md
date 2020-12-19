# Dockerfile

Redis server example:

```dockerfile
# Use an existing docker image as a base
FROM alpine

# Download and install a dependency
RUN apk add --update redis

# Tell the image what to do when it starts as a container
CMD [ "redis-server" ]
```

NodeJS example:

```dockerfile
FROM node

WORKDIR /usr/app

COPY ./package.json ./
RUN yarn
COPY ./ ./

CMD ["yarn", "start"]
```
