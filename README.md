# JackCloudDrive 导言
尝试用阿里云打造价格低廉的个人云盘。

每天我会花1~2小时来更新，希望大家支持。完结后我会归纳好转到博客里面，毕竟现在写的有可能某天觉得自己好笨，就重构（推倒重来）了。

[博客链接：https://www.cnblogs.com/Again](https://www.cnblogs.com/Again)

# 目录

[需求 （day01 2018-5-7）](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/chapter01_requirement.md)

[选型 （day02 2018-5-8）](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/chapter02_lectotype.md)

# hello world
今天依然来赴约

# 一点感想
第三天，咱们如约而至。

另外打脸的是，昨天设想采用 .net core 2.0 的想法，被无情打破，并没有对应的oss sdk，因此选型部分更改为.net framework。c# 应该可以说是和宇宙第一编辑器配合最好的语言了（逃，其他不会。

同时我们开发也要习惯，在运动中掌握变化（说人话，做的设计时常打脸），所以不能一下子做太远设计，尤其是经验不丰富的时候。保持好一个好的心态，平稳地推进项目，既要有稳定的部分，又要有创新之处，保持时刻向前进步，而不要故步自封。

![阿里云官网](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/aliyun_index.png)

# 布置基础措施 （day03 2018-5-9）
今天，咱们要给工作的开展布置一些基础设施，譬如OSS的申请，阿里云账号的开通等。
1. 当然是注册个阿里云账号啦 https://www.aliyun.com/ 然后领一波优惠券先 https://promotion.aliyun.com/ntms/act/ambassador/sharetouser.html?userCode=f9pa9mwb&utm_source=f9pa9mwb 
2. 然后享受下阿里云的春风，免费体验oss https://free.aliyun.com/ntms/free/personal.html?handle=true 选择一个地区资源包譬如华南
3. 喜欢的话可以买一个域名，现在有很多1块钱首年的域名，记得国内注册域名绑定空间等要备案哦。关于备案可以到云市场买9.9的建站，做个博客或者个人简历什么的，绑定下域名就可以通过审核了。
4. 在创建oss服务的过程中，会要求创建账户权限，其实就是AccessKey。
5. 当然我们不能直接使用这么高级的AccessKey一旦流露出去会很麻烦
6. 点击头像下面访问控制，给自己创建一个develop的子账号，同时生成AccessKey，咱们用于开发。设置最高权限，开发用这个AccessKey畅通无阻，开发结束，把Key注销掉开小权限Key使用，将来可升级STS，预留一部分设计。
7. 开发环境咱们安装 Visual Stdio 2017 Community 足够了，其他语言安装自己的开发环境，我们尽量用最少的代码组织我们的软件，传递的是思想即可。
8. OSS 产品文档 https://promotion.aliyun.com/ntms/act/ossdoclist.html
9. 咱们下载 [c# SDK](http://docs-aliyun.cn-hangzhou.oss.aliyun-inc.com/assets/attach/32085/cn_zh/1515493045734/aliyun_oss_dotnet_sdk_2_8_0.zip?spm=a2c4g.11186623.2.6.ihyO6q&file=aliyun_oss_dotnet_sdk_2_8_0.zip)，和 [oss util](http://docs-aliyun.cn-hangzhou.oss.aliyun-inc.com/assets/attach/50452/cn_zh/1524644040363/ossutil64.zip?spm=a2c4g.11186623.2.8.HWzgpJ&file=ossutil64.zip) 

搭环境是每个开发的基本功，有时搭环境需要很多耐心，所谓磨刀不误砍柴工，这一切都是有意义的。

# 广告
在本次策划行动中很多学习到的知识都是从阿里云最近开展的课程里面学到的，学习的时候还有老师指导，不懂就问，快活过神仙。妈妈再也不担心我的学习了。

当然学习是自己的事情，别人只能帮你不能替代你。

著名社会学家 本杰明·巴伯(Benjamin Barber) 说过：“我不会将世界分成弱和强，或者成功和失败……我会将世界分成好学者和不好学者。” 与君共勉。

所以，阿里云课程，了解一下？

云计算专业 | 大数据开发专业 | 大数据分析专业 | 云安全专业
------------ | ------------- | ------------- | -------------
[云计算专业 - 连接](http://click.aliyun.com/m/47628) | [大数据开发专业 - 连接](http://click.aliyun.com/m/47789) | [大数据分析专业 - 连接](http://click.aliyun.com/m/47709) | [云安全专业 - 连接](http://click.aliyun.com/m/47869)
![云计算专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/cloud_computing.png) | ![大数据开发专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/big_data_develop.png) | ![大数据分析专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/big_data_analyze.png) | ![云安全专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/cloud_security.png)

