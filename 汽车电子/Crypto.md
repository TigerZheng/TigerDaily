

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





# AES



# 3DES



# RSA



# ECC



# CRC 



# TRNG



# PRNG



# GCM



# SHA-1/2/3