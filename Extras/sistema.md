# Administração do sistemas baseados em Linux/

## Distribuições do Linux 

Um sistema Linux nunca foi entregue "sozinho", contendo apenas o sistema operacional. Desde o início eram criadas versões chamadas  "distribuições", que continham além do Sistema Operacional Linux (o chamado kernel do Linux), uma série de aplicativos e utilitários. 

Tabela de distribuições

Distribuição | Versão | Kernel | Empresa | pais | Base
-------------|--------|--------|---------|------|-----
Fedora | | | Red Hat | EUA | RedHat
OpenSuSE | | | Novell | ALE | RedHat
Debian | | |  - | EUA | Debian
Ubuntu| | | Canonical | AF. S | Debian
Slackware| | | - | EUA | Slackware

## Configurações Iniciais do Ambiente

Primeiramente precisamos ser os **super usuário de sistema**, ou seja, usuário root, para isso usamos o comando **sudo + su** assim, ``$ sudo su`` permite que possamos nos conectar como outro usuário para executarmos comandos no sistema, outra forma de usar super usuário é iniciar os comandos com **sudo**.

Lembre-se de que o super usuário no sistema Linux pode executar qualquer comando no sistema. Por padrão, essa credencial vem desativada no sistema e somente pode ser acessada por meio do comando sudo. A senha desse usuário é a mesma que definimos na instalação.

### Interface de rede

Inicialmente, essa interface vem configurada automaticamente, ou seja, a configuração de endereçamento IP para o servidor está automática.

Para tornar fixo o IP no Servidor Linux com a distribuição Ubuntu é necessário editar o arquivo de configurações. O arquivo que precisamos editar possui o nome *interfaces* e localiza-se no diretório ``/etc/network``. Para editar o arquivo interfaces, vamos utilizar um editor de textos do sistema chamado **nano**. Logo, para realizar a ação, devemos digitar:

Depois de usar o sudo su.
~~~~shel
# nano /etc/network/interfaces
~~~~

Ou com o sudo na frente do comando.
~~~~shell
$ sudo nano /etc/netwoks/inferfaces
~~~~

Altere as informações de configuração do arquivo interfaces para as configurações abaixo:

        iface eth0 inet static
        address 10.0.2.3
        netmask 255.255.255.0
        gateway 10.0.2.2
        dns-nameserver 8.8.8.8

Salve o arquivo pressionando as teclas CTRL + O, confirmando o nome do arquivo. Em seguida, pressione CTRL + X para sair e retornar ao sistema. Reinicie o servidor com o comando:
~~~~shell
# shutdown –r now
~~~~
Após o processo de reinicialização, faça login novamente no sistema para verificarmos se as configurações de rede foram executadas com sucesso. Para tanto digite o comando abaixo:
~~~~shell
# ifconfig
~~~~
## Gerenciamento de Pacotes

No Linux todos os utilitários, aplicativos, comandos e servidores (daemons), são programas. Alguns programas são utilizados para iniciar outros programas, como o Bash Shell. Outros são utilizados para finalizar todos os programas, como o Shutdown. 

O gerenciador de instalação denomina pacote todos os programas do Linux, será utilizado o termo Pacote, para se referir a qualquer programa instalável no Linux. 

Em cada distribuição Linux que utiliza a instalação através de pacotes DEB (que seguem a linha do DEBIAN, como o caso do Ubuntu), existe um arquivo no diretório /etc/apt chamado “sources.list”, que contém a listagem de repositórios oficiais da distribuição os quais serão consultados quando solicitarmos a instalação de programas e utilitários. 

Um cache dos programas e utilitários já instalados pode ser localizado no caminho /var/cache/apt. 

Ao se editar o arquivo de fontes, devemos observar as primeiras linhas de texto onde é possível identificar a versão corrente do sistema em execução (desde que o arquivo seja o original do sistema).

O trecho a seguir apresenta essas informações de nosso sistema:

    # deb cdrom:[Ubuntu 14.04.3 _Trusty Tahr_ - Beta amd64 (20150805)]/ trusty main restricted

Outra forma de se identificar a versão do sistema em execução é por meio do comando lsb_release. No prompt de comandos do sistema, digite o seguinte comando:

~~~~shell
$ lsb_release -a
~~~~

