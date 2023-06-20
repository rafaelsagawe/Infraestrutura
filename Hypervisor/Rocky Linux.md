# Instalação
 Instalação minima do Sistema Operacional

O Rocky Linux é um sistema operacional empresarial de código aberto projetado para ser 100% bug-a-bug compatível com o Red Hat Enterprise Linux®. Está em intenso desenvolvimento pela comunidade. 

## Criação de usuário
~~~~shell
# sudo adduser rafael
# sudo passwd rafael
~~~~

## Obtendo o IP
~~~~shell
# ip -c route
~~~~

## Pacotes basicos
~~~~shell
# sudo yum install nano htop
~~~~

## Ajustando o IP

~~~~shell
# nmtui
~~~~

# Instalação do Podman e cockpit

~~~~shell
# sudo dnf update
# sudo dnf -y install podman buildah 
# podman -v
# podman info

# sudo dnf install -y cockpit
# sudo dnf install -y cockpit-machines
# sudo dnf install -y cockpit-podman
# sudo systemctl start cockpit.socket
# sudo systemctl enable cockpit.socket
# sudo systemctl status cockpit.socket
# sudo firewall-cmd --add-service cockpit --permanent
# sudo firewall-cmd --reload
~~~~