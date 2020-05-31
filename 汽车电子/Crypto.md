

# 概述

为了满足网络安全的相关要求，车载电子设备提出了加密通信的新需求需求，为满足这一应用需求各大芯片厂商纷纷在自家的芯片中添加了Crypto Engine，那么Crypto是怎么一回事儿？在加密通信中是如何发挥作用，满足应用需求的呢？

## CP中的Crypto

![image-20200524094610388](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200524094610388.png)

![image-20200530102618995](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200530102618995.png)

## AP中的Crypto

![image-20200524094658035](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200524094658035.png)

# 机密的关键

1.秘钥管理：生成与更新、防盗取、防泄漏。

2.加密算法：稳定、高效、高速。

# Crypto Engine

加密引擎一般为硬件加上能够操作该硬件的软件库，该引擎专为加解密操作设计，通过硬件机制提高加解密效率，使加解密高效可靠，易开发、使用。

# eSHE

eSHE:Enhanced Secure Hardware Extension 即增强型安全硬件扩展，一般为芯片厂商提供的用于片上硬件机制，用于加解密功能及应用的开发，加速加解密速度，具体需依据芯片而异，详细介绍可以参照具体芯片的数据手册进行了解。

# HSM

**H**ardware **S**ecurity **M**odule，硬件安全模块，用户可以自己写程序、部署加密算法，



# CSE

完全按照SHE官方的规范来执行，缺少灵活性



# AES

百度百科：

> Advanced Encryption Standard，密码学中的高级加密标准，又称Rijndael加密法]，是美国联邦政府采用的一种区块加密标准。这个标准用来替代原先的DES（Data Encryption Standard），已经被多方分析且广为全世界所使用。经过五年的甄选流程，高级加密标准由美国国家标准与技术研究院 （NIST）于2001年11月26日发布于FIPS PUB 197，并在2002年5月26日成为有效的标准。2006年，高级加密标准已然成为***对称密钥加密***中最流行的算法之一,AES在软件及硬件上都能快速地加解密，相对来说较易于实现，且只需要很少的存储器。

简书：

> Advanced Encryption Standard为最常见的对称加密算法.
>
> [原文](https://blog.csdn.net/qq_28205153/article/details/55798628)

# 3DES

3DES又称Triple DES，是DES加密算法的一种模式，它使用2条不同的56位的密钥对数据进行三次加密。是一种对称秘钥加密法。

***具体实现***

设Ek()和Dk()代表DES算法的加密和解密过程，K代表DES算法使用的[密钥](https://baike.baidu.com/item/密钥)，M代表明文，C代表密文，这样：

3DES加密过程为：C=Ek3(Dk2(Ek1(M)))

3DES解密过程为：M=Dk1(Ek2(Dk3(C)))

是DES向AES过渡的加密算法。

# RSA

是一种非对称加密法，为提高保密强度，RSA密钥至少为500位长，一般推荐使用1024位。这就使加密的计算量很大。

# ECC



# CRC 



# TRNG



# PRNG



# GCM

[简书介绍](https://blog.csdn.net/T0mato_/article/details/53160772)

# SHA

Secure Hash Algorithm，安全散列算法，是一个密码散列函数家族，能计算出一个数字消息所对应到的，长度固定的字符串（又称消息摘要）的算法。且若输入的消息不同，它们对应到不同字符串的机率很高。SHA家族的五个算法，分别是SHA-1、SHA-224、SHA-256、SHA-384，和SHA-512，后四者有时并称为SHA-2。