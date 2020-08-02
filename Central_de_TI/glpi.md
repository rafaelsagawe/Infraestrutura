# GLPI (Inventario)

GLPi é um sistema de código aberto para Gerenciamento de Ativos de TI, rastreamento de problemas e central de serviços. Este software é escrito em PHP e distribuído sob a GNU General Public License. Como uma tecnologia de código aberto, qualquer pessoa pode executar, modificar ou desenvolver o código. Wikipédia

## Instalação dos pacotes

Como o GLPI estará no mesmo equipamento que o Zabbix grande parte dos pacotes já está instalado, esse seria a instalação.

### Pré-requisito
* Servidor Web - Apache2;
* SGBD - MySQL ou MariaDB **(O GLPI não da suporte ao PostgreSQL)**, instalado e administrado pelo Webmin;
* PHP 7.2
    * ctype;
    * curl;
    * gd (picture generation);
    * iconv;
    * intl;
    * json;
    * mbstring;
    * mysqli;
    * session;
    * simplexml;
    * zlib;
    * exif (security enhancement on images validation);
    * imap (mail collector and users authentication);
    * ldap (users authentication);
    * openssl (encrypted communication);
    * sodium (performances enhancement on sensitive data encryption/ decryption);
    * zip and bz2 (installation of zip and bz2 packages from  marketplace).

sudo apt-get -y install libapache2-mod-php php php-{curl,gd,imagick,intl,apcu,recode,memcache,imap,mysql,cas,ldap,tidy,pear,xmlrpc,pspell,gettext,mbstring,json,iconv,xml,gd,xsl} 

## Instalação do GLPI 

1. Acessar a pasta do servidor web;
1. Download do arquivo compactado do GLPI;
1. Descompactar o arquivo;
1. Ajustar as permissões.

~~~~shell
# cd /var/www/html/
# sudo wget https://github.com/glpi-project/glpi/releases/download/9.5.0/glpi-9.5.0.tgz
# sudo tar zxvf glpi-9.5.0.tgz
# sudo chown www-data:www-data -R glpi
~~~~

O restante da instalação é feita através da interface web.

![tela1](img-glpi/glpi_install_01.png)
![tela2](img-glpi/glpi_install_02.png)
![tela3](img-glpi/glpi_install_03.png)
![tela4](img-glpi/glpi_install_04.png)
![tela5](img-glpi/glpi_install_05.png)
![tela6](img-glpi/glpi_install_06.png)
![tela7](img-glpi/glpi_install_07.png)
![tela8](img-glpi/glpi_install_08.png)
![tela9](img-glpi/glpi_install_09.png)
![tela10](img-glpi/glpi_install_10.png)
![tela11](img-glpi/glpi_install_11.png)


![tela12](img-glpi/glpi_01.png)
Tela de login do GLPI

![tela13](img-glpi/glpi_02.png)
Tela Inicial do GLPI 9.5 recém instalado

# Inventario Automatico

## Download do Fusion 
sudo wget https://github.com/fusioninventory/fusioninventory-for-glpi/releases/download/glpi9.5.0%2B1.0/fusioninventory-9.5.0+1.0.tar.bz2

/usr/bin/php7.2 /var/www/html/glpi/front/cron.php &>/dev/null

# Cron
~~~~shell
# sudo crontab -e
~~~~

    * * * * * /usr/bin/php7.2 /var/www/html/glpi/front/cron.php &>/dev/null







fusioninventory-netinventory --host 172.15.0.10 \ --credentials version:2c,community:public