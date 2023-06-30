~~~~
kubeadm: the command to bootstrap the cluster.
kubelet: the component that runs on all of the machines in your cluster and does things like starting pods and containers.
kubectl: the command line util to talk to your cluster.
~~~~

IP | Hostname | Memoria | HD 
--|--|--|--
https://172.15.5.1:9090 | kube-master | 32GB |
https://172.15.5.2:9090 | kube-worker-1 | 16GB |
https://172.15.5.3:9090 | kube-worker-2 | 16GB |


Ajustar o mome de cada maquina

~~~~shell
# hostaname kube-master
# echo "kube-master" > /etc/hostname
# bash
~~~~

Nas 3 maquinas

~~~~shell
cat <<EOF | sudo tee /etc/yum.repos.d/kubernetes.repo
[kubernetes]
name=Kubernetes
baseurl=https://packages.cloud.google.com/yum/repos/kubernetes-el7-\$basearch
enabled=1
gpgcheck=1
gpgkey=https://packages.cloud.google.com/yum/doc/rpm-package-key.gpg
exclude=kubelet kubeadm kubectl
EOF

# Set SELinux in permissive mode (effectively disabling it)
sudo setenforce 0
sudo sed -i 's/^SELINUX=enforcing$/SELINUX=permissive/' /etc/selinux/config

sudo yum install -y kubelet kubeadm kubectl --disableexcludes=kubernetes

sudo systemctl enable --now kubelet
~~~~

Setting SELinux in permissive mode by running setenforce 0 and sed ... effectively disables it. This is required to allow containers to access the host filesystem, which is needed by pod networks for example. You have to do this until SELinux support is improved in the kubelet.

You can leave SELinux enabled if you know how to configure it but it may require settings that are not supported by kubeadm.

If the baseurl fails because your Red Hat-based distribution cannot interpret basearch, replace \$basearch with your computer's architecture. Type uname -m to see that value. For example, the baseurl URL for x86_64 could be: https://packages.cloud.google.com/yum/repos/kubernetes-el7-x86_64.

## master
~~~~shell
# kubeadm init
.
..
...
será gerado um token que é necessario para o join das outras maquinas
~~~~
Comfigurar o kubecontrol para acessar o cluster.

~~~~shell
#  mkdir -p $HOME/.kube
#  sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
#  sudo chown $(id -u):$(id -g) $HOME/.kube/config
~~~~

aplicar o codigo do token

Verificar os nodes
~~~~shell
# kubectl get nodes
~~~~