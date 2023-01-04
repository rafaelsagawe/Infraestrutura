Nextcloud tem funcionalidade muito semelhante ao Dropbox, com a diferença de ser código aberto, e assim permitir que qualquer pessoa instalar e operá-lo sem custo em um servidor privado. Nextcloud é um fork do projeto ownCloud.

Para a instalação estou usando a distribuição: Debian 9.5 netinstall

Hostname = nuvem
domain = semed-ni.intra
senha (padrão)

(Proxmox) apt install openssl ca-certificates

# Servidor web

apt update
apt upgrade
apt install apache2 apache2-utils php php-xml php-gd php-mbstring php-zip php-pclzip php-curl php-xmlrpc php-imagick php-redis php-memcached php-apcu php-gmp php-imap php-ldap php-intl php-pgsql

a2enmod rewrite && a2enmod headers

/etc/init.d/apache2 restart

# Servidor de Banco de dados (Postgres)
apt install postgresql libpq5 postgresql postgresql-client postgresql-client-common postgresql-contrib

$ sudo postgres
$ psql
# CREATE USER root WITH PASSWORD 'semed-ni';
# CREATE DATABASE "nextcloud";
# GRANT ALL ON DATABASE "nextcloud" TO root;
# \q
$ exit

# Nextcloud
cd /var/www/
wget https://download.nextcloud.com/server/releases/nextcloud-14.0.0.zip
 mv /var/www/html /var/www/html_old
 mv nextcloud /var/www/html

## Ajuste
     O PHP OPcache não está configurado corretamente.
     nano /etc/php/7.0/apache2/php.ini
         opcache.enable=1
         opcache.enable_cli=1
         opcache.interned_strings_buffer=8
         opcache.max_accelerated_files=10000
         opcache.memory_consumption=128
         opcache.save_comments=1
         opcache.revalidate_freq=1
     service apache2 restart

     Verifica integidade dos arquivos
     sudo -u www-data php occ integrity:check-core

     Cota de usuario
     Na pagina de criação de usuario, no canto inferior esquerdo engrenagem

     alterar o valor memory_limit para 512M
     nano /etc/php/7.0/apache2/php.ini

     Portugues como Idioma padão
     Alterar o arquivo nano config/config.php
        'default_language' => 'pt'


    O cabeçalho HTTP "Referrer-Policy" não está definido como "no-referrer", "no-referrer-when-downgrade", "strict-origin" ou "strict-origin-when-cross-origin".
    Adicione as linhas no arquivo 000-default.conf
    nano /etc/apache2/sites-enabled/000-default.conf
              Header add Strict-Transport-Security: "max-age=15768000;includeSubdomains"
              Header always set Referrer-Policy "strict-origin"

    Nenhum cache de memória foi configurado. Para melhorar o desempenho, configure um memcache, se disponível.
    Adicione a linha "'memcache.local' => '\OC\Memcache\APCu',"  em nano /var/www/html/config/config.php

## Apps Instalados
* Talk
* OnlyOffice
* Integração LDAP / AD
* Files Right Click
* Quota warning
* Ransomware protection
* Calendar
* Deck
* Contacts
* Full text search - Files
* Flow Upload


Integração LDAP / AD

Servidor
  ldap://172.15.0.1:389
  CN=USUARIOADMINISTRADOR,CN=Users,DC=pcni,DC=local
  ************
  CN=Users,DC=pcni,DC=local
usuarios (Editar consulta LDAP)
(&(|(objectclass=person))(|(|(memberof=CN=Domain Users,CN=Users,DC=pcni,DC=local)(primaryGroupID=513))))
Atributos de acesso (Editar consulta LDAP)
(&(&(|(objectclass=person))(|(|(memberof=CN=Domain Users,CN=Users,DC=pcni,DC=local)(primaryGroupID=513))))(|(samaccountname=%uid)(|(sAMAccountName=%uid))))
Grupos



# HTTPS (EXTRA)

Podemos obter um certificado TLS/SSL grátis vamos usar o Let’s Encrypt CA.
Caso queira deixar seu servidor sem https pule esta etapa.

Primeiro vamos instalar o cliente certbot/letsnecrypt. Para isso será necessario ativar o repositório backports.

# echo 'deb http://ftp.debian.org/debian jessie-backports main' >> /etc/apt/sources.list.d/backports.list
# apt update
# apt install letsencrypt python-certbot-apache -t jessie-backports

# letsencrypt --apache --agree-tos --email seu@email.com -d cloud.remontti.com.br

# certbot renew --dry-run

nano  /var/www/html/config/config.php

[...]
  'trusted_domains' =>
  array (
    0 => 'cloud.remontti.com.br',
  ),
[...]
'overwrite.cli.url' => 'https://cloud.remontti.com.br',
[...]

# OnlyOffice

Com o ONLYOFFICE conectado à instalação do ownCloud/Nextcloud, você será capaz de:
– Trabalhar com todos os formatos principais. Edite arquivos de docx, xlsx, pptx, txt e odt, ods, odp, doc, xls, ppt, pps, epub, rtf, html, htm.
– Desfrutar de perfeita compatibilidade com os formatos do MS Office.
– Usar centenas de recursos de formatação. Adicione gráficos, formas automáticas, equações matemáticas complexas, decore a fonte, edite cabeçalhos / rodapés, crie estilos, altere o design do documento inteiro com dois cliques e mais.
– Editar documentos em tempo real com outras pessoas. Use o modo rápido para ver o que seus colegas estão digitando no momento ou o modo estrito para trabalhar no fragmento do documento sem ser distraído por outros.

apt install git
cd /var/www/
git clone https://github.com/ONLYOFFICE/onlyoffice-owncloud.git onlyoffice
chown  www-data. onlyoffice -R

Docker se encontra nos repositório backports, caso você tenha instalado o letsencrypt (https) você ja fez este procedimento, pode pular para a instalacao do docker.io

echo 'deb http://ftp.debian.org/debian jessie-backports main' >> /etc/apt/sources.list.d/backports.list
apt update
apt install docker.io
systemctl enable docker

________________________________
Sem NÃO instalou os certificados https rode o comando abaixo.
docker run -i -t -d -p 88:80 --restart always onlyoffice/documentserver
________________________________
cd /tmp/
openssl genrsa -out onlyoffice.key 2048
openssl req -new -key onlyoffice.key -out onlyoffice.csr
openssl x509 -req -days 1825 -in onlyoffice.csr -signkey onlyoffice.key -out onlyoffice.crt
openssl dhparam -out dhparam.pem 2048
mkdir -p /app/onlyoffice/DocumentServer/data/certs
cp onlyoffice.key /app/onlyoffice/DocumentServer/data/certs/
cp onlyoffice.crt /app/onlyoffice/DocumentServer/data/certs/
cp dhparam.pem /app/onlyoffice/DocumentServer/data/certs/
chmod 400 /app/onlyoffice/DocumentServer/data/certs/onlyoffice.key
docker run -i -t -d -p 448:443 --restart always -v /app/onlyoffice/DocumentServer/data:/var/www/onlyoffice/Data onlyoffice/documentserver
docker pull onlyoffice/documentserver

## Fontes
https://blog.remontti.com.br/1557
