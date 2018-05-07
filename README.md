# JackCloudDrive
尝试用阿里云打造价格低廉的个人云盘

# 需求
2018-5-8 00:08:10
今天第一天，咱们来规划一下想要的需求

![需求](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/require.png)

1. 大
 大，是共同的需求，很小，装在U盘就可以了。
 网盘文件就像电脑的文件，肯定会随着你的使用变得越来越多，我们需要足够大，装得下我们想装的东西。
 可能一开始500M，后来变成50G，以后变成1T，2T，甚至存放私家珍藏，要变得大。
2. 同步
 以前各家平台都有退出同步盘，感觉非常爽。
 可能由于时不时就同步，对于服务器来讲压力太大，后来各个平台都转为网盘管家，你想要上传自己指定上传，下载自己指定下载。
 但这耗时耗力，如果只是这个功能的话，我们可以现在停手了，选型使用阿里云oss，用自带的工具就可以实现。
3. 在线编排
 文件多了，调整目录结构的时候，即使是本地也会复制拷贝显得很慢，云上不一样，大概是由于存储方式问题，还有运算能力问题，显得更轻松吧。
4. 快速查找文件
 我们存放文件不仅仅是为了放，为放而放还不如刻光盘呢，买两只蓝光回来，把你从上小学拍到大学毕业全程录像都够了。我们放了文件是要索取的，需要有种方式让我们快速根据记忆从大批数据中提取信息。
文件如果放在硬盘，文件经过索引查找是非常快的，我们可以考虑相对弱一点的搜索方式，毕竟这些文件属于沉淀文件。
5. 在线预览，编辑，获取
这个问题在于快速查找定位到文件，我们到底要不要下载，需要先看过再考虑，如何知道内容呢？网速可以，那么就下下来，如果环境支持那么就在线预览，譬如文本等，直接浏览也是不错选择。最难的是编辑，譬如笔记，更改了账号密码要记录一下。