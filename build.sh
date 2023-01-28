#!/bin/bash

 
	echo -e "\n======================"
	echo "Build Search Image"
	echo -e "======================\n"

	eval $(minikube -p minikube docker-env --shell=auto)

	docker build -t search-image -f ./BlackCarrot.Search/Dockerfile .

	
	docker build -t products-image -f ./BlackCarrot.Products/Dockerfile .

	
	docker build -t web-image -f ./BlackCarrot.Web/Dockerfile .

	echo -e "\n======================"
	echo "Deploy Orchestrator"
	echo -e "======================\n"

	kubectl apply -f ./orchestrator
