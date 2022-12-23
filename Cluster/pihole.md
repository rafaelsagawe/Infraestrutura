 # Definição
 Pi-hole é um bloqueador de anúncios em nível de rede que atua como um buraco negro de DNS e, opcionalmente, um servidor DHCP, destinado ao uso em uma rede privada.
 
 # Instalação em container proxmox

## Configuração do container
Caracteristica | usado
--|--
Template | debian-10-standard_10.7-1_amd64.tar.gz
Disk size | 30gb
Memory | 1024mb
Network | 172.15.1.1

Primeiramente atualizar os sistema e dependencias

~~~~shell
# apt update
# apt upgrade
# apt install curl htop
~~~~

Instalador
~~~~shell
# git clone --depth 1 https://github.com/pi-hole/pi-hole.git Pi-hole
# ls
# cd Pi-hole/automated\ install/
~~~~
Dar permições da instalação e as configurações iniciais, será instalado o sistema com sua interface de administação

E necessario a criação da senha do usuário admin
~~~~shell
# pihole -a -p
~~~~



   31  cd /etc/pihole
   32  ls
   33  dir
   34  ls -lha
   35  chmod 777 pihole-FTL.db 
   36  chmod 664 pihole-FTL.db
   37  chown pihole.pihole pihole-FTL.db
   38  chmod 664 pihole-FTL.db
   39  reboot 
   40  cd /etc/pihole
   41  usermod -aG pihole www-data
   42  reboot 
   43  chown -R pihole:pihole /etc/pihole
   44  ping chat
   45  ping chat.semed.pcni
   46  reboot 
   47  htop
   48  cd /etc/ssh/
   49  ls
   50  nano sshd_config 
   51  service ssh restart 
   52  ping chat.semed.pcni
   53  ping chat
   54  dig chat
   55  dig chat.semed.pcni
   56  who chat.semed.pcni
   57  whoami chat.semed.pcni
   58  who
   59  who chat.semed.pcni
   60  dig chat.semed.pcni
