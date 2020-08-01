# Dicas sobre MySQL

## Recuperando de corrompimento do BD

Apos uma atualização mal sucedida do Sistema Operacional, o Linux Lite 4.XXXXXXXXXXXX, o Mysql não iniciava dando erro no socket.  

sudo mysqld --skip-grant-tables &
mysql -u root mysql

UPDATE mysql.user SET Password = PASSWORD('@SemedNI#') WHERE User = 'root';
FLUSH PRIVILEGES;
exit;

' USE mysql;
repair table user use_frm;