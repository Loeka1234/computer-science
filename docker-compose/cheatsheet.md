# Docker Compose

Tool for defining and running multi-container Docker applications. 

1. Define your app’s environment with a `Dockerfile` so it can be reproduced anywhere.

2. Define the services that make up your app in `docker-compose.yml` so they can be run together in an isolated environment.

3. Run `docker-compose up` and Compose starts and runs your entire app.

### docker-compose.yml

```yml
version: '3'
services:
  web:
    # Path to dockerfile.
    # '.' represents the current directory in which
    # docker-compose.yml is present.
    build: .

    # Mapping of container port to host

    ports:
      - "5000:5000"
    # Mount volume 
    volumes:
      - "/usercode/:/code"

    # Link database container to app container 
    # for reachability.
    links:
      - "database:backenddb"

  database:

    # image to fetch from docker hub
    image: mysql/mysql-server:5.7

    # Environment variables for startup script
    # container will use these variables
    # to start the container with these define variables. 
    environment:
      - "MYSQL_ROOT_PASSWORD=root"
      - "MYSQL_USER=testuser"
      - "MYSQL_PASSWORD=admin123"
      - "MYSQL_DATABASE=backend"
    # Mount init.sql file to automatically run 
    # and create tables for us.
    # everything in docker-entrypoint-initdb.d folder
    # is executed as soon as container is up nd running.
    volumes:
      - "/usercode/db/init.sql:/docker-entrypoint-initdb.d/init.sql"
```

**`version ‘3’`:** This denotes that we are using **version 3** of **Docker Compose**, and Docker will provide the appropriate features.

**`services`:** This section **defines all the different containers** we will create. In our example, we have two services, web and database.

**`web`:** This is the **name** of our Flask app **service**. Docker Compose will create containers with the name we provide.

**`build`:** This specifies the **location** of our **Dockerfile**, and `.` represents the directory where the `docker-compose.yml` file is located.

**`ports`:** This is used to **map** the **container’s ports** to the **host machine**.

**`volumes`:** This is just like the `-v` option for mounting disks in Docker. In this example, we attach our code files directory to the containers’ `./code` directory. This way, we won’t have to rebuild the images if changes are made.

**`links`:** This will **link one service to another**. For the bridge network, we must specify which container should be accessible to which container using links.

**`image`:** If we don’t have a Dockerfile and want to **run a service** using a **pre-built image**, we specify the image location using the `image` clause. Compose will fork a container from that image.

**`environment`:** The clause allows us to **set up** an **environment variable** in the container. This is the same as the `-e` argument in Docker when running a container.
