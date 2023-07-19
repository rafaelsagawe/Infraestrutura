# Instalar o Nextcloud atraves do template 

O template usado e o Debian 11 da Turnkey com o nextcloud já implementado 

![Download do template](Imagens\Template\01.png)

## Hardware do teste

Recurso | Alocado
--|--
CPU| 2 core
Mem| 1024GB
DHCP | Ativo
Storage| 15GB
Feature| Nesting

![Resumo das configurações](Imagens\Template\02.png)

## Processo de Instalação 

Senha usada: ``@Sagawe123``

![Resumo das configurações](Imagens\Template\03.png)
![Resumo das configurações](Imagens\Template\04.png)

## Liberando acesso
![Resumo das configurações](Imagens\Template\05.png)

~~~~shell
# nano /var/www/nextcloud/config/config.php
    array (
        0 => 'localhost',
        1 => 'www.example.com',
        2 => 'IP.usado.na.instancia',
    ),
~~~~

