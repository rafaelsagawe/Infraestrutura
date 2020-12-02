i-educar

Instala��o em servidor
O i-Educar possui um instalador que pode te auxiliar no processo de instala��o em um servidor para produ��o.

Antes de tudo fa�a download (wget https://github.com/portabilis/i-educar/releases/download/2.1.0/ieducar-2.1.0.tar.gz && tar zxvf ieducar-2.1.0.tar.gz) da vers�o mais recente do i-Educar e extraia o conte�do do release em uma pasta no seu servidor. O instalador est� dispon�vel desde a vers�o 2.1.0.

Requerimentos
Para executar o i-Educar em um servidor voc� precisa dos seguintes programas:

Nginx
apt install nginx

PHP vers�o 7.1.3 ou maior
sudo apt-get install software-properties-common
sudo add-apt-repository ppa:ondrej/php
sudo apt-get update
apt-get install php7.2

bcmath curl dom fileinfo json libxml mbstring openssl PDO pgsql Phar SimpleXML tokenizer xml xmlwriter zip pcre

Postgres vers�o 9.5 ou superior
apt install postgresql postgresql-contrib


O instalador do i-Educar te avisa caso alguma extens�o esteja faltando ent�o n�o se preocupe em instalar tudo agora.

Configurando o servidor
O Nginx precisa estar devidamente configurado para rodar o i-Educar e permitir acesso ao instalador. Voc� encontra um exemplo de configura��o aqui.





Em sistemas Ubuntu, por exemplo, voc� colocaria este arquivo na pasta /etc/nginx/sites-available e criaria um symlink para ele na pasta /etc/nginx/sites-enabled.

N�o esque�a de adequar a configura��o de acordo com a realidade do seu servidor principalmente as seguintes diretivas:

root
fastcgi_pass
Depois de tudo pronto basta reiniciar o processo do nginx para que as configura��es novas entrem em vigor.

Executando o instalador
Agora que o Nginx est� configurado voc� pode acessar o instalador em:

http://www.example.com/install.php
Substitua "www.example.com" pelo seu dom�nio ou endere�o de IP. A partir daqui o instalador dever� te dar todas as instru��es necess�rias para realizar a instala��o com sucesso. Todo exemplo de comando ou c�digo que possa vir a aparecer no processo de instala��o leva em considera��o o seu ambiente, ou seja, fique � vontade para copiar e colar os comandos que eles dever�o funcionar corretamente.

Quando tudo estiver ok voc� poder� definir uma senha para o usu�rio admin e iniciar o processo de instala��o. Se tudo correr bem voc� poder� acessar o i-Educar normalmente.

Em caso de erros no processo de instala��o verifique os logs do sistema que se encontram em storage/logs para determinar suas causas. N�o hesite em entrar em contato caso enfrente dificuldades!

i-diario

curl -sL https://deb.nodesource.com/setup_8.x | sudo -E bash -
curl -sS https://dl.yarnpkg.com/debian/pubkey.gpg | sudo apt-key add -
echo "deb https://dl.yarnpkg.com/debian/ stable main" | sudo tee /etc/apt/sources.list.d/yarn.list

sudo apt-get update
sudo apt-get install git-core curl zlib1g-dev build-essential libssl-dev libreadline-dev libyaml-dev libsqlite3-dev sqlite3 libxml2-dev libxslt1-dev libcurl4-openssl-dev software-properties-common libffi-dev nodejs yarn

cd
git clone https://github.com/rbenv/rbenv.git ~/.rbenv
echo 'export PATH="$HOME/.rbenv/bin:$PATH"' >> ~/.bashrc
echo 'eval "$(rbenv init -)"' >> ~/.bashrc
exec $SHELL

git clone https://github.com/rbenv/ruby-build.git ~/.rbenv/plugins/ruby-build
echo 'export PATH="$HOME/.rbenv/plugins/ruby-build/bin:$PATH"' >> ~/.bashrc
exec $SHELL

rbenv install 2.2.6
rbenv global 2.2.6
ruby -v


i-Di�rio
Portal do professor integrado com o software livre i-Educar

Instala��o

Instalar o Ruby 2.2.6 (Recomendamos uso de um gerenciador de vers�es como Rbenv ou Rvm)
Instalar a gem Bundler:
$ gem install bundler
Baixar o i-Di�rio:
$ git clone https://github.com/portabilis/i-diario.git
Instalar as gems:
$ cd i-diario
$ bundle install
Copiar o exemplo de configura��es de banco de dados e configurar:
$  cp config/database.sample.yml config/database.yml
Criar e configurar o arquivo config/secrets.yml conforme o exemplo:
development:
  secret_key_base: CHAVE_SECRETA_AQUI # Voc� pode gerar uma chave usando o comando "bundle exec rake secret"
Criar o banco de dados:
$ bundle exec rake db:create
$ bundle exec rake db:migrate
Criar uma entidade:
$ bundle exec rake entity:setup NAME=prefeitura DOMAIN=localhost DATABASE=prefeitura_diario
Criar um usu�rio administrador:
$ bundle exec rails console
Entity.last.using_connection { User.create!(email: 'admin@domain.com.br', password: '123456789', password_confirmation: '123456789', status: 'actived', kind: 'employee', admin:  true) }
Iniciar o servidor e acessar http://localhost:3000 para acessar o sistema:
$ bundle exec rails server
Sincroniza��o com i-Educar
Acessar Configura��es > Api de Integra�ao e configurar os dados do sincronismo
Acessar Configura��es > Unidades e clicar em Sincronizar
Acessar Calend�rio letivo, clicar em Sincronizar e configurar os calend�rios
Acessar Configura��es > Api de Integra��o e clicar no bot�o de sincronizar
Nota: Ap�s esses primeiros passos, recomendamos que a sincroniza��o rode pelo menos diariamente para manter o i-Di�rio atualizado com o i-Educar

Rodar os testes
$ RAILS_ENV=test bundle exec rake db:create
$ RAILS_ENV=test bundle exec rake db:migrate
$ bin/rspec spec

## Liberar acesso remoto (SSH)
~~~~shell
nano /etc/ssh/sshd_config

  PermitRootLogin yes

service ssh restart
~~~~

## Liberar acesso remoto (postgres)
~~~~shell
# cd /etc/postgresql/10/main/

# nano postgresql.conf

  listen_addresses = "*" # what IP address(es) to listen on

# nano pg_hba.conf

  #host    all             all             127.0.0.1/32            md5
  host    all             all             0.0.0.0/0               md5

# service postgresql restart
~~~~

#### Criando o usuário para o Grafana

~~~~shell
 # su postgres

   # psql

     # \l

      CREATE USER grafana  WITH ENCRYPTED PASSWORD 'grafana';
      GRANT USAGE ON SCHEMA public to grafana;
      ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT ON TABLES TO grafana;
      GRANT CONNECT ON DATABASE ieducar to grafana;
      -- o codigo abaixo concede o privilegio em novas tabelas geradas no banco "ieducar"
      ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON TABLES TO grafana;
      GRANT USAGE ON SCHEMA public to grafana;
      GRANT SELECT ON ALL SEQUENCES IN SCHEMA public TO grafana;
      GRANT SELECT ON ALL TABLES IN SCHEMA public TO grafana;
~~~~