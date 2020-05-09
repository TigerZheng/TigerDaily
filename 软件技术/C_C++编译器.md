# MSVC

MSVC是微软Windows平台Visual Studio自带的C/C++编译器。

***优点***：对Windows平台支持好，编译快。

***缺点***：对C++的新标准支持得少。

# GCC

GCC原名GNU C Compiler，后来逐渐支持更多的语言编译（C++、Fortran、Pascal、Objective-C、Java、Ada、Go等），所以变成了GNU Compiler Collection（GNU编译器套装），是一套由GNU工程开发的支持多种编程语言的编译器。GCC是自由软件发展过程中的著名例子，由自由软件基金会以GPL协议发布，是大多数类Unix（如Linux、BSD、Mac OS X等）的标准编译器，而且适用于Windows（借助其他移植项目实现的，比如MingW、Cygwin等）。GCC支持多种计算机体系芯片，如x86、ARM，并已移植到其他多种硬件平台。

***优点***：类Unix下的标准编译器，支持众多语言，支持交叉编译。

***缺点***：默认不支持Windows，需要第三方移植才可用于Windows。

# Cygwin

Cygwin是一个Windows下Unix-like模拟环境，具体说就是Unix-like接口（OS API，命令行）重定向层，其目的是不修改软件源码仅重新编译就可以将Unix-like系统上的软件移植到Windows上（这个移植也许还算不上严格意义上的无缝移植）。始于1995年，最初作为Cygnus软件公司工程师Steve Chamberlain的一个项目。

***和GCC的关系***：Cygwin是让Windows拥有Unix-like环境的软件而不是编译器，GCC是安装在Cygwin上的编译器。

***优点***：可以比MingW移植更多的软件到Windows上，对Linux接口模拟比MingW全面。

***缺点***：软件运行依赖cygwin1.dll，速度受点影响。

 ***注意\***：Unix-like模拟环境不是Unix虚拟环境，很多论述中都声称Cygwin是在Windows上尽可能模拟类Unix环境，这容易造成误解，好像类Unix的elf程序可以直接运行在安装了Cygwin的Windows上一样。Cygwin和Wine的思路是不同的。在Windows+Cygwin上你可以像类Unix那样使用命令行和编程，但elf等非exe格式的程序是不能被Cygwin运行的，所以Cygwin和Unix虚拟机、Wine是完全不同的，叫Unix-like环境，模拟非虚拟，是有限的选择性的模拟，请不要误解。

 

# MinGW

MinGW（Minimalist GNU on Windows）是一个Linux/Windows下的可以把软件源码中Unix-like OS API调用通过头文件翻译替换成相应的Windows API调用的编译环境，其目的和Cygwin相同。从而把Linux上的软件在不修改源码的情况下编译为可直接在Win下执行的exe。

***和GCC的关系***：MingW是编译环境，不是编译器，GCC是MingW中的核心组成。

***优点***：在Win下可以和Linux一样的方式编译C/C++源码，可以说是Win版的GCC，其生产的Windows PE程序相比Cygwin不依赖任何第三方库，比Cygwin纯粹，理论上也更快速。

***缺点***：编译速度、编译出的程序在算法上可能都比MSVC慢。

# 总结

与Windows下其它编译器不同的是，MinGW与Linux下广泛使用的GNU近乎完全兼容，这意味着，在Linux下如何编译源代码，在MinGW中也可以以完全相同的方式编译。有些Linux下的开发人员（比如开源阵营）发布的源代码通常只提供Linux下的编译方式，而不提供Windows下的编译方式（这可能与其不熟悉windows操作系统有关），但确实有不少用户需要在在Windows下编译使用此源代码。这在种情况下，如果Windows用户想用VC、BC等编译器编译该源代码，必须重写Makefile（各种编译器所支持的Makefile不尽相同），工作量比较大不说，还很难保证不出错。MinGW的出现，提供了两个平台下的“跨平台编译方案”。MinGW与MSYS相配合，连./configure都有了。与GNU不同的是，MinGW编译生成的是Windows下的可执行文件（.exe）或库文件（.dll,.lib）——不过编译过程中的的中间文件仍然是.o文件，而不是.obj文件（这当然无所谓了，中间文件嘛，编译完成后就没有用了）。