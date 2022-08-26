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

## Realização de testes e verificações de funcionamento do Samba 4 
~~~ shell
# smbclient -L localhost -U Administrator
Password for [SEMED\Administrator]:

        Sharename       Type      Comment
        ---------       ----      -------
        netlogon        Disk      Domain logon service
        sysvol          Disk
        print$          Disk      Printer Drivers
        SRV_BKP         Disk
        Servidor        Disk
        IPC$            IPC       IPC Service (Univention Corporate Server)
SMB1 disabled -- no workgroup available
~~~

# Verificar se o serviço de DNS está funcionando fazendo as resoluções:

~~~ shell
# host -t A semed.pcni
semed.pcni has address 172.15.0.1

# host -t SRV _ldap._tcp.semed.pcni
_ldap._tcp.semed.pcni has SRV record 0 100 389 adserver.semed.pcni.

# host -t SRV _kerberos._udp.semed.pcni
_kerberos._udp.semed.pcni has SRV record 0 100 88 adserver.semed.pcni.

~~~

# Verificar o funcionamento do KERBEROS:

~~~ shell
# kinit administrator@SEMED.PCNI
administrator@SEMED.PCNI's Password:
# (não tem preriodo para expirar a senha)

# klist
Credentials cache: FILE:/tmp/krb5cc_0
        Principal: administrator@SEMED.PCNI

  Issued                Expires               Principal
Aug 26 18:26:35 2022  Aug 27 04:26:35 2022  krbtgt/SEMED.PCNI@SEMED.PCNI
~~~
## samba-tools

~~~ shell
# samba-tool domain level show
Domain and forest function level for domain 'DC=semed,DC=pcni'

Forest function level: (Windows) 2008 R2
Domain function level: (Windows) 2008 R2
Lowest function level of a DC: (Windows) 2008 R2

# samba-tool computer list
~~~
