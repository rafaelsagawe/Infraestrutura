#!/bin/bash
sudo apt update
sudo apt upgrade -y
sudo apt remove --purge snapd gnome-software-plugin-snap
sudo rm -rf /var/cache/snapd
sudo rm -rf ~/snap
sudo apt remove --purge apport-symptoms apport apport-gtk
sudo apt autoremove
#adicionar nas linhas finais /etc/sysctl.conf, altera o uso do swap usando seria como usar quando atingir 90%
#vm.swappiness=10
#vm.vfs_cache_pressure=50

# verificar itens que estao inicalizando com o sistema
#$ sudo systemd-analyze blame

# Seguranca contra ataque de spoof
# Descomentar as linhas
#$ sudo nano /etc/sysctl.conf
        #net.ipv4.conf.default.rp_filter=1
        #net.ipv4.conf.all.rp_filter=1
        #net.ipv4.tcp_syncookies=1
#$  sudo sysctl -p

# remover monitores de logs de sistemas não usados
#$ sudo nano /etc/rsyslog.d/50-default.conf
#$ sudo systemctl restart rsyslog.service