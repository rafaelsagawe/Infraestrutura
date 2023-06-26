# Sobre a Infraestrutura

## Comparativo entre Hypervisors

Inicialmente utilizei o VMware como solução de virtualização, entretanto com o passar do tempo e estudos fui notando as limitações dele, pelo fato de ser de codigo proprietário, assim dificultando melhorias no sistema, então fui gradativamente subistituindo pelo ProxMox.

#### Um pequeno comparativo dos sistemas.

 -|Proxmox | VMware ESXI
 --|---|--
Base OS: |Debian GNU/Linux | VMware
License: | AGPL, v3 |Proprietary
Hypervisor: | KVM |VMware | 
OS-level virtualization: | Linux Container (LXC)
Architecture: | x86_64 | x86_64
Installation: | Bare-metall | Bare-metall
max. RAM und CPU: | 12TB and 768 | 6128GB and 576

![comparativo](/Hypervisor/img/hypervisor.jpeg)

## VMware ESXi 
É um hipervisor de nível empresarial tipo 1 desenvolvido pela VMware para implantar e servir computadores virtuais. Como hipervisor tipo 1, o ESXi não é um software aplicativo instalado em um sistema operacional; em vez disso, inclui e integra componentes vitais do sistema operacional, como um núcleo.

## ProxMox
Proxmox Virtual Environment é um ambiente de virtualização de servidores de código aberto. É uma distribuição Linux baseada no Debian com um kernel Ubuntu LTS modificado e permite a implementação e gerenciamento de máquinas virtuais e contêineres.

Este sistema é utilizado para criação rápida de instâncias de serviços com recursos de backups agendados, snapshot, Alta Disponibilidade e etc.
