Storage – FreeNAS
Uma unidade NAS é essencialmente um servidor conectado a rede, com a funcionalidade única de promover serviços de armazenamento de dados para outros dispositivos da rede. Estas unidades não são desenvolvidas para tarefas computacionais em geral, apesar de tecnicamente ser possível executar outros softwares nelas. Geralmente, as unidades não possuem teclado ou monitor, e são configuradas pela rede, normalmente através de um browser.
Sistemas NAS podem conter mais de um HD, podendo também contar com a tecnologia RAID, centralizando a responsabilidade de servir os arquivos em uma rede e deste modo liberando recursos de outros servidores desta rede. Os protocolos utilizados pelo NAS são:
    • AFP, Compartilhamento para equipamentos Apple; 
    • NFS, usado por sistemas Unix;
    • SMB/CIFS, usado em ambientes Microsoft Windows;
    • Webdav, para acessar arquivos via HTTP.
FreeNAS é NAS, suportando: CIFS (Samba), FTP, NFS, rsync, protocolo AFP, iSCSI, S.M.A.R.T., autenticação local de usuários e em Domínio, e RAID (0,1,5) via software, com uma configuração baseada em internet. Instalado em HD ou pen-drive USB para o OS e outros para a criação dos volumes1.
Fui utilizado como padrão a nova interface do FreeNAS-11.2-U4.1.
Criando o Volume (Pool)
Para criar os compartilhamentos torna-se necessário a criação do Volume (Pool), possibilitando a implantação de RAID através de software. 
Em Storage => Pools => ADD, escolha os discos.
    • Name: Nome do Volume criado, este item não e possível ser trocado;
    • Comments: Comentário;
    • Compression Level: Nível de compressão de dados do volume, assim gerando maior espaço em disco;
    • Share Type: Tipo de compartilhamento:
        ◦ Unix, redes Linux;
        ◦ Windows, sendo o padrão para rede com computadores windows;
        ◦ Mac, redes com equipamentos Apple;
    • ZFS Deduplication: Função para a realização da deduplicação dos arquivos, mantendo um arquivo e ciando atalhos para esse arquivo mantido, assim reduzindo o quantitativo real de arquivos assim liberando espaço no Volume;
    • Snapshot directory: permite a visualização das pastas dos Snapshots;
        ◦  Invisible: não visualiza a pasta;
        ◦ Visible: visualiza a pasta.
Criando pasta de compartilhamento
Para acessar o Volume recém-ciado torna-se necessário a criação dos compartilhamentos, em Sharing => Windows (SMB) Shares.
    • Path: Caminho da Pasta compartilhada, tendo sido usado diretamente a raiz do Volume, por padrão sendo montando em mnt (/mnt/SEMED);
    •  Name: Nome do compartilhamento que será visível para os usuários;
        ◦ Browsable to Network Clients:
        ◦ Export Recycle Bin:
        ◦ Allow Guest Access:
        ◦ Only Allow Guest Access:
    • VFS Objects:
    • Periodic Snapshot Task:
    • Auxiliary Parameters:

Integrando no Domínio 
Hostname e NetBios devem ser iguais.
Ajuste dos DNSs
Ajustar o NTP


---------

Comandos para testar integração
    • wbinfo -t 
    • wbinfo -v
    • wbinfo -u
    • wbinfo -g
    • getent passwd
    • getent group
Ajuste de permissões
Para tornar acessível os arquivos dos setores no compartilhamento do NAS e necessário ajustar as permissões dos arquivos e pastar.
    I. Ajustar no NAS, estes procedimentos iram restar as configurações de permissões dos arquivos para o padrão;
        1. Em Storage => Pools (Local dos Volumes);
        2. Nas configurações em Edit Dataset; 
            A. Share Type = Windows;
        3. Nas configurações em Edit Permissions, 
            A. ACL Type = Windows;
            B. User = nobody;
            C. Group = SEMED-NI\domain users;
            D. Apply permissions recursively;
    II. Ajustes no Windows, esses passos ajustaram para as configurações de grupos do domínio;
        1. Nas propriedades da pasta aba Segurança => Avançadas => Alterar Permissões;
            A. Desmarque o item Incluir permissões herdáveis…;
            B. Adicionar os Grupos que acessarão a pasta;



----

