# 文件注释					

文件开头必须满足下列文件注释格式，文件才可以被Doxygen有效识别。文件名称 必须要与文件名一致，区分大小写。

## 模板定义

```c
/*! 
* @file      --> 文件声明，即当前文件名
* @author    --> 作者
* @version   --> 版本信息
* @brief     --> 摘要，即当前文件说明
*/
```

## 实例

```c
/*! 
* @file Message_RPM.c 
* @author Tiger Z
* @version v1.0
* @brief Message about RPM from Car
*/
```

# 函数注释

## 模板定义

```c
/*!
* @author  --> 作者
* @date    --> 日期
* @param   --> 参数说明
* @return  --> 返回值说明
* @brief   --> 摘要，即当前文件说明
*/
```

## 实例

```c
/*！
 * @author Tiger Z
 * @date 2020-4-29 15:28:08
 * @brief Only Call by "Message_Manager"
 * @param RPM_Msg_Struct.EngSpeed_ValidFlag
 * @param RPM_Msg_Struct.EngSpeedRPM
 * @param RPM_Msg_Struct.Reserved
 * @return
 */
```

# 语句注释

## 模板定义

```c
//！...... comment .....
或
//!< ...... comment ......
```

## 实例 1

```c
typedef struct __message_rpm_struct
{
    //! Unit: rpm
    u16 EngSpeedRPM;               

    //! 0：Invalid ; 1:Valid
    u8  EngSpeed_ValidFlag;
    //! 预留位
    u8  Reserved;                   

} Message_RPM_Struct;
```

## 实例 2

```
typedef struct __message_rpm_struct
{
    u16 EngSpeedRPM;              //!< Unit: rpm

    u8  EngSpeed_ValidFlag;       //!< 0：Invalid ; 1: Valid
    u8  Reserved;                 //!< 预留位 

} Message_RPM_Struct;
```

