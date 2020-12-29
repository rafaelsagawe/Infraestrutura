# Storage – NAS

Uma unidade NAS é essencialmente um servidor conectado a rede, com a funcionalidade única de promover serviços de armazenamento de dados para outros dispositivos da rede. Estas unidades não são desenvolvidas para tarefas computacionais em geral, apesar de tecnicamente ser possível executar outros softwares nelas. 

Geralmente, as unidades não possuem teclado ou monitor, e são configuradas pela rede, normalmente através de um browser.

Sistemas NAS podem conter mais de um HD, podendo também contar com a tecnologia RAID, centralizando a responsabilidade de servir os arquivos em uma rede e deste modo liberando recursos de outros servidores desta rede. 

Os protocolos utilizados pelo NAS são:
* **AFP** - Compartilhamento para equipamentos Apple; 
* **NFS** - usado por sistemas Unix;
* **SMB/CIFS** - usado em ambientes Microsoft Windows;
* **Webdav** - para acessar arquivos via HTTP.

------

# Como escolher os HDs para suar no Samba 4

Há 2 formas de instalação

Para te ajudar a fazer uma escolha acertada nesse item temos que levar em consideração alguns fatores que influenciarão na escolha.

Os fatores que devemos levar em conta é o tamanho do projeto, a verba do projeto o tanto de espaço que precisamos e o local de armazenamento dos dados.

## Projeto Pequeno

Levando a consideração a verba do projeto e se essa verba for baixa opte então por HD que possa te dar espaço e que o desempenho não seja a principal prioridade e nesse caso HDs SATAs será a melhor escolha.

A única optimização que você pode fazer nesse caso é separar os dados da empresa em um HD separado , evite usar HD único para instalação e armazenamento de dados.

## Projeto Médio

Quando você tem uma verba um pouco mas generosa, opte por HDs SAS de 10 K pois é são HD's corporativos de alto desempenho e capacidade, Assim se seu projeto é pequeno mas evoluindo para médio porte, você estará contando com o melhor dos dois mundos capacidade e desempenho .

A optimização que você pode fazer aqui é colocar o sistema em HD SATA e os dados no HD SAS de 10k pois você terá melhor desempenho de leitura e escrita nesse tipo de HD.

## Projeto Grande

Classifique os dados de acordo com a frequência de acesso, esta técnica é chamada de Tierização onde podemos separar de forma automática os dados que frequentemente são acessados em HDs mais rápidos, dados que são acessados de vez em quando em HDs de velocidade media e dados que quase nunca são acessados em HDs de velocidade mais baixa e ou até mesmo em fitas para um arquivo morto.

### Dica

Não use HDs em seu servidor sem antes fazer um teste Burn-in em todos os quais for usar.

O que é teste Burn-in ? Como testar seu HD ?

~~~~
É um teste que se faz em equipamentos e ou peças de eletrônicos para aplicar um stress, para identificar problemas. A teoria é que alguns componentes já apresentam problemas nas primeiras horas ou dias de uso. O teste Burn-in pode ajudar a identificá-los. Tem vários softwares para isso.

Alguns fabricantes já fazem os seus testes Burn-in nos seus equipamentos, mas alguns fazem apenas por amostragem , ou seja, nem todos os equipamentos são testados, apenas alguns lotes e por isso HDs defeituosos ou mais frágeis podem chegar até você.
~~~~

------

# Como escolher o Sistema de Arquivos para o Samba 4

São várias opções interessantes.

No item sistema de arquivos, para fazer uma boa escolha, não se esqueça de que é importante que ele contenha as features necessárias à administração e ao tamanho de arquivos do Samba, inclusive no que se refere ao espaço total de armazenamento.

Leve em consideração o quadro abaixo :

Segundo o quadro acima de acordo com o sistema de arquivos que você escolher, poderá usar ou não as features abaixo :

 

 

Posfix ACL

No mundo Linux as permissões nos arquivos e diretórios são configuradas de forma diferente como é no Windows e quando trabalhamos em um ambiente misto Windows e Linux, precisamos que o nosso servidor de arquivos Samba seja capaz de mapear as permissões como são no Windows e é isso que essa feature permite. 
Vantagem : Permissões iguais a do Windows 
 
 
Cotas de Disco

Essa feature permite limitar por usuário ou grupo o espaço usado por estes , possibilitando assim o controle do quanto cada um pode armazenar no servidor .
Vantagem : Usuários que realmente precisam de espaço, não são prejudicados por usuários que não precisam tanto.
 
Filesystem Shrink

Essa feature se resume na capacidade que o sistema de arquivos tem de permitir o redimensionamento sem perda de dados .

Vantagem : Redimensionamento de discos sem perda de dados.

 


Compressão de dados.
O sistema de arquivos fará a compressão dos dados fazendo uma melhor distribuição dos dados e economizando espaço .
Vantagem : Economia de espaço em Discos.

 

Deduplicação ou Desduplicação

Esta fature é importante em servidores onde a preocupação com dados duplicados é real , pois ao perceber que o dado já existe não é criado um outro endereçamento de dado no sistema de arquivos, possibilitando manter os dados sem ocupar o mesmo espaço, gerando economia de armazenamento. 
Vantagem: Não haverá multiplicação de uso de espaço em disco por arquivos duplicados .

 

 

Snapshots

O sistema de arquivos será capaz de criar subvolumes e congelar-se tirando uma “foto”, possibilitando que, se houver alguma alteração mal sucedida, possamos revertê-la voltando o sistema para o estado anterior. 
Vantagem: Podemos recuperar um sistema de arquivos defeituoso apenas voltando o snapshot.
 
