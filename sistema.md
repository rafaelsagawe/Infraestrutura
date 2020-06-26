# Administração do sistemas baseados em Linux/

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

Aula 13 e 14
# Administração de Usuários 