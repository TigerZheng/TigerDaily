DoIP-Diagnostic communication over Internet Protocol

# 标准协议

## ISO13400 系列标准

Part 1: General information and use case defnition

Part 2: Transport protocol and network layer services

规定了DoIP通信在传输层中使用TCP和UDP协议，在网络层中使用IPv4或IPv6

定义了专属于DoIP通信的信息内容，这些信息和上层的诊断命令共同构成了传给TCP或UDP协议的SDU

定义了DoIP诊断通信对Ethernet数据链路层（层2）和物理层（层1）的要求,比如，规定DoIP通信在这两层上支持100BASE-TX (100 Mbit/s Ethernet) 和10BASE-T (10 Mbit/s Ethernet) 两种方案。

## Part 3: Wired vehicle interface based on IEEE 802.3

## Part 4: Ethernet Diagnostic Connector

## Part 5: Conformance test specifcation

# 14229系类标准

## 14229-2：UDS的完整定义

## 14229-5：UDS通过网络协议传输的实现

# 特点优势

更快的诊断响应

传输大量数据的时间更短（用于软件刷新和参数下载）

使得远程的直接诊断成为可能

# 应用场景

点对点直连

多台外部测试设备分别和多台汽车在局域网内通过交换机点对点连接

一台外部测试设备跨越本地网络与多台车辆连接

外部测试设备的多个应用层实体（在一台硬件或多台硬件上）与单个车辆连接

