# Dicas sobre MySQL

## Recuperando de corrompimento do BD

Apos uma atualização mal sucedida do Sistema Operacional, o Linux Lite 4.XXXXXXXXXXXX, o Mysql não iniciava dando erro no socket.

A principio parecia ser erro na autenticação, para verificar está possibilidade utilizei os seguintes comandos, para acessar os SGBD.

~~~~shell
# sudo mysqld --skip-grant-tables &
# mysql -u root mysql
~~~~
Ao entrar no console do Mysql realizei o procedimento para alterar a senha do root, mas não foi possível.

~~~~shell
# UPDATE mysql.user SET Password = PASSWORD('@SemedNI#') WHERE User = 'root';
~~~~

Tentei usar o comando no console do mysql, mas também não obtive resultados.

Fiz o backup da pasta ``/var/lib/mysql/`` onde tem os arquivos "físicos" do banco de dados, removi totalmente o MySQL do servidor e reinstalei tudo operacional. Parei ele ``sudo service mysql stop``, restaurei os arquivos do backup feitos e reativei o SGBD ``sudo service mysql start``, mas o sistema não subiu.

Então tentei no Windowns, instalei o Mysql server e o Workbench, parei o Mysql no e coloquei o backup do feito no Linux na pasta do SGBD no Windowns ``C:\ProgramData\MySQL\MySQL Server 5.7\Data`` e reiniciei o banco. Abrindo o Workbench a base de dados que estava tentando restaurar apareceu com essa descrição nas tabelas **tables could not be fetched**, entretanto para o procedimento ocorrer de forma adequada é necessário copiar outros arquivos do mysql original, ``ib_logfile0, ibdata1 e ib_logfile1`` com esse arquivos no lugar, foi possível realizar o procedimento do backup do banco de dados através do Workbench gerando o arquivo .sql com a estrutura e os dados.