Administrando o FreeNAS Autenticado 
Criação de Usuários 
A criação dos usuários é feita pelo Controlador do Domínio, a regra de acesso funciona através dos Grupos que o usuário faz parte. 
Criação de pastas e regra de acesso
A criação das pastas na raiz do servidor é realizada apenas pelos administradores do domínio, assim evitando a criação de pastas sem autorização prejudicando a segurança da informação.
A pasta é criada normalmente pelo Windows usando um perfil de administrador, a pois a criação e necessário ajustar a segurança da pasta, nas propriedades da pasta na aba segurança, em Avançadas deve Desabilitar Herança e adicionar o grupo que terá acesso a pasta (e recomendado sempre adicionar o Domain Admin para ter acesso as pastas em uma situação de emergência), voltando na aba segurança de permissão de Controle Total para o grupo inserido.
Versões Anteriores
O Servidor NAS2 conta com uma função chamada de Snapshots, (Cópia instantânea) ele cria de forma automáticas cópias dos arquivos em uso sendo possível retornar o arquivo para sua formatação anterior, o recurso foi configurado para manter está cópia por 5 dias, sendo realizado das 8:00 as 20:00 durante os dias uteis da semana.
Nas propriedades da pasta ou arquivo, aba Versões Anteriores, selecione o ponto desejado e clique em abrir.
Auditoria SMB
https://www.profissionaisti.com.br/2015/09/auditoria-e-rotacionamento-de-logs-em-servidores-de-arquivos-linux/
https://www.ixsystems.com/community/threads/solved-freenas-8-3-0-log-users-activity-with-full_audit-vfs-object.10076/

Por padrão os log’s dos arquivos estão salvos no arquivo “/var/log/messages” e se apresentam da seguinte forma: 
“Feb 25 08:13:06 nas2 smbd_audit[9407]: open . (fd 53)” 
Assim dificultando a leitura dos Log’s, para tornar mais clara a leitura e auditável torna-se necessário acrescentar parâmetros auxiliares nas configurações do Serviço do Samba, como esses:
vfs objects = full_audit
full_audit:prefix = %u|%I|%S
full_audit:failure = connect
full_audit:success = connect disconnect opendir mkdir rmdir closedir open close read pread write pwrite sendfile rename unlink chmod fchmod chown fchown chdir ftruncate lock symlink readlink link mknod realpath
full_audit:facility = LOCAL5
full_audit:priority = NOTICE
Para monitorar o arquivo de log está sendo usado o tail, através do comando:
tail -F /var/log/messages | grep smbd_audit
#       Consult the syslog.conf(5) manpage.
*.err;kern.warning;auth.notice;mail.crit                /dev/console
#*.notice;authpriv.none;kern.debug;lpr.info;mail.crit;news.err  /var/log/messages
local5.=info            /mnt/Usuarios/TI/docs.log
local5.=notice          /mnt/Usuarios/TI/activity.log
local0.notice;local1.notice;local2.notice;local3.notice /var/log/messages
local4.notice;local6.notice;local7.notice               /var/log/messages

Restaurando Volumes
Em situação de troca do Sistema Operacional torna-se necessário a restauração dos volumes.
Na dashboard em Storage => Import Disk, escolha o disco e o FileSystem Type.
Sincronização de arquivos
O Windows tem a função de sincronização de arquivos entre servidor e cliente, com este recurso e possível acessar os arquivos do compartilhamento mesmo sem rede. Para utilizar este recurso basta clicar com o botão direito do mouse na pasta que deseja, escolha a opção Sempre disponível offline, assim quando o servidor e o cliente não estiverem se comunicando o cliente continua tendo acesso aos arquivos, quando o acesso for restabelecido as alterações feitas serão sincronizadas com o servidor.
Transferindo arquivos entre servidores
Para as realizações periódicas dos servidores de arquivos torna-se necessário a transferência dos arquivos entre eles. Para a realização da tarefa foi usado o ‘SCP’ recurso do protocolo SSH.
Exemplo: scp -r Internet/ root@nas2:/mnt/Usuarios/TI

Incluindo o FreeNAS no Inventario do GLPI
    • Via SSH editar o arquivo do repositório;
 nano /usr/local/etc/pkg/repos/local.conf
	local: {
	    url: "file:///usr/ports/packages",
	    enabled: yes
		}
    • De enabled: yes para enabled: false;
    • nano /usr/local/etc/pkg/repos/FreeBSD.conf
      FreeBSD: {
 enabled: no
}
    • Para enabled: no para enabled: yes
    • Buscar atualizações
pkg update
    • Buscar os programas do FusionInventory
pkg search fusioninventory
    • Instalação do agente
pkg install p5-FusionInventory-Agent 
    • Copiar o arquivo de modelo de configuração
cp /usr/local/etc/fusioninventory/agent.cfg.sample /usr/local/etc/fusioninventory/agent.cfg
    • Ajustando o endereço do fusioninventory
nano /usr/local/etc/fusioninventory/agent.cfg
Programas Extras
A instalação de programas são bloqueadas por padrão no FreeNAS, mas como esse bloqueio foi burlado para a instalação do fusioninventory podemos instalar outros recursos para facilirar a adminitração, como:
    • grp – cores Geniricas, trazendo cores para o comando tail, # pkg install grc;
    • glances – Visualização detalhada dos recursos consumidos, # pkg install py36-glances-3.1.0;
    • 