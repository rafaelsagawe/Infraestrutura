# Recuperar icones não identificados

Devido a um erro na geração dos **caches** de icones, a area de trabalho e a barra de tarefas ficam com icones não identificados, para recupera-los foi necessário seguir alguns passos:

1. Acessar a pasta dos arquivos de **cache**, no windowns 10 fica em ``C:\Users\Nome_do_Usuário\AppData\Local\Microsoft\Windows\Explorer``;

2. No gerenciador de tarefas é necessário para o ``Explorer``;

3. Usando o ``CMD`` em modo *Administrador* na pasta do **cache**;

4. Remova os arquivos de **cache** usando o comando ``del iconcache*
``;

5. No gerenciador de tarefas inicie novamente o Explorer é os icones devem está normais.

# Controlar varios PCs com um mouse e teclado

E possivel controlar varios computadores com o mesmo kit de mouse e teclado. Para realizar está tarefa e usado o synergy (Windowns) e o quicksynergy (Linux), o equipamento com o kit será o servidor enquanto os outros são os clientes.

Instalação no linux
~~~~shell
$ sudo apt install quicksynergy
~~~~