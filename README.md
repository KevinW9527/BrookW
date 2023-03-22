# BrookW
BrookW是一个基于.NET 6开发的Brook客户端轻量级的GUI，采用WinForms封装Brook的exe客户端方式实现，使用随机未被占用的端口，支持系统代理，最小化通知图标。
[Brook协议](https://github.com/txthinking/brook) 是一种代理协议，相关内容可查看官网。
BrookW是一个使用C#语言编写的图形管理界面，它可以帮助Windows用户快速连接代理服务器，从而实现自由访问互联网的目的。

###特性
1. 支持Brook协议：BrookW是一个Brook协议的GUI客户端，支持Brook协议的大部分特性。
2. 支持系统代理：BrookW支持Windows系统代理设置，可以自动获取系统代理并进行代理转发。
3. 易于使用：BrookW采用WinForms方式实现，操作简单，易于使用。
4. 开源：BrookW采用MIT许可证开源，用户可以自由使用和修改源代码。
###快速开始
下载BrookW的源代码。
在Visual Studio 2022或更高版本中打开BrookW.sln文件。
编译并运行BrookW项目。
在BrookW客户端界面中，添加代理服务器的地址、端口和密码，然后点击启动按钮连接代理服务器。
在连接成功后，BrookW会自动开启Windows的系统代理，正常情况下用户可自由访问互联网。
###注意事项
在使用BrookW时，请确保代理服务器的地址、端口和密码正确。
在使用BrookW时，需要安装.NET6窗体运行时。
部分功能还未开发，持续更新…