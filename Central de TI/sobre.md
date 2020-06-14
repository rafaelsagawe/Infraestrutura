# Função 
Esse PC terá a função de fornecer uma central de serviços de ti:
* Inventario;
* Monitoramento;
* Alertas;
* Etc.

## Recursos de Hardware

Hardware | Recursos
---------|-----------
CPU | 
Men|
HD|
Rede|

## Sistema Operacional 

## Instalação do Sistema de Inventario (GLPI)

## Instalação do Monitoramento (Zabbix)

Example for Zabbix server and web frontend with PostgreSQL database.

`# apt-get install zabbix-server-pgsql zabbix-frontend-php`

Creating initial database
You need to have database username user set up with permissions to create database objects.
Create Zabbix database on PostgreSQL with the following commands:

~~~~console
shell> psql -U <username>
psql> create database zabbix; 
psql> \q
~~~~
Then import initial schema and data:

~~~~shell
# zcat /usr/share/doc/zabbix-server-pgsql/create.sql.gz | psql -U <username> zabbix
~~~~
Database configuration for Zabbix server
Edit server host, name, user and password in zabbix_server.conf as follows, replacing <username_password> with actual password of PostgreSQL user:

~~~~shell
# nano /etc/zabbix/zabbix_server.conf
~~~~
~~~~
DBHost=
DBName=zabbix
DBUser=zabbix
DBPassword=<username_password>
~~~~

You might want to keep default setting DBHost=localhost (or an IP address), but this would make PostgreSQL use network socket instead of UNIX socket connecting to Zabbix. If you also have SELinux enabled in enforcing mode see SELinux configuration for instructions.

Starting Zabbix server process
Now you may start Zabbix server process and make it start at system boot
~~~~shell
# service zabbix-server start
# update-rc.d zabbix-server enable
~~~~
PHP configuration for Zabbix frontend
Apache configuration file for Zabbix frontend is located in /etc/zabbix/apache.conf. Some PHP settings are already configured. But it's necessary to uncomment the “date.timezone” setting and set the right timezone for you.
~~~~
php_value max_execution_time 300
php_value memory_limit 128M
php_value post_max_size 16M
php_value upload_max_filesize 2M
php_value max_input_time 300
php_value always_populate_raw_post_data -1
# php_value date.timezone Europe/Riga
php_value date.timezone america/sao_paulo
~~~~
As frontend is configured, you need to restart Apache web server:
~~~~shell
# service apache2 restart
~~~~
Installing frontend

