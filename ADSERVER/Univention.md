# Conheça o Univention Corporate Server

O Univention Corporate Server (UCS) é um dispositivo de software escalável e baseado em Linux de código aberto para a gestão de identidade, infraestrutura de TI e serviços. Oferece serviços básicos para gerenciar usuários, grupos e computadores. Além disso, o UCS também contém uma ampla variedade de aplicativos de servidor, ou seja, para gestão de IP (DNS/DHCP), soluções de correio e groupware, ferramentas de compartilhamento e sincronização de arquivos, pacotes de escritório online, ferramentas de gestão de projetos, soluções de planejamento de recursos empresariais (ERP na sigla em inglês), entre outros, tudo disponível no Univention App Center.

Como nome de estrutura de domínio foi optado o uso de SEMED.PCNI, assim gerando uma identidade única sem gerar conflitos com os serviços de DNS.

O sistema se encontra virtualizado em uma instância do ProxMox

## Recursos de hardware da VM
Recurso | Descrição
----|----
CPU| So
Memoria|
Disco|

# Checagens

## samba-tools

~~~ shell
samba-tool computer list
~~~
