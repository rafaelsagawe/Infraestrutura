~~~~
kubeadm: the command to bootstrap the cluster.
kubelet: the component that runs on all of the machines in your cluster and does things like starting pods and containers.
kubectl: the command line util to talk to your cluster.
~~~~

[Documentação](https://kubernetes.io/docs/setup/production-environment/tools/kubeadm/install-kubeadm/)

[Title](https://www.howtoforge.com/how-to-setup-kubernetes-cluster-with-kubeadm-on-rocky-linux/)

IP | Hostname | Memoria | HD 
--|--|--|--
https://172.15.5.1:9090 | kube-master | 32GB |
https://172.15.5.2:9090 | kube-worker-1 | 16GB |
https://172.15.5.3:9090 | kube-worker-2 | 16GB |


Ajustar o mome de cada maquina

~~~~shell
# hostnamectl set-hostname kube-master.semed.intra
# bash
~~~~

## Usando usuário root

Trocando o modo do SeLinux para Permissive.

~~~~shell
# setenforce 0
# sed -i 's/^SELINUX=enforcing$/SELINUX=permissive/' /etc/selinux/config
~~~~

### Loading K8s required Kernel Modules:


~~~~shell
# modprobe overlay
# modprobe br_netfilter
# cat > /etc/modules-load.d/k8s.conf << EOF
    overlay
    br_netfilter
EOF
~~~~ 

~~~~shell
# cat > /etc/sysctl.d/k8s.conf << EOF
    net.ipv4.ip_forward = 1
    net.bridge.bridge-nf-call-ip6tables = 1
    net.bridge.bridge-nf-call-iptables = 1
EOF
~~~~

É necessario recarregar os parametros do kernel
~~~~shell
# sysctl --system
~~~~

## Instalando containerd.io

~~~~shell
$ wget https://github.com/containerd/containerd/releases/download/v1.7.0/containerd-1.7.0-linux-amd64.tar.gz
$ tar Cxzvf /usr/local containerd-1.7.0-linux-amd64.tar.gz
$ wget https://raw.githubusercontent.com/containerd/containerd/main/containerd.service
$ cd /etc/systemd/
$ cat /etc/systemd/containerd.service
$ sudo systemctl daemon-reload
$ sudo systemctl enable --now containerd
$ sudo ls  /etc/systemd/system/multi-user.target.wants/containerd.service → /etc/systemd/system/containerd.service
$ sudo systemctl enable --now containerd
$ sudo systemctl containerd status
$ sudo systemctl status containerd
~~~~

# Instalando o Kubernetes

~~~~shell
$ cat <<EOF | sudo tee /etc/yum.repos.d/kubernetes.repo
    [kubernetes]
    name=Kubernetes
    baseurl=https://packages.cloud.google.com/yum/repos/kubernetes-el7-\$basearch
    enabled=1
    gpgcheck=1
    gpgkey=https://packages.cloud.google.com/yum/doc/yum-key.gpg https://packages.cloud.google.com/yum/doc/rpm-package-key.gpg
    exclude=kubelet kubeadm kubectl
EOF
~~~~

~~~~shell
$ sudo dnf install kubelet kubeadm kubectl --disableexcludes=kubernetes
~~~~

~~~~shell
$ sudo systemctl enable --now kubelet
~~~~

~~~~shell
$ sudo systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: disabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: activating (auto-restart) (Result: exit-code) since Thu 2023-06-29 15:41:16 -03; 6s ago
       Docs: https://kubernetes.io/docs/
    Process: 66378 ExecStart=/usr/bin/kubelet $KUBELET_KUBECONFIG_ARGS $KUBELET_CONFIG_ARGS $KUBELET_KUBEADM_ARGS $KUBELET_EXTRA_ARGS (code=exited, status=1/FAILURE)
   Main PID: 66378 (code=exited, status=1/FAILURE)
        CPU: 78ms
~~~~

## Plugin: Flannel

~~~~shell
sudo mkdir -p /opt/bin/
sudo curl -fsSLo /opt/bin/flanneld https://github.com/flannel-io/flannel/releases/download/v0.19.0/flanneld-amd64
sudo chmod +x /opt/bin/flanneld
~~~~

## Initializing Kubernetes Control Plane

~~~~shell
$ lsmod | grep br_netfilter
br_netfilter           32768  0
bridge                323584  1 br_netfilter
~~~~

~~~~shell
$ sudo kubeadm config images pull
[config/images] Pulled registry.k8s.io/kube-apiserver:v1.27.3
[config/images] Pulled registry.k8s.io/kube-controller-manager:v1.27.3
[config/images] Pulled registry.k8s.io/kube-scheduler:v1.27.3
[config/images] Pulled registry.k8s.io/kube-proxy:v1.27.3
[config/images] Pulled registry.k8s.io/pause:3.9
[config/images] Pulled registry.k8s.io/etcd:3.5.7-0
[config/images] Pulled registry.k8s.io/coredns/coredns:v1.10.1
~~~~

~~~~shell
$ sudo kubeadm init                                                                         
[init] Using Kubernetes version: v1.27.3
[preflight] Running pre-flight checks
        [WARNING Firewalld]: firewalld is active, please ensure ports [6443 10250] are open or your cluster may not function correctly
        [WARNING Swap]: swap is enabled; production deployments should disable swap unless testing the NodeSwap feature gate of the kubelet
        [WARNING Hostname]: hostname "kube-master.semed.intra" could not be reached
        [WARNING Hostname]: hostname "kube-master.semed.intra": lookup kube-master.semed.intra on 172.15.1.3:53: no such host
~~~~

## Configurações do Firewall

Port | Protocol | Purpose
--|--|--
6443 | TCP | Kubernetes API server
2379-2380 | TCP | etcd server client API
10250 | TCP | Kubelet API
10251 | TCP | kube-scheduler
10252 | TCP | kube-controller-manager

~~~~shell
firewall-cmd --permanent --add-port={6443,2379,2380,10250,10251,10252}/tcp

firewall-cmd --reload
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

~~~~shell
# sudo swapoff -a
# sudo sed -e '/swap/s/^/#/g' -i /etc/fstab
~~~~

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

## Limpar o Cluster

~~~~shell
sudo rm -r  /etc/kubernetes/manifests/*

sudo rm -rf /etc/cni/net.d/*

sudo systemctl restart kubelet

sudo systemctl restart containerd

sudo systemctl restart kubelet

sudo kubeadm reset
~~~~

# Erro atual

~~~~
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests". This can take up to 4m0s
[kubelet-check] Initial timeout of 40s passed.

Unfortunately, an error has occurred:
        timed out waiting for the condition

This error is likely caused by:
        - The kubelet is not running
        - The kubelet is unhealthy due to a misconfiguration of the node in some way (required cgroups disabled)

If you are on a systemd-powered system, you can try to troubleshoot the error with the following commands:
        - 'systemctl status kubelet'
        - 'journalctl -xeu kubelet'

Additionally, a control plane component may have crashed or exited when started by the container runtime.
To troubleshoot, list all containers using your preferred container runtimes CLI.
Here is one example how you may list all running Kubernetes containers by using crictl:
        - 'crictl --runtime-endpoint unix:///var/run/containerd/containerd.sock ps -a | grep kube | grep -v pause'
        Once you have found the failing container, you can inspect its logs with:
        - 'crictl --runtime-endpoint unix:///var/run/containerd/containerd.sock logs CONTAINERID'
error execution phase wait-control-plane: couldn't initialize a Kubernetes cluster
To see the stack trace of this error execute with --v=5 or higher
~~~~


aplicar o codigo do token

Verificar os nodes
~~~~shell
# kubectl get nodes
~~~~