Atualmente, as principais distribuições Linux incluem um utilitário que auxilia a instalação dos pacotes, tornando esta tarefa muito simples. No caso do Ubuntu, este utilitário é chamado de **APT** (Advances Packaging Tool).

### Utilitário apt 
Primeiramente, devemos atualizar a listagem de programas dos repositórios por meio do comando:
~~~~shell
$ sudo apt-get update
~~~~
Esse comando irá consultar a listagem de repositórios do arquivo sources.list informado anteriormente e, em cada repositório, irá verificar se há alterações nos conteúdos comparado ao que ele possui em cache local (/var/cache/apt). Caso haja alterações, ele recupera essas informações e atualiza a base de dados local.

*Lembre-se: para a execução do utilitário APT, é necessário estarmos em modo de super
usuário. Caso ainda não esteja, habilite esse modo com o comando sudo su.*

Uma vez que a base de dados dos repositórios foi atualizada, podemos localizar pacotes que podem ser instalados para o servidor. Para tanto, devemos utilizar o comando:
~~~~shell
# apt-cache search 'palavra-chave'
~~~~
Onde 'palavra-chave' deve ser substituído pelo nome (completo ou parcial) do pacote que se deseja localizar.
Por exemplo, se desejarmos localizar um pacote que contenha a palavra browser, deveríamos fornecer o comando:

~~~~shell
# apt-cache search browser
~~~~

Em resumo, podemos dizer que existem três formas de instalar programas no Linux:
1. Usar o **apt-get** ou outro gerenciador de pacotes para instalar pacotes próprios da distribuição em uso. Esta é a forma mais simples e menos passível de problemas, que você usa sempre que possível.

2. Programas com instaladores próprios, destinados a funcionar em várias distribuições. Eles também são simples de instalar, mas não tão simples quanto usar o apt-get. Muitos programas são distribuídos apenas desta forma, como o VMware, usando o utilitário **dpkg**.

3. Instalar o programa a partir do código fonte, o que pode ser necessário no caso de aplicativos pouco comuns, que não estejam disponíveis de outra forma, compilando a aplicação.

#### Instalação de programas

Para instalar pacotes, você deve digitar o comando:
~~~~shell
$ sudo apt-get install <nome_do_pacote>
~~~~

onde *nome_do_pacote* deve ser substituído pelo nome do programa que se deseja instalar. Por exemplo, caso desejamos instalar o programa de monitoramento de portas de comunicação, poderíamos entrar com o seguinte comando:
~~~~shell
# apt-get install nmap
~~~~
Veja que o apt-get cuida de toda a parte complicada do processo de instalação de programas, analisando as dependências necessárias para que o programa informado na linha de comando possa ser instalado.

ATENÇÃO: quando a instalação de programas ocorre a partir do código-fonte, o administrador deve instalar TODAS as dependências necessárias antes da instalação do programa desejado. Caso contrário, o sistema operacional irá reclamar as dependências.

## Gerenciamento de Processos
# Unidade 9



## Arquivos de Log

Quando um processo executa uma tarefa de maneira errada, por erro no código ou por falha em algum equipamento, é desejável que alguma informação referente a esse erro seja passada ao usuário do sistema, para que o mesmo possa corrigir o erro (quando for no código) ou evitá-lo (quando for em um equipamento).

Os arquivos de Log são utilizados para auxiliar o usuário nesta tarefa de detecção de erros na execução dos processos. Quando um processo não consegue completar uma tarefa com sucesso, ou seja, há uma falha na execução da tarefa, algumas informações são gravadas para que o usuário possa avaliar o que aconteceu durante a execução daquela tarefa.

A principal ferramenta no Linux para a gravação dos arquivos de Log é o utilitário SYSLOG.

### Syslog

O SYSLOG realiza a tarefa de gravar mensagens referentes a:

    1. Execução de processos;
    2. Mensagens do kernel.

Este utilitário é dividido em 3 módulos:

    1. syslogd: daemon responsável pelo Log dos processos;
    2. OpenLog: conjunto de funções para serem utilizadas em programas que serão gerenciados pelo SYSLog;
    3. Logger: utilitário de linha de comando, que permite interagir com o SYSLog modificando algumas características da gravação dos Log's.

O mais importante dos 3 módulos é o syslogd que fará o controle e gravação dos Log's dos processos.

