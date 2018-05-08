# JackCloudDrive
尝试用阿里云打造价格低廉的个人云盘

# 目录
[需求 （day01 2018-5-7）](https://github.com/jzaicn/JackCloudDrive/blob/master/doc/chapter01_requirement.md)

# 选型 （day02 2018-5-8）
第二天，咱们今天来做选型和规划。
因为咱们的项目比较小，又是自己的项目，所以可以轻便点，敏捷点（别管那么多撸起袖子就是干~）

![撸起袖子加油干](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/fun_img/撸起袖子加油干.jpg)

## 选型几点要求
1. 便宜，这是我们一开始的要求
2. 阿里云产品。至于为何。
  - 首先，同一个平台的产品有较高的相容性，内部系统很多互通的部分；
  - 第二，抱大腿嘛，不能三心二意啦，抱稳了就要起飞了，不要说我还没上车呢；
  - 第三，知识，我们讲究的是一通百通，很多平台有相互借鉴的地方。譬如AWS的EC2主机（ Elastic Compute Cloud 弹性计算云，2 for C²），阿里云叫ECS（Elastic Compute Service 弹性计算服务），提供的基础设计原型都是接近的，选择同一个平台术语无需大量转换，当你更换平台的时候也非常容易上手。
  - 第四，主要是我就会这个，其他不会，\(￣︶￣)/ 

## 选型
1. 存储选用：OSS （Object Storage Service 对象存储）
  - 首先。廉价，OSS的下载流量按量计费大概是20M/0.01元，上传不收钱，只要有足够硬盘（存储空间，又叫资源包，我们买9块钱一年40GB的优惠套餐）。
  - 第二。对于长久存储，不下载不收钱。当我们确定长久都不使用，还可以使用OSS的低频存储或者归档存储，价格低廉，满足企业级二十年以上存储的需要。用户甚至企业，都无需考虑磁盘呀，存储介质呀，定时检测数据丢失情况这些问题（只需要掏腰包，阿里云帮你包办这一切）。我就喜欢这么简单粗暴的方案。
  - 第三。存储作为云计算，硬件虚拟化一个非常重要的环节，是阿里云以及各大云计算平台的基础，经受得住这么多业务的考验，稳定而且高效。文档里说高达99.999999999%的数据可靠性，一共有一二三。。个九，总之很稳定啦。如果我们考虑多备结构的话，相当于数据的可靠性达到了20个9的稳定级。反正我是不打算考虑双备了（懒）。


# 广告
在本次策划行动中很多学习到的知识都是从阿里云最近开展的课程里面学到的，学习的时候还有老师指导，不懂就问，快活过神仙。妈妈再也不担心我的学习了。

当然学习是自己的事情，别人只能帮你不能替代你。

著名社会学家说过：“我不会将世界分成弱和强，或者成功和失败……我会将世界分成好学者和不好学者。” 与君共勉。

所以，阿里云课程，了解一下？

### 云计算专业
http://click.aliyun.com/m/47628 

![云计算专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/cloud_computing.png)

### 大数据开发专业

http://click.aliyun.com/m/47789 

![大数据开发专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/big_data_develop.png)

### 大数据分析专业

http://click.aliyun.com/m/47709 

![大数据分析专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/big_data_analyze.png)

### 云安全专业

http://click.aliyun.com/m/47869

![云安全专业](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/ad_img/cloud_security.png)
