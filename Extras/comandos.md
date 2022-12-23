# comparativo de comandos Win <=> Distribuição Linux base *.DEB*

Win | Linux| Função
----|------|------
ping|ping| Usado para teste de conectividade entre hosts

## Copiar arquivo via ssh

Pode ser preciso copiar arquivos entre PCs com Linux, uma das forma mais simples é utilizar o SSH. 
~~~~shell
$ scp -r *  semed@172.15.0.3:/home/semed
~~~~
scp é um protocolo de rede para transferências de arquivos. Com ele, você pode transferir arquivos de forma fácil e segura entre um local remoto e um host ou entre dois locais remotos. A opção -r server para copiar pastas.

## Alterando o dono e grupo do arquivo/pasta

Depois de copiar arquivos/pastas pode ser necessário a atualização das credencias de acesso.

~~~~shall
chown -R nobody:share *
~~~~

-R -> recursivo;
* -> todos


## Salvar e Enviar resultados de comando

É possível salvar e/ou enviar o resultado de um comando em arquivo usando o sinal de maior ">", usando a sintaxe ``comando > destino``.

~~~~shell
# ls -lha > pastas.txt
~~~~

Pode usar qualquer editor ou comando para abrir o arquivo.

Para enviar para outro terminal é preciso primeiro saber os terminas ativos, para isso podemos usar o comando ``who``.

~~~~shell
$ who
rafael   pts/0        2020-12-29 12:39 (172.15.0.11)
rafael     tty2         2020-12-29 13:42
~~~~

Na saida a cima estou **rafael** acessando remotamento o servidor **pts/0** e o rafael no terminal local do servidor **tty2**. 

Então será preciso enviar do **pts/0** para o **tty2**, segue a mesma lógica de salvar a saida do comando e para finalizar o mando utiliza o ``&`` para colocar o comando em segundo plano



(Comando enviar local      fundo)
htop        >   /dev/tty2   &

(Comando enviar arquivo)
ls          >   pastas.txt

tail -f /var/log/messages > /dev/ttyv3