### rsylogd

O rsyslogd é o daemon responsável por capturar os Log's de todos os processos, inclusive do kernel. Geralmente os arquivos de Log são gravados no diretório ``/var/log``, mas esse local pode variar de uma distribuição para outra.

Os arquivos de Log são gravados geralmente com o nome do processo que gerou o Log seguido da extensão “.log”:

Arquivo | Descrição
--------|------------
boot.log |Informações sobre a inicialização do sistema.
auth.log |Informações sobre autenticação.
kern.log |Logs gerados pelo kernel. 
syslog |Logs de mensagens gerais.

### Visualizando o Log

Uma das maneiras mais utilizadas para visualizar um arquivo de Log é através do comando TAIL e usando o parâmetro "-f" para ficar aberto o monitoramento do arquivo.
~~~~shell
# tail -f /var/log/syslog
~~~~~

### Configuração Do SYSLOG

A configuração do SYSLOG é realizada utilizando-se o arquivo ``/etc/syslog.conf``. A sintaxe básica deste arquivo é a seguinte:

    recurso.ação          arquivo 

Os “recursos” são identificados para a gravação das mensagens. Os programas utilizados no sistema utilizarão alguns destes recursos, e quando for um recurso que está em monitoração, um Log será gravado no arquivo especificado. No RSYSLOG existem 21 recursos, os mais utilizados são:

* Recursos disponíveis no RSYSLOG.

Recurso | Programas que utilizam
------|-------
kern | Kernel do Linux
user | Programas do usuário
mail | Servidor de Correio
daemon | Daemon's inicializados
auth | Programas de Autenticação e Segurança
cron |CRON
syslog |O próprio SYSLOG
* | Todos os programas serão monitorados.

* As “ações” especificam o momento em que o Log será gravado:

Recurso | Descrição
----|---
emerg | Emergência crítica
alert | Situação de emergência momentânea
crit | Condições críticas
err | Erro de execução
warn |Situação de advertência
notice |Situação para investigação
info | Informação
debug | Depuração de programas
* |Qualquer situação

* user.* ``/var/log/user.log``: gravará todas as mensagens de um usuário no arquivo ``/var/log/user.log``. Ex: login do usuário, inicialização de aplicativos, erros, etc.

* kern.warn ``/var/log/kernel/warnnings.log``: gravará todas as mensagens de advertência originadas pelo kernel no arquivo ``/var/log/kernel/warnnings.log``. Ex: falha ao iniciar processo.

Para não acumular excesso de informação de Log, o Linux realiza a substituição dos Log's antigos, utilizando o programa LOGROTATE. O arquivo de configuração é o `/etc/logrotate.conf`.

-----------

# Administração de Usuários e Grupos

A principal tarefa de um administrador de Servidor é o Gerenciamento de Usuários. Os usuários serão cadastrados para acessarem o Servidor, de acordo com regras estabelecidas. Estas regras definirão, por exemplo, quais arquivos serão acessíveis por um determinado usuários; os equipamentos que serão utilizados; os horários que o usuário poderão conectar-se ao Servidor, entre outras.

Através de Comandos:

    Gerenciamento de Usuários: useradd, userdel, usermod, passwd;
    Gerenciamento de Grupos: groupadd, groupdel, groupmod;

As informações dos usuários são armazenadas nos seguintes arquivos: ``/etc/shadow`` e ``/etc/passwd``. As informações referentes aos grupos são armazenadas no arquivo:
``/etc/group``.

Esses arquivos são visados por intrusos, os chamados hackers, que buscam informações e senhas de usuários, para terem acesso à todos os dados armazenados nos servidores.

Serão mostradas as maneiras de se administrar Usuários e Grupos no Ubuntu Linux, pelo Terminal de Comandos.

## Gerenciando Usuários

Através do Terminal de Comandos, pode-se utilizar vários comandos de administração dos usuários. Estes comandos permitem criar, apagar e modificar as informações referentes a usuários e grupos.

### Adicionando Um Usuário

Para adicionar usuários  através do Terminal de Comandos, utiliza-se o comando “useradd”. 

A sintaxe deste comando é a seguinte:
~~~~shel
$ useradd [-c comment] [-d home_dir] [-e expire_date] [-f inactive_days] [-g initial_group] [-G group[,...]] [-m [-k skeleton_dir]] [-o] [-p passwd] [-s shell] [-u uid] login 
~~~~

