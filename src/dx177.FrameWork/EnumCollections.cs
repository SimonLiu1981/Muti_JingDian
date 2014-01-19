using System;

namespace dx177.FrameWork
{
    
	/// <summary>
	/// 系统Session名称
	/// </summary>
	public enum SessionName
	{
		/// <summary>
		/// 当前语言标识
		/// </summary>
		LCID,

        /// <summary>
        /// 当前登录人
        /// </summary>
        Administrator,

        /// <summary>
        /// 当前注册人
        /// </summary>
        ResUser,

        /// <summary>
        /// 用URL来获得Administrator
        /// </summary>
        GetAdministratorByUrl,

        /// <summary>
        /// 
        /// </summary>
        MyShopinfo,

        Adminuser ,

        CurrentMgtJingQuCode,

        JingQu,
	}

    public enum CookieName
    {
        CurrentAdminUserName,
        CurrentAdminJingQuCode,        
    }

    /// <summary>
    /// 中英文标识
    /// </summary>
    public enum Licd
    {
        CN = 2052,
        EN = 1033
    }

 

	
	/// <summary>
	/// 系统中用到所有Cache名称
	/// </summary>
	public enum CacheName
	{
		/// <summary>
		/// 语言资源
		/// </summary>
		LanguageTag,

		/// <summary>
		/// Dict语言资源
		/// </summary>
		LanguageDictTag   ,

        /// <summary>
        /// 产品
        /// </summary>
        ProductTypeTree,

        /// <summary>
        /// 车辆类型
        /// </summary>
        CarTypeTree,

        /// <summary>
        /// 文章类型
        /// </summary>
        NewsTypeTree,

        
	}
    /// <summary>
    /// 产品级别
    /// </summary>
	public enum ProductTypeLevel
	{
        /// <summary>
        /// 大级别
        /// </summary>
		Top =0,
        /// <summary>
        /// 细级别
        /// </summary>
        Sub =1
	}

    /// <summary>
    /// 产品级别
    /// </summary>
    public enum NewsTypeLevel
    {
        /// <summary>
        /// 大级别
        /// </summary>
        Top = 0,
        /// <summary>
        /// 细级别
        /// </summary>
        Sub = 1
    }

    
    /// <summary>
    /// 车辆类型级别
    /// </summary>
    public enum CarTypeLevel
    {
        /// <summary>
        /// 大类型
        /// </summary>
        Top = 0,
        /// <summary>
        /// 小类型
        /// </summary>
        Sub = 1
    }


	/// <summary>
	/// 上传文件的类型
	/// </summary>
	public enum FileType
	{
        /// <summary>
        /// 产品图片
        /// </summary>
		Product =1,
       
	}

    /// <summary>
    /// 酒店订单状态
    /// </summary>
    public enum HotelOrderStatus
    { 
        /// <summary>
        /// 已经取消
        /// </summary>
        Canceled = 1,
        /// <summary>
        /// 等待确认
        /// </summary>        
        WaitConfirm = 2,
        /// <summary>
        /// 已经确认
        /// </summary>
        HasConfirm = 3,

        /// <summary>
        /// 已经入住
        /// </summary>
        HasCheckedIn = 4
    }


    /// <summary>
    /// 小图片的默认高度
    /// </summary>
    public enum SmallSize
    {
        /// <summary>
        /// 高
        /// </summary>
        Height = 200,

        /// <summary>
        /// 宽
        /// </summary>
        Width = 200
    }


    public enum BlockType
    {
        /// <summary>
        /// 光辉历程
        /// </summary>
        CertificateHonor = 1,
        /// <summary>
        /// 关于东原
        /// </summary>
        CompanyIntroduce =2,
        /// <summary>
        /// 联系方试
        /// </summary>
        ContactUs =3,

        /// <summary>
        /// 技术支持
        /// </summary>
        TechnicSupport = 4,

        /// <summary>
        /// 对外交流
        /// </summary>
        ForeignCommunion = 5,
        /// <summary>
        /// 公益活动
        /// </summary>
        CommonwealActive = 6,

        /// <summary>
        ///  文化生活
        /// </summary>
        CultureLive = 7,

        /// <summary>
        /// 企业文化
        /// </summary>
        CorporationCulture = 8,

