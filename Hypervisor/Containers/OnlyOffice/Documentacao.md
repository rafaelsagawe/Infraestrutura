## Hardware do teste

Recurso | Alocado
--|--
CPU| 2 core
Mem| 1024GB
DHCP | Ativo
Storage| 15GB
Feature| Nesting

## Instalar o docker conforme a documetação do ProxMox.
~~~~shell
# docker run -i -t -d -p 443:443 \ 
    -v /app/onlyoffice/DocumentServer/data:/var/www/onlyoffice/Data  onlyoffice/documentserver
~~~~

# Instalação manual

## 1. Servidor Web e dependencias

~~~~shell
# apt-get install nginx nginx-extras redis-server rabbitmq-server gnupg2 -y
# systemctl start rabbitmq-server
# systemctl start redis-server
~~~~

## 2. Instalando o Banco de dados - PostgreSQL

~~~~shell
# apt-get install postgresql -y
# systemctl start postgresql
# su - postgres
    $ psql
       # CREATE DATABASE onlyoffice;
       # CREATE USER onlyoffice WITH password 'onlyoffice';
       # GRANT ALL privileges ON DATABASE onlyoffice TO onlyoffice;
       # \q
    $ exit
~~~~

## 3. Instalando o Document Server do OnlyOffice

~~~~shell
# apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys CB2DE8E5
    Warning: apt-key is deprecated. Manage keyring files in trusted.gpg.d instead (see apt-key(8)).
    Executing: /tmp/apt-key-gpghome.7OIPKgnywX/gpg.1.sh --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys CB2DE8E5
    gpg: key 8320CA65CB2DE8E5: public key "Ascensio System Limited (ONLYOFFICE) <support@onlyoffice.com>" imported
    gpg: Total number processed: 1
    gpg:               imported: 1

# echo "deb https://download.onlyoffice.com/repo/debian squeeze main" | tee /etc/apt/sources.list.d/onlyoffice.list

# apt-get update -y

# apt-get install onlyoffice-documentserver -y
~~~~

![Senha de configuração do DB](Senha.png)

~~~~ Shell
# cat /etc/nginx/conf.d/ds.conf
    include /etc/nginx/includes/http-common.conf;
    server {
    listen 0.0.0.0:80;
    listen [::]:80 default_server;
    server_tokens off;
    include /etc/nginx/includes/ds-*.conf;
    }
# systemctl restart nginx
~~~~
http://IP.usado.na.instancia/healthcheck

Deve retornar ``true`` na página

para implemantar no Nextcloud é necessario a ``Chave Secreta`` gerada durante a instalação

~~~~shell
# cat /etc/onlyoffice/documentserver/local.json
{
  "services": {
    "CoAuthoring": {
      "sql": {
        "type": "postgres",
        "dbHost": "localhost",
        "dbPort": "5432",
          "string": "nvQDSY1WECUR"
        }
      }
    }
  },
  "rabbitmq": {
    "url": "amqp://guest:guest@localhost"
  },
  "storage": {
    "fs": {
      "secretString": "TJVzjNfEAgsPj7dObc7e"
    }
  }
~~~~

Em configurações de administração -> OnlyOffice, preencha:

Endereço do OnlyOffice Docs | http://172.15.48.220/
--|--
Chave secreta | nvQDSY1WECUR

Entretanto está apresentando o seguinte erro:

``Erro ao tentar conectar (Ocorreu um erro no serviço de documentos: Error while downloading the document file to be converted.) (versão 7.2.2.56)``
