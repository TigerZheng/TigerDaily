# XML

## 简介

eXtensible Markup Language，指可扩展标记语言，设计宗旨是传输数据和存储数据，而不是显示数据。其焦点是数据的内容，标签没有被预定义。需要自行定义标签，被设计为具有自我描述性，是 W3C 的推荐标准，xml中严格区分大小写，表现形式就是给一个文档加一堆标签，说明每段文字是干什么的，有什么意义。这样做的目的是方便存储、传输、分享数据，人和机器都可以很方便的阅读。

## 基础知识



# HTML

## 简介

Hypertext Marked Language,中文叫做“超文本标记语言”，标记语言是一套标记标签 (markup tag)，使用标记标签来描述网页，HTML 文档包含了HTML 标签及文本内容，HTML文档也叫做 web 页面，HTML 被设计用来显示数据，其焦点是数据的外观，主要用来创建与系统平台无关的网页文档，“超文本”就是指页面内可以包含图片、链接、甚至音乐、程序等非文字元素，它是一种描述性的标记语言，这和一般文件的不同的是，一个html文件不仅包含文本内容，还包含“tag”,也就是标记。后缀名是.htm或html，在html中不区分大小写

## 基础知识

# XML与HTML对比

## 语法要求不同

> 在HTML中，有时不严格，如果上下文清楚地显示出段落或者列表键在何处结尾，那么你可以省略</p>或者</li>之类的结束标记。
> 在XML中，是严格的树状结构，绝对不能省略掉结束标记。

> 在XML中，拥有单个标记而没有匹配的结束标记的元素必须用一个/ 字符作为结尾。这样分析器就知道不用查找结束标记了。

> 在XML文档中，空白部分不会被解析器自动删除；但是html是过滤掉空格的

> 在HTML中，可以拥有不带值的属性名。在XML中，所有的属性都必须带有相应的值。

> 在XML中，属性值必须分装在引号中。在HTML中，引号是可用可不用的

## 标记不同

> HTML 的标签都是预定义的，你不可以自己随便增加

> XML标签是免费的、自定义的、可扩展的，你可以自己“发明”标签
>
> ————这也是“可扩展的”一个含义

## 作用不同

> html是用来显示数据的；xml是用来描述数据、存放数据的，所以可以作为持久化的介质！Html将数据和显示结合在一起，在页面中把这数据显示出来；xml则将数据和显示分开。 XML被设计用来描述数据，其焦点是数据的内容。HTML被设计用来显示数据，其焦点是数据的外观。

> 对于XML最好的形容可能是: XML是一种跨平台的，与软、硬件无关的，处理与传输信息的工具,XML未来将会无所不在。XML将成为最普遍的数据处理和数据传输的工具

# XHTML

## 简介

Extensible Hypertext Markup Language / 可扩展超文本标记语,XHTML 就是以 XML 的语法形式来写 HTML.

## 出现原因

HTML 是一种语法形式比较松散的标记语言，语法要求也不严格。比如大小可以混用，属性值随便你加不加引号，单引号还是双引号也随便你，标签也可以不闭合。HTML 标准的制定者 W3C 一看这样下去不行，所谓无规矩不成方圆，所以就把 XML 的语法形式往 HTML 上一套，出现了 XHTML，所以你也可以把 XHTML 理解为 HTML 的严格语法形式，除此之外，其它方面基本一样。

## 强制要求

> 必须包含一个文件头声明 <!DOCTYPE>

> 所有元素名必须小写

> 所有空元素必须关闭

> 所有属性名必须小写

> 所有属性值必须加引号

> 所有布尔值属性必须加上属性值