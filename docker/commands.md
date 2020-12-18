# Docker Commands

This is a small cheatsheet for myself.

**docker**: references the Docker Client

- `docker run <image name> <command>`
  
  - Creates and runs a container
  
  - Same as `docker create <image name>` + `docker start <container id>`
  
  - **image name**: name of image to use for container
  
  - **command**: command to be executed inside container after start up

- `docker ps`
  
  - Lists all running containers
  
  - Options
    
    - `--all` show all containers (default shows just running)
    
    - ...

- `docker system prune`
  
  - Will remove:
    
    - all stopped containers
    
    - all networks not used by at least one container
    
    - all dangling images
    
    - all build cache

- `docker logs <container id>`
  
  - Gets logs from a container

- `docker stop <container id>`
  
  - Stops a container
  
  - Sends a **SIGTERM** message to the container
  
  - The container has time to stop

- `docker kill <container id>`
  
  - Kills a container
  
  - Sends a **SIGKILL** message to the container
  
  - The container has to stop immediately

- `docker exec -it <container id> <command>`
  
  - Runs a new command in a running container
  
  - **-it**: allow us to provide input to the container (for example: with the redis-cli command)
    
    - **-i**: Keep STDIN open even if not attached
    
    - **-t**: Allocate a pseudo-TTY (makes text little pretty etc.)

- `docker exec -it <container id> sh`
  
  - Executes shell (a Command Prompt)
  
  - Won't work for every container

- `docker build <path or URL>`
  
  - Builds an image from a Dockerfile

- `docker build -t Loeka1234/redis:latest <path or URL>`
  
  - Builds and tags an image from a Dockerfile
  
  - Naming conventions: 
    
    - **Loeka1234**: Docker ID
    
    - **redis**: Repo/Project name
    
    - **latest**: Version
