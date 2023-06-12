# Projeto Casa de inovação

## Acessando via SSh o container
~~~~shell
# nano /etc/ssh/sshd_config
    PermitRootLogin yes

# service ssh restart
~~~~

## Instalando servidor Web

Para esse implementação de estudos escolhi utilizar o Nginx como servidor web no lugar do Apache2

~~~~shell
# apt-get install nginx php-fpm php-common php-gmp php-curl php-intl php-mbstring php-soap php-xmlrpc php-gd php-xml php-cli php-zip unzip git curl -y
~~~~

### Ajustes no PHP

~~~~shell
nano /etc/php/7.4/fpm/php.ini

    memory_limit = 256M
    cgi.fix_pathinfo = 0
    upload_max_filesize = 10M
    max_execution_time = 360
    date.timezone = America/Sao_Paulo
~~~~

ip route

Instalação atual do moodle
~~~~shell

apt update && apt upgrade

apt install -y lsb-release ca-certificates apt-transport-https software-properties-common gnupg2
apt install ca-certificates apt-transport-https software-properties-common
add-apt-repository ppa:ondrej/php
grep -rhE ^deb /etc/apt/sources.list* | grep -i ondrej
apt update
apt install php8.1
php -v
apt install nginx-full 
ip route
apt purge nginx-full 
cd /var/www/html/
ls
wget https://download.moodle.org/download.php/stable402/moodle-4.2.1.zip
ls
wget https://download.moodle.org/download.php/direct/stable402/moodle-4.2.1.zip
rm moodle-4.2.1.zip*
ls
wget https://download.moodle.org/download.php/direct/stable402/moodle-4.2.1.zip
unzip moodle-4.2.1.zip 
apt install unzip
unzip moodle-4.2.1.zip 
ls
cd .. 
mkdir moodledata
chown www-data /var/www/html/moodledata
chown www-data:www-date /var/www/html/moodledata
 /var/www/html/moodledata
chown www-data:www-date /var/www/moodledata
chown www-data:www-data /var/www/moodledata
apt install postgresql 
service postgresql status
su - postgres
apt install php8.1-pgsql 
service apache2 restart 
cd html/moodle/
ls
chown www-data:www-date /var/www/html/moodle/
chown www-data:www-data /var/www/html/moodle/
apt install php8.1-xml 
service apache2 restart 
apt install php8.1-{ fpm curl gd xmlrpc intl xml zip mbstring soap pgsql}
apt install php8.1-fpm php8.1-curl php8.1-gd php8.1-xmlrpc php8.1-intl php8.1-zip php8.1-mbstring php8.1-soap 
service apache2 restart 
apt purge postgresql 
curl -fsSL https://www.postgresql.org/media/keys/ACCC4CF8.asc|sudo gpg --dearmor -o /etc/apt/trusted.gpg.d/postgresql.gp
apt install curl
curl -fsSL https://www.postgresql.org/media/keys/ACCC4CF8.asc|sudo gpg --dearmor -o /etc/apt/trusted.gpg.d/postgresql.gp
curl -fsSL https://www.postgresql.org/media/keys/ACCC4CF8.asc|sudo gpg --dearmor -o /etc/apt/trusted.gpg.d/postgresql.gpg
echo "deb http://apt.postgresql.org/pub/repos/apt/ `lsb_release -cs`-pgdg main" |sudo tee  /etc/apt/sources.list.d/pgdg.list
apt install postgresql-13 postgresql-client-13
service postgresql status
su - postgres
service apache2 restart 
apt purge postgresql-12 postgresql-client-12  
service postgresql status
su - postgres
service postgresql restart
service postgresql status
service apache2 status
service apache2 restart
nano config.php 
rm config.php 
reboot 

~~~~

## Instalando Moodle
https://www.howtoforge.com/how-to-install-moodle-on-ubuntu-20-04/


Memoria= 1gb
core= 2
HD= 40gb
IP= 192.168.31.197/24

Sistema já com o Moodle instalado

## para a criação com base postgres (não usado)
DBuser: "moodle_ead" 
DBpassword "semed-ead"


~~~~shell
# apt install apache2 php php-pgsql libapache2-mod-php zip php-zip php-curl php-xml php-gd php-intl php-mbstring php-soap php-xmlrpc

# wget https://download.moodle.org/download.php/direct/stable37/moodle-3.7.1.zip

# unzip moodle-3.7.1.zip

# nano /etc/apache2/sites-available/000-default.conf

# chown www-data:www-data -R /var/www/

# service apache2 restart
~~~~