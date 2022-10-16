```powershell
$version="1.0.1"
$accountName = "learndbtest"



az acr login --name $accountName
docker build -t "$accountName.azurecr.io/supermarket:$version" .
docker push "$accountName.azurecr.io/supermarket:$version"


docker run -it --rm -p 5000:5000 --name SuperMarket "$accountName.azurecr.io/supermarket:$version"



```