        /// <summary>
        /// 质量控制
        /// </summary>
        QualityControl = 9 ,

        /// <summary>
        /// 研究开发
        /// </summary>
        ResearchDevelopment =10
    }

    /// <summary>
    /// 留言信息的类型
    /// </summary>
    public enum LeaveMsgKeyType
    { 
        /// <summary>
        /// 产品留言
        /// </summary>
        Product = 1,
        /// <summary>
        /// 订单留言
        /// </summary>
        Order  =2,
        /// <summary>
        /// 系统留言
        /// </summary>
        System = 3,
    }


    /// <summary>
    /// 留言信息的类型
    /// </summary>
    public enum LeaveMsgHaveNew
    {
        /// <summary>
        /// 没有新消息
        /// </summary>
        NoBodyNew=0,
        /// <summary>
        /// 卖家有新消息
        /// </summary>
        SellerHaveNew = 1,
        /// <summary>
        /// 买家有新消息
        /// </summary>
        BuyerHaveNew = 2,
        /// <summary>
        /// 两者都有新消息
        /// </summary>
        AllNew = 3,
    }


    /// <summary>
    /// 产品状态
    /// </summary>
    public enum ProductStatus
    { 
        /// <summary>
        /// 新增产品
        /// </summary>
        New =0,
        /// <summary>
        /// 上架产品
        /// </summary>
        Up =1,
        /// <summary>
        /// 下架产品
        /// </summary>
        Down =2
    }

    /// <summary>
    /// 二元判断
    /// </summary>
    public enum DualisticJudge
    {
        /// <summary>
        /// 否
        /// </summary>
        No = 0,
        /// <summary>
        /// 是
        /// </summary>
        Yes = 1
    }


    /// <summary>
    /// 马上生成静态页面
    /// </summary>
    public enum RunType
    {
        /// <summary>
        /// 产品
        /// </summary>
        Product = 1,
        /// <summary>
        /// 产品类型
        /// </summary>
        ProductType = 2,
        /// <summary>
        /// 新闻
        /// </summary>
        News = 3,
        /// <summary>
        /// 新闻类型
        /// </summary>
        NewsType = 4,
        /// <summary>
        /// 文章
        /// </summary>
        Issue = 5,
        /// <summary> 
        /// 其他
        /// </summary>
        Others = 6
    }

    public enum ESearchType
    {
        PSEARCH = 1,
        NSEARCH = 2

    }

    public enum ParentType
    {
        ProductType = 1,

        NewsType = 2

    }

    /// <summary>
    /// 开通状态
    /// </summary>
    public enum OpenStatus
    {
        /// <summary>
        /// 申请开通
        /// </summary>
        Application = 0,

        /// <summary>
        /// 已审批，页面只显示审批过的酒店饭店
        /// </summary>
        Approvaled = 1,

        /// <summary>
        /// 拒绝
        /// </summary>
        Refused = 2,

    }

    /// <summary>
    /// 问题 状态：1=有解答,0待解决,2=已解决
    /// </summary>
    public enum QuestionStatus
    {
        /// <summary>
        /// 待解决
        /// </summary>
        WaitSolved = 0,
        /// <summary>
        /// 有解答
        /// </summary>
        HasReply = 1,
        /// <summary>
        /// 已解决
        /// </summary>
        HasSolved = 2,

    }
    /// <summary>
    /// 问题类型
    /// </summary>
    public enum QuestionType
    { 
        注意事项=0,
        门票=1,
        交通=2,
        住宿=3,
        饮食=4,
        其它=100,
    }
    /// <summary>
    /// 定类型
    /// </summary>
    public enum DiggType
    { 
        ViewTimes=1,

        Ding = 2
    }

    /// <summary>
    /// 注册用户类型
    /// </summary>
    public enum ResUserType
    {
        OrdinaryUser = 1,
        HireCarUser = 2,
        RestaurantUser = 3,
        HotelUser = 4,
        /// <summary>
        /// 手机用户
        /// </summary>
        WapUser=5,
        SupperJingQqAdmin  = 6,
        SupperAdmin  = 7

    }


    public enum CommentType
    { 
        酒店=1,
        饭店=2,
        新闻=3,
        景点=4,
        景区=5,        
    }


    public enum HotelRefType
    { 
        Location =0,
        ZhuNa =1
    }
}
