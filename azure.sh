#getting this set up on Azure CLI

#resource group to hold this website
az group create \
	--name PersonalDotNetWebsite \
	--location "Central US"

#sets up the app service plan, F1 is free
az appservice plan create \
	--name freeWebServer \
	--resource-group PersonalDotNetWebsite \
	--sku F1