# Sobre a Infraestrutura

![comparativo](/Hypervisor/img/hypervisor.jpeg)

## Tipos de virtualização

Existem duas categorias amplas de hipervisores: Tipo 1 e Tipo 2.

### Hipervisor tipo 1

Um hipervisor Tipo 1 é executado diretamente no hardware físico do computador, interagindo diretamente com sua CPU, memória e armazenamento físico.Por esse motivo, os hipervisores Tipo 1 também são chamados de hipervisores bare-metal. Um hipervisor Tipo 1 substitui o sistema operacional host.

Os hipervisores do tipo 1 são altamente eficientes porque têm acesso direto ao hardware físico. Isso também aumenta a segurança, pois não há nada entre eles e a CPU que um invasor possa comprometer. 

![Hipervisor tipo 1](https://www.gta.ufrj.br/ensino/eel879/trabalhos_vf_2010_2/luizaugusto/figuras/hipervisor1.jpg)

### Hipervisor tipo 2

Um hipervisor Tipo 2 não é executado diretamente no hardware subjacente. Em vez disso, ele é executado como um aplicativo em um sistema operacional. Os hipervisores do tipo 2 raramente aparecem em ambientes baseados em servidor. Em vez disso, eles são adequados para usuários individuais de PC que precisam executar vários sistemas operacionais. Os exemplos incluem engenheiros, profissionais de segurança que analisam malware e usuários corporativos que precisam acessar aplicativos disponíveis apenas em outras plataformas de software.

![Hipervisor tipo 2](https://www.gta.ufrj.br/ensino/eel879/trabalhos_vf_2010_2/luizaugusto/figuras/hipervisor2.jpg)


## Comparativo entre Hypervisors (Bare metal)

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

## VMware ESXi 

É um hipervisor de nível empresarial tipo 1 desenvolvido pela VMware para implantar e servir computadores virtuais. Como hipervisor tipo 1, o ESXi não é um software aplicativo instalado em um sistema operacional; em vez disso, inclui e integra componentes vitais do sistema operacional, como um núcleo.

## ProxMox

Proxmox Virtual Environment é um ambiente de virtualização de servidores de código aberto. É uma distribuição Linux baseada no Debian com um kernel Ubuntu LTS modificado e permite a implementação e gerenciamento de máquinas virtuais e contêineres.

Este sistema é utilizado para criação rápida de instâncias de serviços com recursos de backups agendados, snapshot, Alta Disponibilidade e etc.
