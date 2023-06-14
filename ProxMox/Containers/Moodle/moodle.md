# Projeto Casa de inovação

## Acessando via SSh o container
~~~~shell
# nano /etc/ssh/sshd_config
    PermitRootLogin yes

# service ssh restart
~~~~

Instalação atual do moodle

O Moodle apartir da versão 4, necessita do PHP8 e PostgreSQL13

~~~~shell
# apt update && apt upgrade
# apt install -y lsb-release ca-certificates apt-transport-https software-properties-common gnupg2
# apt install -y ca-certificates apt-transport-https software-properties-common
# add-apt-repository ppa:ondrej/php
# grep -rhE ^deb /etc/apt/sources.list* | grep -i ondrej

# apt update
# apt install curl php8.1 php8.1-fpm php8.1-curl php8.1-xml php8.1-gd php8.1-xmlrpc php8.1-intl php8.1-zip php8.1-mbstring php8.1-soap php8.1-pgsql unzip
~~~~

### Ajustes no PHP

~~~~shell
# nano /etc/php/7.4/fpm/php.ini

    memory_limit = 256M
    cgi.fix_pathinfo = 0
    upload_max_filesize = 10M
    max_execution_time = 360
    date.timezone = America/Sao_Paulo
~~~~

## Instalando o Moodle
~~~~Shell
# cd /var/www/html/
# wget https://download.moodle.org/download.php/direct/stable402/moodle-4.2.1.zip
# unzip moodle-4.2.1.zip 
# mkdir moodledata
# chown www-data:www-data /var/www/moodledata
# chown www-data:www-data /var/www/html/moodle/
~~~~

## Instalando o PostgreSQL

~~~~shell
# curl -fsSL https://www.postgresql.org/media/keys/ACCC4CF8.asc|sudo gpg --dearmor -o /etc/apt/trusted.gpg.d/postgresql.gpg
# echo "deb http://apt.postgresql.org/pub/repos/apt/ `lsb_release -cs`-pgdg main" |sudo tee  /etc/apt/sources.list.d/pgdg.list
# apt install postgresql-13 postgresql-client-13
# service apache2 restart 
# service postgresql status
~~~~

### Criando o Banco de dados

~~~~shell
# su - postgres
$ psql
    CREATE USER moodle WITH PASSWORD 'SenhaDB';
    CREATE DATABASE moodle ENCODING 'UTF8' TEMPLATE template0;
    GRANT ALL PRIVILEGES ON DATABASE moodle to moodle;
    \q
$ exit
~~~~

## Envio de e-mail

Administração do site -> Servidor -> Configuração de saída de e-mail

~~~~
Servidor SMTP: email-ssl.com.br:465;
Segurança SMTP: SSL;
Tipo de autenticação SMTP: Login;
Usuário do SMTP: email_do_usuario@e-mail_institucional
Senha do SMTP: senha_do_email@e-mail_institucional
~~~~

Para testar o envio de email é usado o plugin, Moodle eMail Test

[Página do projeto](https://moodle.org/plugins/local_mailtest)

Local de instalação, /var/www/html/moodle/local

~~~~shell
# wget https://moodle.org/plugins/download.php/29145/local_mailtest_moodle42_2023050600.zip
# unzip local_mailtest_moodle42_2023050600.zip
~~~~

## Fontes

https://www.howtoforge.com/how-to-install-moodle-on-ubuntu-20-04/


