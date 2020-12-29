#!/bin/bash
#Script para rotacionamento da Area de Trabalho
# https://www.vivaolinux.com.br/topico/Unity/Alternar-areas-de-trabalho-automaticamente
# Criar alternanceia para possibilitar a exibição dos monitoramentos no servidor de apoio-01
export DISPLAY=":0.0"
while true; do
    # Área de trabalho 1
    /usr/bin/wmctrl -s1 
    /bin/sleep 10
    # Área de trabalho 2
    /usr/bin/wmctrl -s2
    /bin/sleep 10 # 10 segundos
    # Área de trabalho 0
    /usr/bin/wmctrl -s0
    /bin/sleep 40 # 40 segundos 
done
