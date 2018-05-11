# day04 文件夹改动监测  （2018-5-10）

同步云盘，同步云盘首要的第一功能就是监测系统文件变化，然后才能触发增加、修改或删除操作。

于是乎我们今天的计划是：

![检测文件变化](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/%E6%A3%80%E6%B5%8B%E6%96%87%E4%BB%B6%E5%8F%98%E5%8C%96.PNG)


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

![实现文件修改监控](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/%E5%AE%9E%E7%8E%B0%E6%96%87%E4%BB%B6%E4%BF%AE%E6%94%B9%E7%9B%91%E6%8E%A7.PNG)

但是这时候我的心中升起了一份疑虑，如果拷贝大文件，到底是什么时候感知到呢？
如果我在这个时候去上传，会不会引发意外？

![测试触发时间](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/%E6%B5%8B%E8%AF%95%E8%A7%A6%E5%8F%91%E6%97%B6%E9%97%B4.PNG)


这个问题，我们明天再解答。
代码非常简陋，没有trycatch 也没有任何测试，我们不着急，千里之行始于足下。
