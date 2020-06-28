# 基本操作流程

![img](https://upload-images.jianshu.io/upload_images/14066340-4038702178a12cdf.png)

![img](https://upload-images.jianshu.io/upload_images/14066340-fcf30526e9d259c2.png)

# 文件注释

文件开头必须满足下列文件注释格式，文件才可以被Doxygen有效识别。

> 1. `/*! \file FILENAME */`
>
>    FILENAME 必须要与文件名一直，区分大小写。

# 代码注释

> 1.JavaDoc 类型
>
> ```c
> /*
> *	...... comment ......
> */
> ```
>
> 

> 2.Qt类型
>
> ```c
> /*!
> *	...... comment .....
> */
> ```



> 3.单行注释位于语句上方
>
> ```///...... comment ......```
>
> ```//！...... comment ...... ```





> 4.单行注释位于语句同行后方
>
> ```//!< ......comment......``` 
>
> ```///<......comment......```

# Doeygen常用命令

> 1. 文件信息：
>    　 1) @file    --> 文件声明，即当前文件名
>      2) @author --> 作者
>      3) @version --> 版本，推荐使用$Id$
>      4) @todo   --> 改进，可以指定针对的版本。

> 2. 模块信息：
>    　 1) @var    --> 模块变量说明
>      2) @typedef --> 模块变量类型说明

> 3. 函数信息：
>    　 1) @param --> 参数说明
>      2) @arg    --> 列表说明参数信息
>      3) @return  --> 返回值说明
>      4) @retval  --> 返回值类型说明
>      5) @note   --> 注解

>4. 提醒信息：
>　      1) @brief          --> 摘要，即当前文件说明
>　2) @see             --> 参看
>　3) @attention  --> 注意
>　4) @bug            --> 问题
>    5) @warning    --> 警告
>　6) @sa               --> 参考资料
>
>

> "@"和 " \ "在 Doxygen 中是一样的，都是告诉 Doxygen后面是一个指令。

# 工具配置

> 1.配置输入文件
>
> 1.1 编程语言的配置
>
> 官方支持的语言可以在下图中查看。
>
> ![img](https://upload-images.jianshu.io/upload_images/14066340-32598943f0238adb.png)
>
> 如果您使用的编程语言不再官方支持之列，可以通过设置使其支持，具体方法  **后续补充 **

>  2.配置输出文件
>
>  2.1 HTML文件输出配置
>
>  格式配置：
>
>  需要提前生成.html文件，此处是配置相应.html文件的导入路径。
>
>  ![img](https://upload-images.jianshu.io/upload_images/14066340-c1e223b1d7811358.png)
>
>  色彩配置：
>
>  ![img](https://upload-images.jianshu.io/upload_images/14066340-2674a4fb2b045813.png)

> 3.导航栏配置
>
> ![img](https://upload-images.jianshu.io/upload_images/14066340-cb0c5125fa6bc66c.png)
>
> ![img](https://upload-images.jianshu.io/upload_images/14066340-746735e1cbac4391.png)

# Dot配置

> [官网](https://graphviz.gitlab.io/)下载Graphviz压缩包到本地，解压缩后存储到任意位置即可，然后自行添加环境变量，如下图所示：
>
> ![image-20200504091610137](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200504091610137.png)
>
> ![image-20200504091811660](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200504091811660.png)

> 在 Doxygen中配置如下图所示。
>
> ![image-20200504092101194](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200504092101194.png)
>
> ![image-20200504092228196](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200504092228196.png)

# 编码设置

![image-20200504092328888](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200504092328888.png)

![image-20200504092433321](C:\Users\zheng\AppData\Roaming\Typora\typora-user-images\image-20200504092433321.png)

# FAQ

## Q:HTML Help 报错

> Error: When enabling GENERATE_HTMLHELP the search engine (SEARCHENGINE) should be disabled. I'll do it for you.
>
> warning: The selected output language "chinese" has not been updated
>
> since release 1.8.2. As a result some sentences may appear in English.

A：

> 解决：把HTML里面的SEARCHENGINE设置为NO

# 附录一 C语言注释模板

## 文件头

## 函数头

## 变量注释

## 宏定义注释

## 结构体注释

## 枚举注释

