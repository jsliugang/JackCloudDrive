# JackCloudDrive 导言
尝试用阿里云打造价格低廉的个人云盘。

每天我会花1~2小时来更新，希望大家支持。完结后我会归纳好转到博客里面，毕竟现在写的有可能某天觉得自己好笨，就重构（推倒重来）了。

[博客链接：https://www.cnblogs.com/Again](https://www.cnblogs.com/Again)

# 目录

[day01 需求 （2018-5-7）](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/chapter01_requirement.md)

[day02 选型 （2018-5-8）](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/chapter02_lectotype.md)

[day03 布置基础措施 （2018-5-9）](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/chapter03_environment.md)

# 感想

[一点感想](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/impressions/一点感想.md)

# hello world
今天依然来赴约

# day04 文件夹改动监测  （2018-5-10）

同步云盘，同步云盘首要的第一功能就是监测系统文件变化，然后才能触发增加、修改或删除操作。

于是乎我们今天的计划是：
![检测文件变化](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/检测文件变化.png)

## 实现文件更改监控
``` 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\workspace\2018-05\JackCloudDrive\test\Test_FileWatcher\file";

            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = path;
            fsw.IncludeSubdirectories = true;   //设置监控C盘目录下的所有子目录
            fsw.Filter = "*.*";   //设置监控文件的类型
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;   //设置文件的文件名、目录名及文件的大小改动会触发Changed事件
            fsw.Created += new FileSystemEventHandler(fileSystemWatcher_EventHandle);  //绑定事件触发后处理数据的方法。
            fsw.Deleted += new FileSystemEventHandler(fileSystemWatcher_EventHandle);
            fsw.Changed += new FileSystemEventHandler(fileSystemWatcher_EventHandle);
            fsw.Renamed += new RenamedEventHandler(fileSystemWatcher_Renamed);  //重命名事件与增删改传递的参数不一样。

            fsw.EnableRaisingEvents = true;  //启动监控

            Console.ReadLine();
        }

        private static void fileSystemWatcher_EventHandle(object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法
        {
            Console.WriteLine($"file {e.Name} : {e.ChangeType.ToString().ToLower()} at {e.FullPath}");
        }

        private static void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)   //文件重命名时被调用的处理方法
        {
            Console.WriteLine($"file {e.OldName} : rename to {e.Name} at {e.FullPath}");
        }
    }
}
```

## 实现结果
轻松实现这个功能，耗费了不多时间。

![实现文件修改监控](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/实现文件修改监控.png)

但是这时候我的心中升起了一份疑虑，如果拷贝大文件，到底是什么时候感知到呢？
如果我在这个时候去上传，会不会引发意外？

![测试触发时间](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/测试触发时间.png)

这个问题，我们明天再解答。
代码非常简陋，没有trycatch 也没有任何测试，我们不着急，千里之行始于足下。

今晚就到这里吧。






# 广告
在本次策划行动中很多学习到的知识都是从阿里云最近开展的课程里面学到的，学习的时候还有老师指导，不懂就问，快活过神仙。妈妈再也不担心我的学习了。

当然学习是自己的事情，别人只能帮你不能替代你。

著名社会学家 本杰明·巴伯(Benjamin Barber) 说过：“我不会将世界分成弱和强，或者成功和失败……我会将世界分成好学者和不好学者。” 与君共勉。

所以，阿里云课程，了解一下？

云计算专业 | 大数据开发专业 | 大数据分析专业 | 云安全专业
------------ | ------------- | ------------- | -------------
[云计算专业 - 连接](http://click.aliyun.com/m/47628) | [大数据开发专业 - 连接](http://click.aliyun.com/m/47789) | [大数据分析专业 - 连接](http://click.aliyun.com/m/47709) | [云安全专业 - 连接](http://click.aliyun.com/m/47869)
![云计算专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/cloud_computing.png) | ![大数据开发专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/big_data_develop.png) | ![大数据分析专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/big_data_analyze.png) | ![云安全专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/cloud_security.png)

