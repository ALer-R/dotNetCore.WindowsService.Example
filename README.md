"# dotNetCore.WindowsService.Example" 

dotNetCore2.1在Windows服务项目示例

发布后请以管理员权限运行Install.bat进行安装
也可以手动使用命令安装

安装
sc create MyService binPath= "所在目录\MyService.exe"
启用
sc Start  MyService
停用
sc stop MyService
删除
sc delete MyService
查看服务的信息
sc query  MyService
