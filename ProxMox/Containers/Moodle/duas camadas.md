# Container Web

# Container Banco
## Liberando porta acesso externo

Editar os arquivos postgresql.conf e pg_hba.conf

~~~~shell
# postgresql.conf
    listen_addresses = "*"

# pg_hba.conf
    host all all 0.0.0.0/0 trust
~~~~