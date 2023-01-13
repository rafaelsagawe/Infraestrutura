# Servidor de Logs

## NAS
Services -> SMB 
Auxiliary Parameters
~~~~
vfs objects = full_audit
full_audit:prefix = %u|%I|%m|%S
full_audit:failure = connect
full_audit:success = connect disconnect opendir mkdir rmdir closedir open close read pread write pwrite sendfile rename unlink chmod fchmod chown fchown chdir ftruncate lock symlink readlink link mknod realpath
full_audit:facility = LOCAL5
full_audit:priority = NOTICE
~~~~

## LogAnalyzer - WebInferface
https://blog.remontti.com.br/2687

O projeto LogAnalyzer já é antigo, não tem um interface muito bonita mas fornece um frontend fácil de usar e poderoso, permite pesquisar, revisar e analisar dados de eventos de rede, incluindo syslog. É um aplicativo gratuito de código aberto GPL escrito principalmente em php. Os dados podem ser obtidos de bancos de dados, mas também de arquivos de texto simples, por exemplo, aqueles que são escritos pelo rsyslog.

Diferente do tutorial do site, a criação do banco de dados e de seu usuário foram feitos por meio do WebAdmin e usei o arquivo do rsyslog que recebe todos os logs, desta maquina e do *NAS*.

Finalizando a instalação e configurações recebi essa mensagem de erro:

**If you get this error message: "Syslog file is not readable, read access may be denied"**

Para resolver é necessario adicionar o usuário *www-data* no grupo *adm*, [conforme está explicação.](http://techies-world.com/how-to-install-rsyslog-with-loganalyzer-in-ubuntu/)