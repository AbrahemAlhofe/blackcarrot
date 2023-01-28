# Installation
1. Clone the repository
```bash
git clone https://github.com/AbrahemAlhofe/blackcarrot.git
```

2. Install minikube
You can install minikube from [here](https://minikube.sigs.k8s.io/docs/start/)

3. Start minikube
```bash
minikube start
```

## Setup

1. Build the cluster
Run this bash script to build all projects' images and applying all kubernetes' configuration files ( pods, services, etc ... )

```bash
bash build.sh
```

2. Deploy the cluster
Run this bash script to make a tunnel between your local machine and the cluster, to be able to open the website
```bash
bash deploy.sh
```

3. Open the website
Write this url in your browser [http://blackcarrot.com](http://blackcarrot.com)