As principais opções do comando “useradd” são descritas abaixo::

#### Principais opções do comando “useradd”.

Opção | Descrição 
-------|----------
-c | Comentário, geralmente associado ao nome completo do usuário.
-d | Diretório de utilização do usuário. O padrão é o “/home”, mas pode ser qualquer outro.
-g | Grupo associado ao usuário. **O grupo deve ser criado antes do usuário**.
login | Nome utilizado para o login do usuário.

Se o grupo não for informado, então será criado um grupo com o mesmo nome do usuário, e o usuário será associado a ele. Para adicionar o usuário “ricardo”, pertencente ao grupo “administradores”, digita-se o comando:

~~~~shell
$ useradd -c “AdministradorLinux” adm -g adm 
~~~~

 Após a utilização do comando “useradd”, deve-se utilizar o comando “passwd”, para se criar uma senha para o usuário, e assim permitir que o mesmo tenha acesso ao sistema. Para tanto, entre com o comando:

 ~~~~shell
$ passwd admesab
~~~~

### Removendo um Usuário

Para remover um usuário pelo Terminal de Comandos, basta digitar o comando **“userdel -r usuario”**.
~~~~shel
$ userdel -r admesab
~~~~
 
O comando **“userdel”** remove o usuário, e a opção **“-r” removerá o diretório do usuário**. Se ela não for passada, o diretório do usuário deverá ser removido manualmente.

### Modificando Um Usuário

A modificação dos dados de um usuário pelo Terminal de Comandos é feita com o comando **“usermod”**. Este comando é muito semelhante ao comando “useradd”, tendo a mesma sintaxe:

As opções são as mesmas do comando “useradd”, e a alteração será imediata.
~~~~shell
$ usermod [-c comment] [-d home_dir] [-e expire_date] [-f inactive_days] [-g initial_group] [-G group[,...]] [-m [-k skeleton_dir]] [-o] [-p passwd] [-s shell] [-u uid] login
~~~~
As opções são as mesmas do comando useradd e a alteração será imediata.

### Alterando a Senha de um Usuário

A alteração da senha poderá ser feita pelo comando passwd. Se a alteração da senha for feita pelo próprio usuário, e o mesmo utilizar o comando **passwd**, serão necessários 3 passos:

1. Informar a senha atual;
2. Informar a nova senha;
3. Repetir a nova senha.

## Gerenciando Grupos

Em um ambiente de rede de computadores temos a necessidade de organizar as contas de usuários em grupos. A organização em grupos é fundamental para a manutenção do sistema e das políticas de segurança e controle de acesso ao sistema e serviços.

### Adicionando um Grupo

Para adicionar um grupo, pelo Terminal de Comandos, utiliza-se o comando **groupadd** *grupo* , onde *grupo* é o nome do grupo que se deseja criar.
~~~~shell
$ groupadd admesab
~~~~

Opcionalmente pode-se informar o número de identificação do grupo, com a opção **-g NUM*, da seguinte maneira: 
~~~~shell
$ groupadd -g 2009 fiscal.
~~~~

### Removendo um Grupo

Para remover um grupo, deve-se verificar se o mesmo não possui nenhum usuário associado a ele. **Se um grupo não contiver nenhum usuário, então poderá ser removido do sistema**. Para remover um grupo pelo Terminal de Comandos, utiliza-se o comando **groupdel grupo**. Uma listagem dos grupos existentes no servidor pode ser obtida listando o conteúdo do arquivo ``/etc/group``. Observe que esse arquivo não deve ser editado manualmente. Qualquer criação/remoção de grupos deve ser feita pelos utilitários informados nessa Unidade.

## Modificando um Grupo

Para modificar um grupo pelo terminal de comandos utiliza-se o comando **groupmod**. É possível modificar-se o Número de Identificação do grupo, com a opção “-g”, ou o Nome do grupo, com a opção **-n**.

~~~~shell
$ groupmod -g 1001 -n admlinux adm
~~~~

O comando anteior modificará o grupo admesab, renomeando-o para admlinuxesab. A Figura apresenta o resultado da operação de manutenção do grupo.

------

## Permissões De Acesso

Unidade 15