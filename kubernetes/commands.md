# Kubernetes Commands

This is a small cheatsheet for myself.

- `kubectl get pods`
  
  - Lists pods

- `kubectl get deployments`
  
  - Lists deployments

- `kubectl get services -n ingress-nginx`
  
  - Gets services in the `ìngress-nginx` namespace

- `kubectl exec -it [pod_name] [cmd]`
  
  - Executes the given command in a running pod

- `kubectl logs [pod_name]`
  
  - Prints out logs from the given pod

- `kubectl delete pod [pod_name]`
  
  - Deletes the given pod

- `kubectl describe pod [pod_name]`
  
  - Get information about a bot

- `kubectl apply -f [config file name]`
  
  - Tells kubernetes to process the config

- `kubectl rollout restart deployment [deployment name]`

- `kubectl create secret generic jwt-secret --from-literal=JWT_KEY=aoadoad`
  
  - Creates a secret with key `JWT_KEY` and value `aoadoad`
  
  - We use this as we don't want our secret in a config file.

- `kubectl get secrets`
  
  - Gets all secrets
