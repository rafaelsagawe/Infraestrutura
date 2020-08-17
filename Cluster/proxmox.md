# Ativando SMNP
O Proxmox por ser tratar de uma distribuição baseada no Debian tem sua ativação realizada através  da instalação dos pacotes “.deb” pelo comando, “apt install snmpd lm-sensors snmptrapd” tendo o pacote instalado e necessário a configuração o arquivo “smnpd.conf”:
    1. Criar o backup do arquivo smnpd.conf, mv /etc/snmp/snmpd.conf /etc/snmp/snmpd.conf.ori;
    2. Criar um arquivo smnpd.conf, nano smnpd.conf;
~~~~shell
# this create a  SNMPv1/SNMPv2c community named "my_servers"
# and restricts access to LAN adresses 192.168.0.0/16 (last two 0's are ranges)
rocommunity public 172.15.0.0/16
# setup info
syslocation  "CPD"
syscontact  "semed.ni.ti@gmail.com"
# open up
agentAddress  udp:161
# run as
agentuser  root
# dont log connection from UDP:
dontLogTCPWrappersConnects yes
# fix for disks larger then 2TB
realStorageUnits 0

~~~~
       
3. Ativar exceção no firewall, iptables -A INPUT -s 172.15.0.0/16 -p udp --dport 161 -j ACCEPT;
4. Reiniciar o  daemon do SMNP, service snmpd restart;
5. Tornar o protocolo ativo por padrão, update-rc.d snmpd enable.


nano /etc/apt/sources.list
deb http://deb.debian.org/debian stretch main contrib non-free
deb-src http://deb.debian.org/debian stretch main contrib non-free

deb http://security.debian.org/debian-security/ stretch/updates main contrib non-free
deb-src http://security.debian.org/debian-security/ stretch/updates main contrib non-free

deb http://deb.debian.org/debian stretch-updates main contrib non-free
deb-src http://deb.debian.org/debian stretch-updates main contrib non-free
apt update
apt-get install snmp-mibs-downloader