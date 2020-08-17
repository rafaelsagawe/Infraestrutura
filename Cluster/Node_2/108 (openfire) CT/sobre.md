Openfire é um servidor que utiliza o protocolo Jabber (XMPP) para oferecer serviços de mensagens instantâneas aos usuários.
O software é gratuito e, além da simples troca de mensagens de texto, permite conversas por voz, conferências, envio de arquivos e até a troca de screenshots (imagens da área de trabalho) - tirados em tempo real - entre os participantes das sessões.

Plataforma de chat entre escolas e SEMED;
* Acesso em computador e dispositivos moveis;
* Envio de arquivos;
* Função de conferência;

## Procedimentos da instalação

1. Atualizar o sistema
~~~~shell
apt update
~~~~

2. Instalar os pacotes do java
~~~~shell
apt install default-jre
~~~~

3. Verificar o Java instalado

~~~~shell
java  -version
           openjdk version "11.0.2" 2019-01-15
           OpenJDK Runtime Environment (build 11.0.2+9-Ubuntu-3ubuntu118.04.3)
           OpenJDK 64-Bit Server VM (build 11.0.2+9-Ubuntu-3ubuntu118.04.3, mixed mode, sharing)
~~~~

4. Realizar o download do Openfire
~~~~shell
wget https://www.igniterealtime.org/downloadServlet?filename=openfire/openfire_4.3.2_all.deb
~~~~

5. Renomear o arquivo que foi feito o download
mv downloadServlet\?filename\=openfire%2Fopenfire_4.3.2_all.deb openfire.deb
6. Realizar instalação forçada do servidor
dpkg -i --force-all openfire.deb
7. Verifica a ausência de componentes ou bibliotecas no sistema  
apt install -f
8. Obtendo o IP do container para acessar via porta 9090
ip addr

### Configurações via web interface
1. Language Selection: Português Brasileiro (pt_BR);
2. Configurações do Servidor:
        a) Domínio:	chat.semed-ni.intra;
        b) Setup Host Settings FQDN: chat.semed-ni.intra;
3. Configurações do Banco de Dados: Banco de Dados Interno;
4. Configurações de Perfis: Servidor de Diretórios (LDAP);

a) Configurações de Conexão:
~~~~
        Tipo de servidor: Active Directory;
        Host: 172.15.0.3;
        DN Base: DC=semed-ni,DC=intra;
        DN Administrador: CN=Admin AD,CN=Users,DC=semed-ni,DC=intra;
        Senha: ********
        Testar configurações
        Salvar & configurar
                b) Mapeamento de Usuário:
        Testar configurações
        Salvar & configurar
                c) Mapeamento de Grupo:
        Testar configurações
        Salvar & configurar
~~~~
5. Conta do Administrador:
        a) Adicionar Administrador: administrator;
