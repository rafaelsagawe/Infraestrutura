Memoria= 1gb
core= 2
HD= 40gb
IP= 192.168.31.197/24

Sistema já com o Moodle instalado

## para a criação com base postgres (nõa usado)
DBuser: "moodle_ead" 
DBpassword "semed-ead"

apt install apache2 php php-pgsql libapache2-mod-php zip php-zip php-curl php-xml php-gd php-intl php-mbstring php-soap php-xmlrpc

wget https://download.moodle.org/download.php/direct/stable37/moodle-3.7.1.zip

unzip moodle-3.7.1.zip

nano /etc/apache2/sites-available/000-default.conf

chown www-data:www-data -R /var/www/

service apache2 restart