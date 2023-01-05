~~~~
wget -qO- https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -

sudo add-apt-repository "$(wget -qO- https://packages.microsoft.com/config/ubuntu/18.04/mssql-server-2019.list)"

# sudo apt-get update
# sudo apt-get install -y mssql-server
~~~~
mssql-server (15.0.4138.2-1)

~~~~shell
sudo /opt/mssql/bin/mssql-conf setup
~~~~

3 - Express
~~~~shell
systemctl status mssql-server --no-pager

apt install curl

curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -

curl https://packages.microsoft.com/config/ubuntu/18.04/prod.list | sudo tee /etc/apt/sources.list.d/msprod.list

sudo apt-get update 

sudo apt-get install mssql-tools unixodbc-dev

echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc

source ~/.bashrc

sqlcmd -S localhost -U SA -P '@SemedNI#'
~~~~

https://udgwebdev.github.io/dicas-de-terminal-copiando-arquivos-via-scp/
https://www.treinaweb.com.br/blog/publicando-uma-aplicacao-asp-net-core-no-linux-com-o-nginx
https://docs.microsoft.com/pt-br/dotnet/core/install/linux-debian
