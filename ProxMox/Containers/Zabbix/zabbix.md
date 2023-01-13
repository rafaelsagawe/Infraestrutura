# Zabbix (Monitoramento)

Zabbix é uma ferramenta de software de monitoramento de código aberto para diversos componentes de TI, incluindo redes, servidores, máquinas virtuais e serviços em nuvem. O Zabbix fornece métricas de monitoramento, entre outras, utilização da rede, carga da CPU e consumo de espaço em disco. Wikipedia 

# Função 
Esse PC terá a função de fornecer uma central de serviços de ti:
* Inventario (GLPI);
* Monitoramento (Zabbix);
* Alertas;
* Etc.

## Recursos de Hardware

Hardware | Recursos
---------|-----------
CPU | Intel Core2 Duo E8400
Men| 5GB
HD| 250GB
Rede| 172.15.0.2 - 172.15.31.200


### Ajustes iniciais 
 Localização
 Verifica localização e ajustando para São Paulo

`timedatectl status`

`timedatectl list-timezones | grep Sao`

`timedatectl set-timezone America/Sao_Paulo`


## Sistema Operacional 

## Inventario (GLPI)

***
## Monitoramento (Zabbix)

1. Instalando os repositorio

~~~~Shell
# wget https://repo.zabbix.com/zabbix/5.0/ubuntu/pool/main/z/zabbix-release/zabbix-release_5.0-1+bionic_all.deb
# sudo dpkg -i zabbix-release_5.0-1+bionic_all.deb
# sudo apt update
~~~~

2. Instalando Zabbix server, frontend e agent

~~~~shell
# sudo apt install zabbix-server-pgsql zabbix-frontend-php php7.2-pgsql zabbix-apache-conf zabbix-agent`
~~~~

3. Criando base de dados inicial

You need to have database username user set up with permissions to create database objects.
Create Zabbix database on PostgreSQL with the following commands:

~~~~console
 # sudo -u postgres createuser --pwprompt zabbix
 # sudo -u postgres createdb -O zabbix zabbix
~~~~

Informação dos schema e data inicial:

~~~~shell
# zcat /usr/share/doc/zabbix-server-pgsql*/create.sql.gz | sudo -u zabbix psql zabbix
~~~~
4. Configuração do DB para Zabbix server

Edit server host, name, user and password in zabbix_server.conf as follows, replacing <username_password> with actual password of PostgreSQL user:

~~~~shell
# sudo nano /etc/zabbix/zabbix_server.conf
    DBName=zabbix
    DBUser=zabbix
    DBPassword=<username_password>
    DBPort=5432
~~~~
5. Configurar o PHP do Zabbix frontend

Edit file /etc/zabbix/apache.conf, uncomment and set the right timezone for you.

~~~~shell
# sudo nano  /etc/zabbix/apache.conf
    php_value date.timezone America/Sao_Paulo
~~~~

6. Iniciar o Zabbix server e agent no boot da hardware

Start Zabbix server and agent processes and make it start at system boot.
~~~~shell
# sudo systemctl restart zabbix-server zabbix-agent apache2
# sudo systemctl enable zabbix-server zabbix-agent apache2
# sudo service apache2 restart
~~~~
### Finalização da instalação no frontend
![tela 01](img-zabbix/1.png)
Confirmação das dependências
![tela 02](img-zabbix/2.png)
Configurações do acesso ao banco de dados
![tela 03](img-zabbix/3.png)
Detalhes do servidor, host, porta, hostname
![tela 04](img-zabbix/4.png)
Sumário da Pre-instalação
![tela 05](img-zabbix/5.png)
Finalização da instalação
![tela 06](img-zabbix/6.png)
Tela login
![tela 07](img-zabbix/7.png)
Dashboard inicial
![tela 08](img-zabbix/8.png)
Tela de configuração do perfil administrador 
![tela 09](img-zabbix/9.png)

### Ativação da tradução
A tradução é ativada através da localização do sistema

~~~~shell
sudo locale-gen pt_BR && sudo locale-gen pt_BR.UTF-8
~~~~

![tela 10](img-zabbix/10.png)

## Zabbix agent

~~~~shell
# sudo apt-cache search zabbix
~~~~~

    zabbix-agent - network monitoring solution - agent 
    zabbix-cli - Command-line interface for Zabbix monitoring system
    zabbix-frontend-php - network monitoring solution - PHP front-end
    zabbix-java-gateway - network monitoring solution - Java gateway
    zabbix-proxy-mysql - network monitoring solution - proxy (using MySQL)
    zabbix-proxy-pgsql - network monitoring solution - proxy (using PostgreSQL)
    zabbix-proxy-sqlite3 - network monitoring solution - proxy (using SQLite3)
    zabbix-server-mysql - network monitoring solution - server (using MySQL)
    zabbix-server-pgsql - network monitoring solution - server (using PostgreSQL)

~~~~shell
# sudo apt install zabbix-agent
~~~~
É necessário a edição do arquivo conf do agent ``sudo nano /etc/zabbix/zabbix_agentd.conf``, editando os campos 


## zabbix_get

Os controladores de domínio (adserver e ad2server) não estavam tendo acesso liberando acesso ao servidor do Zabbix, para verificar o motivo foi instalado a recurso zabbix_get e a verificação dos log's. 

O Zabbix Get é um utilitário de linha de comando que pode ser utilizado para se comunicar com o agente de monitoração do Zabbix e requisitar um dado do agente.

lado servidor
~~~~shell
# zabbix_get -s 172.15.0.3 -p 10050 -k system.hostname
~~~~
log do server
~~~~shell
# sudo tail -f /var/log/zabbix/zabbix_server.log
# sudo cat /var/log/zabbix/zabbix_server.log | grep "adserver"
~~~~


Lado agente adserver

~~~~shell
netstat -a | grep "zabbix"
~~~~
A solução que encontrei foi adicionar os dois endereços de IP do servidor do Zabbix

~~~~shell
# sudo nano /etc/zabbix/zabbix_agentd.conf 
   server=172.15.0.2, 172.15.31.200

# sudo service zabbix-agent restart 
# sudo tail -f /var/log/zabbix-agent/zabbix_agentd.log
~~~~

## Auto Descoberta e registro

Para facilitar o cadastro dos equipamentos foi utilizado o recurso de auto descoberta.

### Tela da Regra de Descoberta
![tela 11](img-zabbix/Regras_descoberta.png)

