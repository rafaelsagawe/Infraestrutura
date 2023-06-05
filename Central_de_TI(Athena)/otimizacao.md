 sudo sync && sudo sysctl vm.drop_caches=3
https://www.youtube.com/watch?v=kWle-_zMGGY

# Otimização do Servidor

A otimização do servidor começa antes da sua instalação.

Qual será a função do servidor?

Precisa de performance ou segurança?
Utilização de RAID 0 ou 1 

Será adicionado mas HD's no futuro?

## Instalação 

A instalação do servidor é bem proxima da instalação para desktop tirando algumas preparações para responder as perguntas anteriores.

O principal ponto pode ser o particionamento

Uma boa pratica pode ser a separação a separação de algumas partições, assim prevenindo que em caso o sistema pare devido a raiz fiquem cheias.

* /var -> devido a ser usado para os arquivos de log e os arquivos do banco de dados e o spool;

* /opt -> alguns sistema utilizam esta pasta como ponto de instalação no lugar do /etc;

* /proc -> Partição de processos, são os processos que estão na memória RAM;

* /home -> pasta do usuário;

* instalações em UEFI criam uma partição para os arquivos de boot (/boot/uefi);

* swap -> usada quando a memoria (RAM) estiver ocupada, entretanto mais lenta em caso de uso de HD's.

Se o servidor receberá atualizações quanto ao seu armazenamento, pode ser util a utilizações de recursos como o LVM, BTRF ou ZFS (**ainda não entrei nessa parte**)

Não instalar GUI e softwares que não serão utilizados.

## Após a instalação
Depois de terminar a instalação continua a otimização do sistema, atualizando o sistema, removendo serviços instalados automaticamente...

### Verificando o Hardware
* lscpu -> gera um relatório dos recursos do processador;

### Atualização

DEB | YUM
-----|-------
sudo apt update | yum update
sudo apt upgrade | yum upgrade

### Remoção de recursos não utilizados

Muitos programas e serviços são instalado de forma automática para facilitar a utilização, entretanto consomem recursos é o servidor precisa ser rápido.

~~~~shell
$ sudo apt remove --purge snapd gnome-software-plugin-snap
$ sudo rm -rf /var/cache/snapd
$ sudo rm -rf ~/snap
$ sudo apt remove --purge apport-symptoms apport apport-gtk
$ sudo apt autoremove
~~~~

# Serviços do sistema
Para verificar os serviços que estão iniciando com o sistema e seus tempos de carregamento.

```$ sudo systemd-analyze blame ```

Desabilitar os serviços que não tem a necessidade de serem iniciados com o sistema

```$ systemctl disable nome_do_serviço ```

Pode ser também necessário ativar no boot um serviço

```$ systemctl enable nome_do_serviço ```

verifica se esta ativo no boot

```$ sistemctl is-enable nome_do_serviço ```

### Comandos para visualização dos serviços

* ps auxf -> 

* ss -tulanp -> verifica os serviços em funcionamento: **T**CP, **U**DP, **L**istem (ouvindo), **A**ll (todos), **N**umerico, **P**id (ID dos processos);

* top ->

* htop ->

* mount -> para a montagem, desmontagem e remonstagem de partições;

* fuser -mv / -> amostra todos os procesos apartir do ponto de montagem;

# Edição de arquivos de sistema

adicionar nas linhas finais /etc/sysctl.conf, altera o uso do swap usando seria como usar quando atingir 90%
#vm.swappiness=10
#vm.vfs_cache_pressure=50

# Segurança contra ataque de spoof
# Descomentar as linhas
#$ sudo nano /etc/sysctl.conf
        #net.ipv4.conf.default.rp_filter=1
        #net.ipv4.conf.all.rp_filter=1
        #net.ipv4.tcp_syncookies=1
#$  sudo sysctl -p

# remover monitores de logs de sistemas não usados
#$ sudo nano /etc/rsyslog.d/50-default.conf
#$ sudo systemctl restart rsyslog.service