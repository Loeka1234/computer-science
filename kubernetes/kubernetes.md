# Kubernetes

**Kubernetes Cluster**: A collection of nodes + a master to manage them

**Node**: A virtual machine that will run our containers

**Pod**: More or less a running container. Technically, a pod can run multiple containers (we won't do this)

**Deployment**: Monitors a set of pods, make sure they are running and restarts them if they crash

**Service**: Provides an easy-to-remember URL to access a running container

### Kubernetes Objects

```yaml
apiVersion: v1 # Version of the Kubernetes API you're using to create this object
kind: Pod # Type of object you want to create
metadata: # Config options for the object ware are about to create
  name: posts # Name for the object
spec: # Attributes for the object
  containers: # You can create many containers in a single pod
    - name: posts # Make a container with name of 'posts'
      image: loeka1234/posts:0.0.1 # Image you want to use
```

**containers** is an array.


