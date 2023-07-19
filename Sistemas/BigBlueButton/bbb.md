1  wget -qO- https://ubuntu.bigbluebutton.org/bbb-install.sh | bash -s -- -v xenial-220 -a
    2  add-apt-repository
    3  apt install software-properties-common
    4  apt update
    5  apt install software-properties-common
    6  wget -qO- https://ubuntu.bigbluebutton.org/bbb-install.sh | bash -s -- -v xenial-220 -a
    7  cd /var/www/bigbluebutton
    8  cd /var/www/bigbluebutton
    9  ls
   10  cd client/
   11  ls
   12  nano /usr/bin/bbb-conf
   13  /usr/bin/bbb-conf
   14  bbb-conf --secret
   15  apt-get remove bbb-demo
   16  bbb-conf --restart
   17  systemctl set-environment LANG=en_US.UTF-8
   18  poweroff 
   19  bbb-conf --setip bbb-educoon.ddns.net
   20  cat >/etc/nginx/ssl/bigbluebutton.example.com.key <<'END'

   23  END
   24  cat >/etc/nginx/ssl/bigbluebutton.example.com.key
   25  nano /etc/nginx/ssl/bigbluebutton.example.com.key
   26  nano /etc/ssh/sshd_config 
   27  service ssh restart 
   28  ls
   29  mv bbb-educoon.ddns.net.key /etc/nginx/ssl/
   30  cat /etc/nginx/ssl/bigbluebutton.example.com.key
   31  cat /etc/nginx/ssl/bbb-educoon.ddns.net.key 
   32  chmod 0600  /etc/nginx/ssl/bbb-educoon.ddns.net.key 
   33  mv bbb-educoon.ddns.net.crt /etc/nginx/ssl/
   34  cat /etc/nginx/ssl/bbb-educoon.ddns.net.crt 
   35  openssl dhparam -out /etc/nginx/ssl/dhp-4096.pem 409
   36  nano /etc/nginx/sites-available/bigbluebutton
   37  nano /etc/bigbluebutton/nginx/sip.nginx
   38  nano /usr/share/bbb-web/WEB-INF/classes/bigbluebutton.properties
   39  exit
   40  nano /usr/share/bbb-web/WEB-INF/classes/bigbluebutton.properties
   41  nano /usr/share/red5/webapps/screenshare/WEB-INF/screenshare.properties
   42  sed -e 's|http://|https://|g' -i /var/www/bigbluebutton/client/conf/config.xml
   43  sed -e 's|https://|http://|g' -i /var/www/bigbluebutton/client/conf/config.xml
   44  nano /usr/share/meteor/bundle/programs/server/assets/app/config/settings.yml
   45  nano /var/lib/tomcat7/webapps/demo/bbb_api_conf.jsp
   46  bbb-conf --restart
   47  nano /etc/nginx/sites-available/bigbluebutton
   48  service nginx restart
   49  systemctl status nginx.service
   50  /etc/nginx/nginx.conf
   51  nano /etc/nginx/nginx.conf
   52  nano /etc/nginx/sites-available/bigbluebutton
   53  ls /etc/nginx/ssl/
   54  openssl x509 -text -noout -in /etc/nginx/ssl/bbb-educoon.ddns.net.crt 
   55  ls /etc/nginx/ssl/
   56  service nginx configtest
   57  nano /etc/nginx/ssl/bbb-educoon.ddns.net.crt 
   58  systemctl status nginx.service
   59  nano /etc/nginx/ssl/bbb-educoon.ddns.net.crt 
   60  systemctl start nginx.service
   61  systemctl status nginx.service
   62  nano /etc/nginx/ssl/bbb-educoon.ddns.net.crt 
   63  systemctl start nginx.service
   64  systemctl status nginx.service
   65  sudo apt-get install software-properties-common
   66  add-apt-repository universe
   67  add-apt-repository ppa:certbot/certbot
   68  apt-get install certbot
   69  certbot --webroot -w /var/www/bigbluebutton-default/ -d bbb-educoon.ddns.net certonly
   70  nano /etc/nginx/sites-enabled/bigbluebutton 
   71  systemctl start nginx.service
   72  systemctl status nginx.service
   73  certbot --webroot -w /var/www/bigbluebutton-default/ -d bbb-educoon.ddns.net certonly
   74  ls /etc/letsencrypt/live
   75  ls /etc/letsencrypt/live/bbb-educoon.ddns.net/
   76  nano /etc/nginx/sites-enabled/bigbluebutton 
   77  crontab -e
   78  bbb-conf --restart
   79  nano /etc/nginx/sites-enabled/bigbluebutton 
   80  service nginx start
   81  service nginx status
   82  bbb-conf --restart
   83  bbb-conf --setret
   84  bbb-conf --secret
   85  ping bbb-educoon.ddns.net
   86  nano /etc/kurento/modules/kurento/WebRtcEndpoint.conf.ini
   87  bbb-conf --reset
   88  bbb-conf --restart
   89  nano /etc/kurento/modules/kurento/WebRtcEndpoint.conf.ini
   90  bbb-conf --restart
   91  nano /etc/kurento/modules/kurento/WebRtcEndpoint.conf.ini
   92  bbb-conf --restart
   93  nano /etc/bigbluebutton/nginx/sip.nginx
   94  bbb-conf --restart
   95  exit
   96  netstat
   97  exit
   98  bbb-conf --check
   99  netstat -ant | grep 5060
  100  netstat -ant | grep 5061
  101  netstat -ant | grep 5060
  102  nano /usr/share/red5/webapps/sip/WEB-INF/bigbluebutton-sip.properties
  103  bbb-conf --clean
  104  bbb-conf --check
  105  nano /usr/share/red5/webapps/sip/WEB-INF/bigbluebutton-sip.properties
  106  bbb-conf --clean
  107  nano /usr/share/red5/webapps/sip/WEB-INF/bigbluebutton-sip.properties
  108  bbb-conf --clean
  109  ssh root@172.15.0.106
  110  exit
  111  ssh root@172.15.0.106
  112  ssh root@172.15.0.106
  113  history 