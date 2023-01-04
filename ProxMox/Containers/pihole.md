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