# Docker Compose commands

- `docker-compose <command> --help`
  
  - Provide additional information about arguments and implementation details

- `docker-compose build`
  
  - Builds images in the `docker-compose.yml`
  
  - The job of the `build` command is to get the images ready to create containers

- `docker-compose images`
  
  - Lists all images built using the current `docker-compose` file

- `docker-compose stop`
  
  - Stops the running containers of the specified services

- `docker-compose run`
  
  - Similar to `docker run` command
  
  - Will create containers from images build for the services mentioned in the compose file

- `docker-compose up`
  
  - Does the work of the `docker-compose build` and `docker-compose run` commands
  
  - Builds the images if they are not located locally and starts the containers
  
  - If images are already built, it will fork the conainer directly

- `docker-compose ps`
  
  - List all the containers in the current `docker-compose` file (running or stopped)

- `docker-compose down`
  
  - Similar to the `docker system prune` command. However, in Compose, it stops all the services and clean up the containers, networks and images.
