#Variables
RES_GROUP="PersonalDotNetWebsite"
RES_LOC="CentralUS"
WEB_APP_NAME="freeWebServer"
SERVER_LOC="SouthCentralUS"
SERVER_NAME="serverNameHere"
ADMIN="dbAdminUserName"
PWORD="dbAdminPW"
#Use IP addresses for external applications, close this when the app
#is hosted on Azure, set to (0.0.0.0 -> 0.0.0.0)
S_IP="0.0.0.0"
E_IP="0.0.0.0"
DB_NAME="personalDotNetDB"

#getting this set up on Azure CLI

#resource group to hold this website
az group create \
	--name $RES_GROUP \
	--location $RES_LOC

#sets up the app service plan, F1 is free
az appservice plan create \
	--name $WEB_APP_NAME \
	--resource-group $RES_GROUP \
	--sku F1

#create logical server
az sql server create --name $SERVER_NAME --resource-group $RES_GROUP --location $LOC \
    --admin-user $ADMIN --admin-password $PWORD

#firewall rule setup
az sql server firewall-rule create --resource-group $RES_GROUP --server $SERVER_NAME \
    -n AllowYourIp --start-ip-address $S_IP --end-ip-address $E_IP

#actually make the database
az sql db create --resource-group $RES_GROUP --server $SERVER_NAME \
    --name $DB_NAME --service-objective S0