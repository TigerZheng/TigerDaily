# AP

## 应用场景

高算力、高通信带宽、分布式部署的汽车应用领域如：ADAS、自动驾驶等

提供灵活的软件配置如：支持无线更新软件(FOTA)。

更严苛的integrity和security要求如：随着外部系统的不断发展或改进的功能，要求车辆中的软件能够不断被更新。如：将车辆融入到外部后台系统和基建系统中。如：环境感知、行为计划等功能，

## 架构

定义了一个ARA运行环境（AUTOSAR Runtime for Adaptive Applications）

分为两种接口类型：service和APIs

由根据服务（Platform Service）和Adaptive AUTOSAR基础（Platform Foundation）分组的多个功能栈（功能集群）组成

聚合了自适应平台功能

定义了功能栈需求规范

从应用程序和网络角度描述软件平台的行为

每台（虚拟）计算机必须至少有一个包含Adaptive AUTOSAR基础（Platform Foundation）的实例，

而服务功能栈（Platform Service）可能分布于车载网络中。

相比于Classic AUTOSAR，用于Adaptive AUTOSAR的AUTOSAR Runtime Environment在运行时动态链接服务和客户端。

## 特点

3.1 基于C++语言面向对象开发

3.2 SOA架构（service-oriented architecture）

3.3 基于服务的SOA动态通信方式（SOME/IP…）

3.4 硬件资源间的连接关系虚拟化，不局限于通信线束的连接关系（互联网）

3.5 服务可根据应用需求动态加载，可通过配置文件动态加载配置，并可进行单独更新

3.6 application加载到RAM运行，每个application独享（虚拟）一个地址空间

3.7 POSIX-basedOS（Linux\PikeOS…），兼容性广，可移植性高

## 优势

ECU更加智能：基于SOA通信使得AP中ECU可以动态的同其他ECU提供或获取服务，动态同其他ECU进行连接

更强大计算能力：基于SOA架构使得AP能够更好支持多核、多ECU、多SoCs并行处理，提供更强大的计算能力

更加安全：基于SOA架构使得AP中各个服务模块独立，可独立加载，IAM管理访问权限

敏捷开发：Adaptive AUTOSAR服务不局限于部署在ECU本地可分布于车载网络中，使得系统模块可灵活部署，并可后期灵活独立更新（FOTA）

高通信带宽：基于Ethernet等高通信带宽的总线通信

更易物联：基于以太网的SOA通信，更易实现无线、远程、云连接，部署V2X应用

系统兼容：通过SOME\IP等协议AP可以同CP/Non-AUTOSAR等ECU交互

# CP

## 应用场景

传统嵌入式ECU

如：EMS、BCM、BMS等架构

## 架构

Application不依赖于硬件模块间通过RTE交互，并通过RTE访问BSW

runtime environment(RTE)体现了application的所有接口

basic software(BSW)

服务层

如：系统服务、存储服务、通信服务等

ECU抽象层

MCU抽象层

复杂驱动:AUTOSAR为涵盖的部分，用户自定义的。

## 特点

基于C语言面向过程开发

FOA架构（function-oriented architecture）

基于信号的静态配置通信方式（LIN\CAN...通信矩阵）

硬件资源的连接关系局限于线束的连接

静态的服务模块，模块和配置在发布前进行静态编译、链接

大部分代码静态运行在ROM，所有application共用一个地址空间

OSEK OS

## 目的

避免反复重复开发功能相同相近的软件模块

使用独立于系统的标准软件平台

缩短产品上市时间，减少开发工作

同一组组件中开发出更多产品，提高产品质量

# 网络资源

[官网](https://www.autosar.org/)