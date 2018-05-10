
![阿里云官网](https://github.com/jzaicn/JackCloudDrive/raw/master/doc/img/aliyun_index.png)

# day03 布置基础措施 （2018-5-9）
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