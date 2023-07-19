# Hypervisor de Infraestrutura
VMware ESXi é um hypervisor de nível empresarial tipo 1 desenvolvido pela VMware para implantar e servir computadores virtuais. Como hypervisor tipo 1, o ESXi não é um software aplicativo instalado em um sistema operacional; em vez disso, inclui e integra componentes vitais do sistema operacional, como um núcleo.

# Ativando o SMNP
Para monitorar os recursos do Vmware foi ativado o protocolo SMNP, para isto e necessário acessar via SSH o servidor do Wmware.
    1. ssh root@vmware;
    2. esxcli system snmp set --communities public;
    3. esxcli system snmp set --enable true.