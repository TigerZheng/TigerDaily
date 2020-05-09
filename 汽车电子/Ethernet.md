# 数据库



# AVB/TSN

# 标准化组织

## OPEN Alliance

> TC1:Interoperability&Compliance Tests for 100BASE-T1 PHYs

> TC2:100BASE-T1 Ethernet Channel&Components

> TC3:1000BASE-T1 CMC Requirements

> TC4:Tools

> TC5:Gap Identification

> TC6:Common xMll Interface Definition

> TC7:1000BASE-RH Gigabit Ethernet over Plastic-Optical-Fiber（GEPOF）

> TC8:Automotive Ethernet ECU Test Specification

> TC9:Automotive Ethernet Channel&Components

> TC10:Automotive Ethernet Sleep/Wake-Up

> TC11:Ethernet switch requirments and qualification

> TC12:Test specification for the compliance testing of IEEE 1000BASE-T1 Physical Interface(PHY) devices

> TC13:New Test House Qualification Requirments

> TC14:Interoperability &Compliance Tests for 10BASE-T1S PHYs

## IEEE

> 802.3bp:1000BASE-T1

> 802.3bu:one-pair Power Over Data Line

> 802.3bv:1000BASE-RH

> 802.3bw:100BASE-T1

> 802.3cg:10BASE-T1(S)

> 802.3ch:Multi-Gig Automotive Ethernet

> 802.1:AVB/TSN 技术规范

## AVnu Alliance

成立于2009年，它的使命是推动AVB/TSN相关标准的应用，创建一个开放、安全、低延迟和高度可靠的网络生态系统

IEEE负责制定AVB/TSN标准，AVnu负责制定系列测试标准来解决AVB/TSN技术在某个领域的应用

AVnu专注于A/V、工业、消费电子和汽车行业，为了保证AVB/TSN互操作性，AVnu联盟专门为相关领域创建了符合市场要求的合规性和互操作性（C&I)测试集

AVnu联盟制定的gPTP、FQTSS和AVTP的测试规范，可以快速提高AVB技术在汽车网络上的落地应用

## IETF

The Internet Engineering Task Force，国际互联网工程任务组

负责互联网相关技术规范研发和制定的主要组织，大家所熟知的互联网最基本的TCP/IP协议簇，就是由IETF制定的

TCP/IP协议簇由数十个不同协议组成，各协议都有对应的RFC标准文档，如RFC791文档不仅定义了IPv4协议，还包括大家耳熟能详的ARP、ICMP、UDP、DHCP、HTTP、RTP协议等

汽车以太网不需要对TCP/IP协议簇进行修改，仅需要做适应性的配置和应用

## AUTOSAR

架构图:![image-20200502185505095](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200502185505095.png)

联盟致力于为汽车工业制定标准化的软件架构，通过使用统一的软硬件接口实现不同开发商软件模块的兼容性

Classic AUTOSAR从4.0版本开始支持以太网通信，主要包括Ethernet驱动、Ethernet接口、TCP/IP、Socket Adaptor、DoIP、UDPNM、SOME/IP等软件模块。

AUTOSAR的以太网相关文档详细定义了以太网通信软件模块的需求、函数接口、配置参数等内容。

AUTOSAR还规定了TCP、UDP和IPv4这三个通信协议的测试规范，用于对符合AUTOSAR标准的协议栈进行测试。

## ISO

International Organization for Standardization，国际标准化组织

制定了众多汽车相关的标准化协议，如ISO11898（CAN）、ISO14229（UDS）等

汽车以太网相关ISO标准主要有ISO13400（DoIP）、ISO17215（VCIC）

ISO在2016年启动了ISO 21111“道路车辆-车内以太网” 项目，用于开展包括所有速率和介质的汽车以太网相关研究。

## CAICV

中国智能网联汽车产业联盟（CAICV）也成立了新型车载高速网络工作组（NIVN），用于促进国内新型车载高速网络的生态系统建设，并建立测试验证体系