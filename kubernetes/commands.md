# Kubernetes Commands

This is a small cheatsheet for myself.

- `kubectl get pods`
  
  - Lists pods

- `kubectl get deployments`
  
  - Lists deployments

- `kubectl exec -it [pod_name] [cmd]`
  
  - Executes the given command in a running pod

- `kubectl logs [pod_name]`
  
  - Prints out logs from the given pod

- `kubectl delete pod [pod_name]`
  
  - Deletes the given pod

- `kubectl apply -f [config file name]`
  
  - Tells kubernetes to process the config

- `kubectl rollout restart deployment [deployment name]`