Redundância

Com esta feature no seu sistema de arquivos será possível ter redundância de dados sem recorrer à implementação de RAID.
Vantagem : Redundância de dados sem uso de RAID
 
Sistema de Arquivos distribuídos

Aqui os dados são distribuídos entre servidores possibilitando a recuperação se um dos servidores falhar , fazendo o failover, pois os dados não são armazenados em uma matriz única e sim em vários servidores de forma consistente e dinâmica.
Vantagem : Dados distribuídos em vários servidores , possibilitando a continuidade de acesso aos dados mesmo que um dos servidores esteja off-line.

 



------



# NAS da SEMED
Para a criação do Servidor NAS da SEMED, foi escolhido o FreeNAS, não apenas por ser um Sistema NAS altamente utilizado, mas sim pelas suas ferramentas, em especial os snapshots do *ZFS* e a deduplicação de arquivos. Ele tem suporte suporte aos principais protocolos: **CIFS (Samba)**, FTP, NFS, rsync, protocolo AFP, iSCSI, *S.M.A.R.T.*, autenticação local de usuários e em **Domínio**, e RAID (0,1,5) via software, com uma configuração baseada em internet. Instalado em HD ou pen-drive USB para o OS e outros para a criação dos *volumes*.

### Criando o Volume
Fui utilizado como padrão a nova interface do FreeNAS-11.2-U4.1.

#### Criando o Volume (Pool)

Para criar os compartilhamentos torna-se necessário a criação do Volume (Pool), possibilitando a implantação de RAID através de software.

Em Storage => Pools => ADD, escolha os discos.

* Name: Nome do Volume criado, este item não e possível ser trocado;
* Comments: Comentário;
* Compression Level: Nível de compressão de dados do volume, assim gerando maior espaço em disco;
* Share Type: Tipo de compartilhamento:
    * Unix, redes Linux;
    * Windows, sendo o padrão para rede com computadores windows;
    * Mac, redes com equipamentos Apple;

* ZFS Deduplication: Função para a realização da deduplicação dos arquivos, mantendo um arquivo e ciando atalhos para esse arquivo mantido, assim reduzindo o quantitativo real de arquivos assim liberando espaço no Volume;
* Snapshot directory: permite a visualização das pastas dos Snapshots;
    * Invisible: não visualiza a pasta;
    * Visible: visualiza a pasta.

### Criando pasta de compartilhamento
Para acessar o Volume recém-ciado torna-se necessário a criação dos compartilhamentos, em Sharing => Windows (SMB) Shares.
Path: Caminho da Pasta compartilhada, tendo sido usado diretamente a raiz do Volume, por padrão sendo montando em mnt (/mnt/SEMED);
 Name: Nome do compartilhamento que será visível para os usuários;
        ◦ Browsable to Network Clients:
        ◦ Export Recycle Bin:
        ◦ Allow Guest Access:
        ◦ Only Allow Guest Access:
VFS Objects:
Periodic Snapshot Task:
Auxiliary Parameters:

Integrando no Domínio 
Hostname e NetBios devem ser iguais.
Ajuste dos DNSs
Ajustar o NTP


---------
## Comandos para testar integração
* wbinfo -t 
* wbinfo -v
* wbinfo -u
* wbinfo -g
* getent passwd
* getent group

### Ajuste de permissões
Para tornar acessível os arquivos dos setores no compartilhamento do NAS e necessário ajustar as permissões dos arquivos e pastar.

Ajustar no NAS, estes procedimentos iram restar as configurações de permissões dos arquivos para o padrão;

* Em Storage => Pools (Local dos Volumes);

* Nas configurações em Edit Dataset; 
   * Share Type = Windows;
       * Nas configurações em Edit Permissions, 
           * ACL Type = Windows;
           * **User = nobody;**
           * Group = SEMED-NI\domain users;
           * Apply permissions recursively;

Ajustes no **Windows**, esses passos ajustaram para as configurações de grupos do domínio;
Nas propriedades da pasta aba Segurança => Avançadas => Alterar Permissões;
            A. Desmarque o item Incluir permissões herdáveis…;
            B. Adicionar os Grupos que acessarão a pasta;

----
## Administrando o FreeNAS Autenticado 
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
Via SSH editar o arquivo do repositório;
 nano /usr/local/etc/pkg/repos/local.conf
	local: {
	    url: "file:///usr/ports/packages",
	    enabled: yes
		}
De enabled: yes para enabled: false;
nano /usr/local/etc/pkg/repos/FreeBSD.conf
      FreeBSD: {
 enabled: no
}
Para enabled: no para enabled: yes
Buscar atualizações
pkg update
Buscar os programas do FusionInventory
pkg search fusioninventory
Instalação do agente
pkg install p5-FusionInventory-Agent 
Copiar o arquivo de modelo de configuração
cp /usr/local/etc/fusioninventory/agent.cfg.sample /usr/local/etc/fusioninventory/agent.cfg
Ajustando o endereço do fusioninventory
nano /usr/local/etc/fusioninventory/agent.cfg
Programas Extras
A instalação de programas são bloqueadas por padrão no FreeNAS, mas como esse bloqueio foi burlado para a instalação do fusioninventory podemos instalar outros recursos para facilirar a adminitração, como:
grp – cores Geniricas, trazendo cores para o comando tail, # pkg install grc;
glances – Visualização detalhada dos recursos consumidos, # pkg install py36-glances-3.1.0;
