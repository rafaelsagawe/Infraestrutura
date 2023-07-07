
* kubeadm: the comando para inicializar o cluster.
* kubelet: componente que é executado em todas as máquinas em seu cluster e faz coisas como iniciar pods e contêineres.
* kubectl: utilitário de linha de comando para comunicação a API do Kubernetes.

# Documentação

[Documentação oficial](https://kubernetes.io/docs/setup/production-environment/tools/kubeadm/install-kubeadm/)

[Documentação extra](https://www.golinuxcloud.com/kubernetes-tutorial/)

## Tutoriais de instalação

[Install Kubernetes Master Node on Rocky Linux 9](https://www.centlinux.com/2022/11de-rocky-linux.html)

[How to Install a Kubernetes Cluster with Kubeadm on Rocky Linux](https://www.howtoforge.com/how-to-setup-kubernetes-cluster-with-kubeadm-on-rocky-linux/)

[Em português "não usei"](https://pt.linux-console.net/?p=3526#gsc.tab=0)

[Kubernetes with Kubeadm: Cluster Installation from Scratch](https://admantium.medium.com/kubernetes-with-kubeadm-cluster-installation-from-scratch-810adc1b0a64)

## Tutoriais de operação

[Rodando o Nginx](https://nonanom.medium.com/run-nginx-on-kubernetes-ee6ea937bc99)

[Acessando os logs](https://sematext.com/blog/tail-kubernetes-logs/)

IP | Hostname | Memoria | HD Sistema |
--|--|--|--
https://172.15.5.1:9090 | kube-worker   | 32GB | |
https://172.15.5.2:9090 | kube-worker-1 | 16GB | |
https://172.15.5.3:9090 | kube-worker-2 | 16GB | |

## Limpar o Cluster 

~~~~shell
rm -r  /etc/kubernetes/manifests/*
rm -rf /etc/cni/net.d/*
systemctl restart kubelet
systemctl restart containerd
systemctl restart kubelet
kubeadm reset
~~~~

===============//===============//============= 

Usando o usuário root
## Ajustes iniciais 

Usando o usuário root
~~~~shell
$ sudo su
~~~~

Arrumando o nome
~~~~shell
# echo 172.15.5.1 kubemaster.semed.intra kubemaster >> /etc/hosts                                                                     
~~~~

Modo permissivo do SELinux
~~~~shell
# setenforce 0

# sed -i 's/^SELINUX=enforcing$/SELINUX=permissive/' /etc/selinux/config
~~~~

Atualizando o sistema
~~~~shell
# dnf makecache --refresh
Extra Packages for Enterprise Linux 9 - x86_64                             58 kB/s |  62 kB     00:01    
Rocky Linux 9 - BaseOS                                                    7.8 kB/s | 4.1 kB     00:00    
Rocky Linux 9 - AppStream                                                 7.6 kB/s | 4.5 kB     00:00    
Rocky Linux 9 - AppStream                                                 875 kB/s | 7.0 MB     00:08     
Rocky Linux 9 - Extras                                                    3.6 kB/s | 2.9 kB     00:00    
Rocky Linux 9 - Extras                                                    9.3 kB/s | 9.5 kB     00:01     
Metadata cache created.

# dnf update -y
Last metadata expiration check: 0:00:36 ago on Wed Jul  5 09:33:04 2023.
Dependencies resolved.
Nothing to do.
Complete!

# cat /etc/rocky-release
Rocky Linux release 9.2 (Blue Onyx)

# uname -r
5.14.0-284.18.1.el9_2.x86_64
~~~~

## Carregando os modulos K8s
~~~~shell
# modprobe overlay
modprobe br_netfilter
cat > /etc/modules-load.d/k8s.conf << EOF
overlay
br_netfilter
EOF

# cat > /etc/sysctl.d/k8s.conf << EOF
net.ipv4.ip_forward = 1
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
EOF
~~~~

Recarregando o systemctl para ativar os moadulos
~~~~shell
# sysctl --system
* Applying /usr/lib/sysctl.d/10-default-yama-scope.conf ...
* Applying /usr/lib/sysctl.d/50-coredump.conf ...
* Applying /usr/lib/sysctl.d/50-default.conf ...
* Applying /usr/lib/sysctl.d/50-libkcapi-optmem_max.conf ...
* Applying /usr/lib/sysctl.d/50-pid-max.conf ...
* Applying /usr/lib/sysctl.d/50-redhat.conf ...
* Applying /usr/lib/sysctl.d/60-libvirtd.conf ...
* Applying /usr/lib/sysctl.d/60-qemu-postcopy-migration.conf ...
* Applying /etc/sysctl.d/99-sysctl.conf ...
* Applying /etc/sysctl.d/k8s.conf ...
* Applying /etc/sysctl.conf ...
kernel.yama.ptrace_scope = 0
kernel.core_pattern = |/usr/lib/systemd/systemd-coredump %P %u %g %s %t %c %h
kernel.core_pipe_limit = 16
fs.suid_dumpable = 2
kernel.sysrq = 16
kernel.core_uses_pid = 1
net.ipv4.conf.default.rp_filter = 2
net.ipv4.conf.eno1.rp_filter = 2
net.ipv4.conf.lo.rp_filter = 2
net.ipv4.conf.default.accept_source_route = 0
net.ipv4.conf.eno1.accept_source_route = 0
net.ipv4.conf.lo.accept_source_route = 0
net.ipv4.conf.default.promote_secondaries = 1
net.ipv4.conf.eno1.promote_secondaries = 1
net.ipv4.conf.lo.promote_secondaries = 1
net.ipv4.ping_group_range = 0 2147483647
net.core.default_qdisc = fq_codel
fs.protected_hardlinks = 1
fs.protected_symlinks = 1
fs.protected_regular = 1
fs.protected_fifos = 1
net.core.optmem_max = 81920
kernel.pid_max = 4194304
kernel.kptr_restrict = 1
net.ipv4.conf.default.rp_filter = 1
net.ipv4.conf.eno1.rp_filter = 1
net.ipv4.conf.lo.rp_filter = 1
fs.aio-max-nr = 1048576
vm.unprivileged_userfaultfd = 1
net.ipv4.ip_forward = 1
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
~~~~

## Desativando o Swap do Linux
~~~~shell
# swapoff -a
# sed -e '/swap/s/^/#/g' -i /etc/fstab

# free -m
               total        used        free      shared  buff/cache   available
Mem:            7566         587        6761           8         460        6979
Swap:              0           0           0
~~~~

## Instalando o Containerd
É um daemon que gerencia o ciclo de vida do contêiner desde baixar e desempacotar a imagem de contêiner até a execução e a supervisão do contêiner.

~~~~shell
# dnf config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo
Adding repo from: https://download.docker.com/linux/centos/docker-ce.repo

# dnf makecache
Docker CE Stable - x86_64                                    119 kB/s |  27 kB     00:00    
Extra Packages for Enterprise Linux 9 - x86_64                58 kB/s |  62 kB     00:01     
Rocky Linux 9 - BaseOS                                       3.9 kB/s | 4.1 kB     00:01    
Rocky Linux 9 - BaseOS                                       1.7 MB/s | 1.9 MB     00:01     
Rocky Linux 9 - AppStream                                    6.3 kB/s | 4.5 kB     00:00    
Rocky Linux 9 - AppStream                                    6.6 MB/s | 7.1 MB     00:01     
Rocky Linux 9 - Extras                                       6.5 kB/s | 2.9 kB     00:00    
Metadata cache created.

# dnf install -y containerd.io
Last metadata expiration check: 0:00:10 ago on Wed Jul  5 09:35:31 2023.
Dependencies resolved.
=====================================================================================================================
 Package                                   Architecture                       Version                                       Repository                                    Size 
=====================================================================================================================
Installing:
 containerd.io                             x86_64                             1.6.21-3.1.el9                                docker-ce-stable                              33 M 

Transaction Summary
=====================================================================================================================
Install  1 Package

Total download size: 33 M
Installed size: 114 M
Downloading Packages:
containerd.io-1.6.21-3.1.el9.x86_64.rpm                           9.4 MB/s |  33 MB     00:03     
----------------------------------------------------------------------------------------------------------------------
Total                                                             9.4 MB/s |  33 MB     00:03     
Docker CE Stable - x86_64                                          33 kB/s | 1.6 kB     00:00    
Importing GPG key 0x621E9F35:
 Userid     : "Docker Release (CE rpm) <docker@docker.com>"
 Fingerprint: 060A 61C5 1B55 8A7F 742B 77AA C52F EB6B 621E 9F35
 From       : https://download.docker.com/linux/centos/gpg
Key imported successfully
Running transaction check
Transaction check succeeded.
Running transaction test
Transaction test succeeded.
Running transaction
  Preparing        :                                                                                                                                                       1/1 
  Installing       : containerd.io-1.6.21-3.1.el9.x86_64                                                                                                                   1/1 
  Running scriptlet: containerd.io-1.6.21-3.1.el9.x86_64                                                                                                                   1/1 
  Verifying        : containerd.io-1.6.21-3.1.el9.x86_64                                                                                                                   1/1 

Installed:
  containerd.io-1.6.21-3.1.el9.x86_64

Complete!

# mv /etc/containerd/config.toml /etc/containerd/config.toml.orig
containerd config default > /etc/containerd/config.toml
~~~~
Ativar a função SystemdCgroup, por volta da linha 125, ``SystemdCgroup = true``

~~~~shell
# nano /etc/containerd/config.toml
disabled_plugins = []
imports = []
oom_score = 0
plugin_dir = ""
required_plugins = []
root = "/var/lib/containerd"
state = "/run/containerd"
temp = ""
version = 2

[cgroup]
  path = ""

[debug]
  address = ""
  format = ""
  gid = 0
  level = ""
  uid = 0

[grpc]
  address = "/run/containerd/containerd.sock"
  gid = 0
  max_recv_message_size = 16777216
  max_send_message_size = 16777216
  tcp_address = ""
  tcp_tls_ca = ""
  tcp_tls_cert = ""
  tcp_tls_key = ""
  uid = 0

[metrics]
  address = ""
  grpc_histogram = false

[plugins]

  [plugins."io.containerd.gc.v1.scheduler"]
    deletion_threshold = 0
    mutation_threshold = 100
    pause_threshold = 0.02
    schedule_delay = "0s"
    startup_delay = "100ms"

  [plugins."io.containerd.grpc.v1.cri"]
    device_ownership_from_security_context = false
    disable_apparmor = false
    disable_cgroup = false
    disable_hugetlb_controller = true
    disable_proc_mount = false
    disable_tcp_service = true
    enable_selinux = false
    enable_tls_streaming = false
    enable_unprivileged_icmp = false
    enable_unprivileged_ports = false
    ignore_image_defined_volumes = false
    max_concurrent_downloads = 3
    max_container_log_line_size = 16384
    netns_mounts_under_state_dir = false
    restrict_oom_score_adj = false
    sandbox_image = "registry.k8s.io/pause:3.6"
    selinux_category_range = 1024
    stats_collect_period = 10
    stream_idle_timeout = "4h0m0s"
    stream_server_address = "127.0.0.1"
    stream_server_port = "0"
    systemd_cgroup = false
    tolerate_missing_hugetlb_controller = true
    unset_seccomp_profile = ""

    [plugins."io.containerd.grpc.v1.cri".cni]
      bin_dir = "/opt/cni/bin"
      conf_dir = "/etc/cni/net.d"
      conf_template = ""
      ip_pref = ""
      max_conf_num = 1

    [plugins."io.containerd.grpc.v1.cri".containerd]
      default_runtime_name = "runc"
      disable_snapshot_annotations = true
      discard_unpacked_layers = false
      ignore_rdt_not_enabled_errors = false
      no_pivot = false
      snapshotter = "overlayfs"

      [plugins."io.containerd.grpc.v1.cri".containerd.default_runtime]
        base_runtime_spec = ""
        cni_conf_dir = ""
        cni_max_conf_num = 0
        container_annotations = []
        pod_annotations = []
        privileged_without_host_devices = false
        runtime_engine = ""
        runtime_path = ""
        runtime_root = ""
        runtime_type = ""

        [plugins."io.containerd.grpc.v1.cri".containerd.default_runtime.options]

      [plugins."io.containerd.grpc.v1.cri".containerd.runtimes]

        [plugins."io.containerd.grpc.v1.cri".containerd.runtimes.runc]
          base_runtime_spec = ""
          cni_conf_dir = ""
          cni_max_conf_num = 0
          container_annotations = []
          pod_annotations = []
          privileged_without_host_devices = false
          runtime_engine = ""
          runtime_path = ""
          runtime_root = ""
          runtime_type = "io.containerd.runc.v2"

          [plugins."io.containerd.grpc.v1.cri".containerd.runtimes.runc.options]
            BinaryName = ""
            CriuImagePath = ""
            CriuPath = ""
            CriuWorkPath = ""
            IoGid = 0
            IoUid = 0
            NoNewKeyring = false
            NoPivotRoot = false
            Root = ""
            ShimCgroup = ""
            SystemdCgroup = true

      [plugins."io.containerd.grpc.v1.cri".containerd.untrusted_workload_runtime]
        base_runtime_spec = ""
        cni_conf_dir = ""
        cni_max_conf_num = 0
        container_annotations = []
        pod_annotations = []
        privileged_without_host_devices = false
        runtime_engine = ""
        runtime_path = ""
        runtime_root = ""
        runtime_type = ""

        [plugins."io.containerd.grpc.v1.cri".containerd.untrusted_workload_runtime.options]

    [plugins."io.containerd.grpc.v1.cri".image_decryption]
      key_model = "node"

    [plugins."io.containerd.grpc.v1.cri".registry]
      config_path = ""

      [plugins."io.containerd.grpc.v1.cri".registry.auths]

      [plugins."io.containerd.grpc.v1.cri".registry.configs]

      [plugins."io.containerd.grpc.v1.cri".registry.headers]

      [plugins."io.containerd.grpc.v1.cri".registry.mirrors]

    [plugins."io.containerd.grpc.v1.cri".x509_key_pair_streaming]
      tls_cert_file = ""
      tls_key_file = ""

  [plugins."io.containerd.internal.v1.opt"]
    path = "/opt/containerd"

  [plugins."io.containerd.internal.v1.restart"]
    interval = "10s"

  [plugins."io.containerd.internal.v1.tracing"]
    sampling_ratio = 1.0
    service_name = "containerd"

  [plugins."io.containerd.metadata.v1.bolt"]
    content_sharing_policy = "shared"

  [plugins."io.containerd.monitor.v1.cgroups"]
    no_prometheus = false

  [plugins."io.containerd.runtime.v1.linux"]
    no_shim = false
    runtime = "runc"
    runtime_root = ""
    shim = "containerd-shim"
    shim_debug = false

  [plugins."io.containerd.runtime.v2.task"]
    platforms = ["linux/amd64"]
    sched_core = false

  [plugins."io.containerd.service.v1.diff-service"]
    default = ["walking"]

  [plugins."io.containerd.service.v1.tasks-service"]
    rdt_config_file = ""

  [plugins."io.containerd.snapshotter.v1.aufs"]
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.devmapper"]
    async_remove = false
    base_image_size = ""
    discard_blocks = false
    fs_options = ""
    fs_type = ""
    pool_name = ""
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.native"]
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.overlayfs"]
    root_path = ""
    upperdir_label = false

  [plugins."io.containerd.snapshotter.v1.zfs"]
    root_path = ""

  [plugins."io.containerd.tracing.processor.v1.otlp"]
    endpoint = ""
    insecure = false
    protocol = ""

[proxy_plugins]

[stream_processors]

  [stream_processors."io.containerd.ocicrypt.decoder.v1.tar"]
    accepts = ["application/vnd.oci.image.layer.v1.tar+encrypted"]
    args = ["--decryption-keys-path", "/etc/containerd/ocicrypt/keys"]
    env = ["OCICRYPT_KEYPROVIDER_CONFIG=/etc/containerd/ocicrypt/ocicrypt_keyprovider.conf"]
    path = "ctd-decoder"
    returns = "application/vnd.oci.image.layer.v1.tar"

  [stream_processors."io.containerd.ocicrypt.decoder.v1.tar.gzip"]
    accepts = ["application/vnd.oci.image.layer.v1.tar+gzip+encrypted"]
    args = ["--decryption-keys-path", "/etc/containerd/ocicrypt/keys"]
    env = ["OCICRYPT_KEYPROVIDER_CONFIG=/etc/containerd/ocicrypt/ocicrypt_keyprovider.conf"]
    path = "ctd-decoder"
    returns = "application/vnd.oci.image.layer.v1.tar+gzip"

[timeouts]
  "io.containerd.timeout.bolt.open" = "0s"
  "io.containerd.timeout.shim.cleanup" = "5s"
  "io.containerd.timeout.shim.load" = "5s"
  "io.containerd.timeout.shim.shutdown" = "3s"
  "io.containerd.timeout.task.state" = "2s"

[ttrpc]
  address = ""
  gid = 0
  uid = 0
~~~~

~~~~shell
# systemctl enable --now containerd.service
Created symlink /etc/systemd/system/multi-user.target.wants/containerd.service → /usr/lib/systemd/system/containerd.service.

# systemctl status containerd.service
● containerd.service - containerd container runtime
     Loaded: loaded (/usr/lib/systemd/system/containerd.service; enabled; preset: disabled)
     Active: active (running) since Wed 2023-07-05 09:38:25 -03; 6s ago
       Docs: https://containerd.io
    Process: 6547 ExecStartPre=/sbin/modprobe overlay (code=exited, status=0/SUCCESS)
   Main PID: 6548 (containerd)
      Tasks: 10
     Memory: 17.0M
        CPU: 65ms
     CGroup: /system.slice/containerd.service
             └─6548 /usr/bin/containerd

Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245156246-03:00" level=info msg="Start subscribing containerd event"
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245215090-03:00" level=info msg="Start recovering state"
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245280462-03:00" level=info msg="Start event monitor"
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245305333-03:00" level=info msg="Start snapshots syncer"
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245317140-03:00" level=info msg="Start cni network conf syncer for default"
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245327590-03:00" level=info msg="Start streaming server"
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245743092-03:00" level=info msg=serving... address=/run/containerd/containerd.sock.ttr>
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.245797297-03:00" level=info msg=serving... address=/run/containerd/containerd.sock     
Jul 05 09:38:25 kubemaster-01.semed.intra containerd[6548]: time="2023-07-05T09:38:25.246226988-03:00" level=info msg="containerd successfully booted in 0.104974s"
Jul 05 09:38:25 kubemaster-01.semed.intra systemd [1]: Started containerd container runtime.
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
# firewall-cmd --permanent --add-port={6443,2379,2380,10250,10251,10252}/tcp
success

# firewall-cmd --reload
success

# firewall-cmd --list-all
public (active)
  target: default
  icmp-block-inversion: no
  interfaces: eno1
  sources:
  services: cockpit dhcpv6-client ssh
  ports: 6443/tcp 2379/tcp 2380/tcp 10250/tcp 10251/tcp 10252/tcp
  protocols:
  forward: yes
  masquerade: no
  forward-ports:
  source-ports:
  icmp-blocks:
  rich rules:
~~~~

## Instalando o Kubernete
~~~~shell

# cat > /etc/yum.repos.d/k8s.repo << EOF
[kubernetes]
name=Kubernetes
baseurl=https://packages.cloud.google.com/yum/repos/kubernetes-el7-\$basearch
enabled=1
gpgcheck=1
gpgkey=https://packages.cloud.google.com/yum/doc/rpm-package-key.gpg
exclude=kubelet kubeadm kubectl
EOF

# dnf makecache
Docker CE Stable - x86_64                               11 kB/s | 3.5 kB     00:00    
Extra Packages for Enterprise Linux 9 - x86_64          54 kB/s |  62 kB     00:01     
Kubernetes                                             176 kB/s | 175 kB     00:00    
Rocky Linux 9 - BaseOS                                 3.1 kB/s | 4.1 kB     00:01    
Rocky Linux 9 - AppStream                              8.2 kB/s | 4.5 kB     00:00    
Rocky Linux 9 - Extras                                 4.4 kB/s | 2.9 kB     00:00    
Metadata cache created.

# dnf install -y {kubelet,kubeadm,kubectl} --disableexcludes=kubernetes
Last metadata expiration check: 0:00:09 ago on Wed Jul  5 09:39:11 2023.
Dependencies resolved.
===========================================================================================================================================================
 Package                                            Architecture                       Version                                    Repository                              Size 
===========================================================================================================================================================
Installing:
 kubeadm                 x86_64                             1.27.3-0                                   kubernetes                              11 M 
 kubectl                 x86_64                             1.27.3-0                                   kubernetes                              11 M 
 kubelet                 x86_64                             1.27.3-0                                   kubernetes                              20 M 
Installing dependencies:
 conntrack-tools         x86_64                             1.4.7-2.el9                                appstream                              221 k 
 cri-tools               x86_64                             1.26.0-0                                   kubernetes                             8.6 M 
 kubernetes-cni          x86_64                             1.2.0-0                                    kubernetes                              17 M 
 libnetfilter_cthelper   x86_64                             1.0.0-22.el9                               appstream                               23 k 
 libnetfilter_cttimeout  x86_64                             1.0.0-19.el9                               appstream                               23 k 
 libnetfilter_queue      x86_64                             1.0.5-1.el9                                appstream                               28 k 
 socat                   x86_64                             1.7.4.1-5.el9                              appstream                              300 k 

Transaction Summary
==================================================================================================================================================
Install  10 Packages

Total download size: 67 M
Installed size: 284 M
Downloading Packages:
(1/10): 693f3c83140151a953a420772ddb9e4b7510df8ae49a79cbd7af48e82e7ad48e-kubectl-1.27.3-0.x86_64.rpm                    11 MB/s |  11 MB     00:00     
(2/10): 413f2a94a2f6981b36bf46ee01ade9638508fcace668d6a57b64e5cfc1731ce2-kubeadm-1.27.3-0.x86_64.rpm                   6.4 MB/s |  11 MB     00:01     
(3/10): 3f5ba2b53701ac9102ea7c7ab2ca6616a8cd5966591a77577585fde1c434ef74-cri-tools-1.26.0-0.x86_64.rpm                 3.4 MB/s | 8.6 MB     00:02     
(4/10): conntrack-tools-1.4.7-2.el9.x86_64.rpm                                                                         1.6 MB/s | 221 kB     00:00     
(5/10): libnetfilter_cttimeout-1.0.0-19.el9.x86_64.rpm                                                                 547 kB/s |  23 kB     00:00     
(6/10): socat-1.7.4.1-5.el9.x86_64.rpm                                                                                 720 kB/s | 300 kB     00:00     
(7/10): libnetfilter_cthelper-1.0.0-22.el9.x86_64.rpm                                                                  249 kB/s |  23 kB     00:00     
(8/10): libnetfilter_queue-1.0.5-1.el9.x86_64.rpm                                                                      178 kB/s |  28 kB     00:00     
(9/10): 0f2a2afd740d476ad77c508847bad1f559afc2425816c1f2ce4432a62dfe0b9d-kubernetes-cni-1.2.0-0.x86_64.rpm             4.5 MB/s |  17 MB     00:03     
(10/10): 484ddb88e9f2aaff13842f2aa730170f768e66fd4d8a30efb139d7868d224fcf-kubelet-1.27.3-0.x86_64.rpm                  3.7 MB/s |  20 MB     00:05     
--------------------------------------------------------------------------------------
Total                                                                                                                                          9.4 MB/s |  67 MB     00:07     
Kubernetes                                                                                                             5.1 kB/s | 975  B     00:00    
Importing GPG key 0x3E1BA8D5:
 Userid     : "Google Cloud Packages RPM Signing Key <gc-team@google.com>"
 Fingerprint: 3749 E1BA 95A8 6CE0 5454 6ED2 F09C 394C 3E1B A8D5
 From       : https://packages.cloud.google.com/yum/doc/rpm-package-key.gpg
Key imported successfully
Running transaction check
Transaction check succeeded.
Running transaction test
Transaction test succeeded.
Running transaction
  Preparing        :                                                               1/1 
  Installing       : libnetfilter_queue-1.0.5-1.el9.x86_64                         1/10 
  Installing       : libnetfilter_cthelper-1.0.0-22.el9.x86_64                     2/10 
  Installing       : socat-1.7.4.1-5.el9.x86_64                                    3/10 
  Installing       : libnetfilter_cttimeout-1.0.0-19.el9.x86_64                    4/10 
  Installing       : conntrack-tools-1.4.7-2.el9.x86_64                            5/10 
  Running scriptlet: conntrack-tools-1.4.7-2.el9.x86_64                            5/10 
  Installing       : kubernetes-cni-1.2.0-0.x86_64                                 6/10 
  Installing       : kubelet-1.27.3-0.x86_64                                       7/10 
  Installing       : kubectl-1.27.3-0.x86_64                                       8/10 
  Installing       : cri-tools-1.26.0-0.x86_64                                     9/10 
  Installing       : kubeadm-1.27.3-0.x86_64                                       10/10 
  Running scriptlet: kubeadm-1.27.3-0.x86_64                                       10/10 
  Verifying        : cri-tools-1.26.0-0.x86_64                                      1/10 
  Verifying        : kubeadm-1.27.3-0.x86_64                                        2/10 
  Verifying        : kubectl-1.27.3-0.x86_64                                        3/10 
  Verifying        : kubelet-1.27.3-0.x86_64                                        4/10 
  Verifying        : kubernetes-cni-1.2.0-0.x86_64                                  5/10 
  Verifying        : conntrack-tools-1.4.7-2.el9.x86_64                             6/10 
  Verifying        : libnetfilter_cttimeout-1.0.0-19.el9.x86_64                     7/10 
  Verifying        : socat-1.7.4.1-5.el9.x86_64                                     8/10 
  Verifying        : libnetfilter_cthelper-1.0.0-22.el9.x86_64                       9/10 
  Verifying        : libnetfilter_queue-1.0.5-1.el9.x86_64                          10/10 

Installed:
  conntrack-tools-1.4.7-2.el9.x86_64         cri-tools-1.26.0-0.x86_64          kubeadm-1.27.3-0.x86_64                        kubectl-1.27.3-0.x86_64
  kubelet-1.27.3-0.x86_64                    kubernetes-cni-1.2.0-0.x86_64      libnetfilter_cthelper-1.0.0-22.el9.x86_64      libnetfilter_cttimeout-1.0.0-19.el9.x86_64      
  libnetfilter_queue-1.0.5-1.el9.x86_64      socat-1.7.4.1-5.el9.x86_64

Complete!

# systemctl enable --now kubelet.service
Created symlink /etc/systemd/system/multi-user.target.wants/kubelet.service → /usr/lib/systemd/system/kubelet.service.

# systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: disabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: activating (auto-restart) (Result: exit-code) since Wed 2023-07-05 09:39:58 -03; 4s ago
       Docs: https://kubernetes.io/docs/
    Process: 6902 ExecStart=/usr/bin/kubelet $KUBELET_KUBECONFIG_ARGS $KUBELET_CONFIG_ARGS $KUBELET_KUBEADM_ARGS $KUBELET_EXTRA_ARGS (code=exited, status=1/FAILURE)
   Main PID: 6902 (code=exited, status=1/FAILURE)
        CPU: 60ms
~~~~
## O  kubelet não iniciou mais no final o funcioanou
~~~~shell
# source <(kubectl completion bash)
kubectl completion bash > /etc/bash_completion.d/kubectl

# mkdir /opt/bin

# curl -fsSLo /opt/bin/flanneld https://github.com/flannel-io/flannel/releases/download/v0.20.1/flannel-v0.20.1-linux-amd64.tar.gz

# chmod +x /opt/bin/flanneld

# kubeadm config images pull
[config/images] Pulled registry.k8s.io/kube-apiserver:v1.27.3
[config/images] Pulled registry.k8s.io/kube-controller-manager:v1.27.3
[config/images] Pulled registry.k8s.io/kube-scheduler:v1.27.3
[config/images] Pulled registry.k8s.io/kube-proxy:v1.27.3
[config/images] Pulled registry.k8s.io/pause:3.9
[config/images] Pulled registry.k8s.io/etcd:3.5.7-0
[config/images] Pulled registry.k8s.io/coredns/coredns:v1.10.1

# kubeadm init --pod-network-cidr=10.244.0.0/16
[init] Using Kubernetes version: v1.27.3
[preflight] Running pre-flight checks
        [WARNING Firewalld]: firewalld is active, please ensure ports [6443 10250] are open or your cluster may not function correctly
        [WARNING Hostname]: hostname "kubemaster-01.centlinux.com" could not be reached
        [WARNING Hostname]: hostname "kubemaster-01.centlinux.com": lookup kubemaster-01.semed.intra on 172.
        15.1.3:53: no such host
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
W0705 09:45:59.498119    7396 checks.go:835] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm. It is recommended that using "registry.k8s.io/pause:3.9" as the CRI sandbox image.
[certs] Using certificateDir folder "/etc/kubernetes/pki"
[certs] Generating "ca" certificate and key
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [kubemaster-01.semed.intra kuberne
tes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local] and IPs [10.96.0.1 172.15.46.3]
[certs] Generating "apiserver-kubelet-client" certificate and key
[certs] Generating "front-proxy-ca" certificate and key
[certs] Generating "front-proxy-client" certificate and key
[certs] Generating "etcd/ca" certificate and key
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [kubemaster-01.semed.intra localho
st] and IPs [172.15.46.3 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [kubemaster-01.semed.intra localho
st] and IPs [172.15.46.3 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
[kubeconfig] Writing "admin.conf" kubeconfig file
[kubeconfig] Writing "kubelet.conf" kubeconfig file
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
[control-plane] Creating static Pod manifest for "kube-scheduler"
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests". This can take up to 4m0s
[apiclient] All control plane components are healthy after 14.501908 seconds
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node kubemaster-01.semed.intra as cont
rol-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node kubemaster-01.semed.intra as cont
rol-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: pefwzs.qgtfraiikw3kl43s
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
[addons] Applied essential addon: CoreDNS
[addons] Applied essential addon: kube-proxy

Your Kubernetes control-plane has initialized successfully!

To start using your cluster, you need to run the following as a regular user:

  mkdir -p $HOME/.kube
  sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
  sudo chown $(id -u):$(id -g) $HOME/.kube/config

Alternatively, if you are the root user, you can run:

  export KUBECONFIG=/etc/kubernetes/admin.conf

You should now deploy a pod network to the cluster.
Run "kubectl apply -f [podnetwork].yaml" with one of the options listed at:
  https://kubernetes.io/docs/concepts/cluster-administration/addons/

Then you can join any number of worker nodes by running the following on each as root:

kubeadm join 172.15.46.3:6443 --token pefwzs.qgtfraiikw3kl43s \
        --discovery-token-ca-cert-hash sha256:5f261eaff65df07168a263326c892741109050d570d45b2320bc2bc47cf762fd

# echo "export KUBECONFIG=/etc/kubernetes/admin.conf" >> /etc/profile.d/k8s.sh

# mkdir -p $HOME/.kube
cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
chown $(id -u):$(id -g) $HOME/.kube/config

# kubectl get nodes
NAME                          STATUS     ROLES           AGE   VERSION
kubemaster-01.semed.intra   NotRe
ady   control-plane   43s   v1.27.3

# kubectl cluster-info
Kubernetes control plane is running at https://172.15.46.3:6443
CoreDNS is running at https://172.15.46.3:6443/api/v1/namespaces/kube-system/services/kube-dns:dns/proxy

To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.

# kubectl apply -f https://raw.githubusercontent.comcumentation/kube-flannel.yml
namespace/kube-flannel created
clusterrole.rbac.authorization.k8s.io/flannel created
clusterrolebinding.rbac.authorization.k8s.io/flannel created
serviceaccount/flannel created
configmap/kube-flannel-cfg created
daemonset.apps/kube-flannel-ds created

# kubectl get pods --all-namespaces
NAMESPACE      NAME                                                  READY   STATUS     RESTARTS   AGE
kube-flannel   kube-flannel-ds-lgmz6                                 0/1     Init:1/2   0          12s
kube-system    coredns-5d78c9869d-8n4hf                              0/1     Pending    0          72s
kube-system    coredns-5d78c9869d-fcb9q                              0/1     Pending    0          72s
kube-system    etcd-kubemaster-01.semed.intra                        1/1     Running    0          77s
kube-system    kube-apiserver-kubemaster-01.semed.intra              1/1     Running    0          77s
kube-system    kube-controller-manager-kubemaster-01.semed.intra     1/1     Running    0          77s
kube-system    kube-proxy-lstc4                                      1/1     Running    0          73s
kube-system    kube-scheduler-kubemaster-01.semed.intra              1/1     Running    0          77s
~~~~

## Iniciando o Kubemaster
~~~~shell
# kubectl get nodes
NAME                          STATUS     ROLES           AGE   VERSION
kubemaster-01.semed.intra   NotReady   control-plane   43s   v1.27.3
~~~~
[Ativando](https://stackoverflow.com/questions/46172741de-not-ready)
~~~~shell
# kubectl apply -f "https://cloud.weave.works/k8s/net?k8s-version=$(kubectl version | base64 | tr -d '\n')"
WARNING: This version information is deprecated and will be replaced with the output from kubectl version --short.  Use --output=yaml|json to get the full version.
Unable to connect to the server: dial tcp: lookup cloud.weave.works on 172.15.1.3:53: no such host
~~~~

~~~~shell
# kubectl get nodes
NAME                          STATUS   ROLES           AGE   VERSION
kubemaster-01.semed.intra     Ready    control-plane   12m   v1.27.3
~~~~

# Adicionando os Workers

Itens necessarios kubelet,kubeadm,kubectl, desativar o swap, os modulos 8ks

Ajustendo o DNS
~~~~shell
# nano   /etc/hosts
        172.15.5.1 kube-master  kube-master.semed.intra
        172.15.5.2 kube-worker-1  kube-worker-1.semed.intra
        172.15.5.3 kube-worker-2  kube-worker-2.semed.intra

~~~~

Instalando as aplicações do kubernetes
~~~~shell
# cat <<EOF | sudo tee /etc/yum.repos.d/kubernetes.repo
[kubernetes]
name=Kubernetes
baseurl=https://packages.cloud.google.com/yum/repos/kubernetes-el7-\$basearch
enabled=1
gpgcheck=1
repo_gpgcheck=1
gpgkey=https://packages.cloud.google.com/yum/doc/yum-key.gpg https://packages.cloud.google.com/yum/doc/rpm-package-key.gpg
exclude=kubelet kubeadm kubectl
EOF

# dnf install -y kubelet kubeadm kubectl --disableexcludes=kubernetes

# firewall-cmd --permanent --add-port={6443,2379,2380,10250,10251,10252}/tcp

# firewall-cmd --reload

# swapoff -a
# sed -e '/swap/s/^/#/g' -i /etc/fstab

# modprobe overlay

# modprobe br_netfilter

# cat > /etc/modules-load.d/k8s.conf << EOF
overlay
br_netfilter
EOF

# cat > /etc/sysctl.d/k8s.conf << EOF
net.ipv4.ip_forward = 1
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
EOF

# sysctl --system

# dnf config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo

# dnf makecache

# dnf install -y containerd.io nano

# mv /etc/containerd/config.toml /etc/containerd/config.toml.orig

# containerd config default > /etc/containerd/config.toml

# nano /etc/containerd/config.toml
..........
            SystemdCgroup = true
.........

# systemctl enable --now containerd.service

# kubeadm join 172.15.5.1:6443 --token bkh2lw.dicznliycgv6qw2l \ --discovery-token-ca-cert-hash sha256:e9c920d323e820e80bbe082c049345952abe5703964d79d5f8059fd93cebabaf

[preflight] Running pre-flight checks
        [WARNING Service-Kubelet]: kubelet service is not enabled, please run 'systemctl enable kubelet.service' 
[preflight] Reading configuration from the cluster...
[preflight] FYI: You can look at this config file with 'kubectl -n kube-system get cm kubeadm-config -o yaml'    
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Starting the kubelet
[kubelet-start] Waiting for the kubelet to perform the TLS Bootstrap...

This node has joined the cluster:
* Certificate signing request was sent to apiserver and a response was received.
* The Kubelet was informed of the new secure connection details.

Run 'kubectl get nodes' on the control-plane to see this node join the cluster.
~~~~

## Verificando conexão
~~~~shell
$ sudo kubectl get nodes
NAME            STATUS   ROLES           AGE     VERSION
kube-master     Ready    control-plane   19h     v1.27.3
kube-worker-1   Ready    <none>          7m22s   v1.27.3
~~~~

# Primeiros teste

## Exemplo - 1
Criar. ver se iniciou e deletar

~~~~shell
# kubectl run nginx --image nginx
pod/nginx created

# kubectl get pods
NAME    READY   STATUS    RESTARTS   AGE
nginx   0/1     Pending   0          11s

# kubectl delete pod nginx
pod "nginx" deleted
~~~~

## Exemplo - 2

~~~~shell
$ curl -lo nginx.yaml "https://gist.githubusercontent.com/nonanom/498b913a69cede7037d55e28bb00344e/raw"
  % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
                                 Dload  Upload   Total   Spent    Left  Speed
100   577  100   577    0     0   1814      0 --:--:-- --:--:-- --:--:--  1814
# kubectl apply --filename nginx.yaml
service/nginx created
deployment.apps/nginxministrador]# kubectl get pods
NAME                     READY   STATUS    RESTARTS   AGE
nginx-57d84f57dc-gfwxk   1/1     Pending   0    

# kubectl get deployments
NAME    READY   UP-TO-DATE   AVAILABLE   AGE
nginx   1/1     1            0      

# kubectl get services
NAME         TYPE        CLUSTER-IP      EXTERNAL-IP   PORT(S)   AGE
kubernetes   ClusterIP   10.96.0.1       <none>        443/TCP   12m
nginx        ClusterIP   10.106.27.238   <none>        80/TCP    104s

# kubectl port-forward service/nginx 8080:80
error: unable to forward port because pod is not running. Current status=Pending
~~~~

