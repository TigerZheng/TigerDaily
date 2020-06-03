# 博世

![img](http://5b0988e595225.cdn.sohucs.com/images/20190304/bc2f9fc600004da7bb9e73f6bc497ac4.jpeg)

# 大陆

大陆将汽车电子电器架构的发展分为了三个阶段：分别为当前的分布式架构，下一步的域控制器架构，以及最终的central and zone架构，具体如下：

![image-20200603171225276](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200603171225276.png)

大陆从通信角度对其进行了详细的分析，包括链路的通信速度，以太网链路的数量，数据流拥堵的节点数，链路通信负载，L2框架的大小，动态网络配置等。

![image-20200603171338403](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200603171338403.png)

![image-20200603171350735](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200603171350735.png)

大陆对TSN(Time sensitive networking)在汽车上也进行了展望，首先TSN具有预留带宽、流量优先级、时间同步、流量基于时间调度、抢占帧五大能力，消除了传统以太网由于通信拥堵导致的不确定性，可以满足汽车对可预测延迟和保证带宽不断成长的需求。

对于汽车而言，大陆认为TSN的类型主要从两个方面考虑，一个为TSN的端口类型，一个为TSN桥。

首先TSN端口类型分为：

单端口通话器/监听器：主要用于安全数据处理单元，包括服务器以及天线模块

单端口通话器：用于ADAS的安全传感器，包括雷达，摄像头等

单端口监听器：用于安全相关的执行器，包括转向，刹车等。

从TSN桥来看，可分为3端口网桥(支持唤醒拓扑)、接入网桥(与网布车辆网络的接口)、聚合网桥。

从TSN端口和网桥的角度，大陆对以上提到的三种架构进行了对比，可以看出来以太网在之后的架构中将担起汽车电子电器架构中数据传输的重担，但是CAN、LIN、CAN FD依旧会保留，主要用于zone控制器与执行器、传感器之间以及执行器与传感器之间的通信。

![image-20200603171706450](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200603171706450.png)

# 特斯拉

