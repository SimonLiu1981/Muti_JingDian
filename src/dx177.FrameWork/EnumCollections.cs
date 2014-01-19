using System;

namespace dx177.FrameWork
{
    
	/// <summary>
	/// ϵͳSession����
	/// </summary>
	public enum SessionName
	{
		/// <summary>
		/// ��ǰ���Ա�ʶ
		/// </summary>
		LCID,

        /// <summary>
        /// ��ǰ��¼��
        /// </summary>
        Administrator,

        /// <summary>
        /// ��ǰע����
        /// </summary>
        ResUser,

        /// <summary>
        /// ��URL�����Administrator
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
    /// ��Ӣ�ı�ʶ
    /// </summary>
    public enum Licd
    {
        CN = 2052,
        EN = 1033
    }

 

	
	/// <summary>
	/// ϵͳ���õ�����Cache����
	/// </summary>
	public enum CacheName
	{
		/// <summary>
		/// ������Դ
		/// </summary>
		LanguageTag,

		/// <summary>
		/// Dict������Դ
		/// </summary>
		LanguageDictTag   ,

        /// <summary>
        /// ��Ʒ
        /// </summary>
        ProductTypeTree,

        /// <summary>
        /// ��������
        /// </summary>
        CarTypeTree,

        /// <summary>
        /// ��������
        /// </summary>
        NewsTypeTree,

        
	}
    /// <summary>
    /// ��Ʒ����
    /// </summary>
	public enum ProductTypeLevel
	{
        /// <summary>
        /// �󼶱�
        /// </summary>
		Top =0,
        /// <summary>
        /// ϸ����
        /// </summary>
        Sub =1
	}

    /// <summary>
    /// ��Ʒ����
    /// </summary>
    public enum NewsTypeLevel
    {
        /// <summary>
        /// �󼶱�
        /// </summary>
        Top = 0,
        /// <summary>
        /// ϸ����
        /// </summary>
        Sub = 1
    }

    
    /// <summary>
    /// �������ͼ���
    /// </summary>
    public enum CarTypeLevel
    {
        /// <summary>
        /// ������
        /// </summary>
        Top = 0,
        /// <summary>
        /// С����
        /// </summary>
        Sub = 1
    }


	/// <summary>
	/// �ϴ��ļ�������
	/// </summary>
	public enum FileType
	{
        /// <summary>
        /// ��ƷͼƬ
        /// </summary>
		Product =1,
       
	}

    /// <summary>
    /// �Ƶ궩��״̬
    /// </summary>
    public enum HotelOrderStatus
    { 
        /// <summary>
        /// �Ѿ�ȡ��
        /// </summary>
        Canceled = 1,
        /// <summary>
        /// �ȴ�ȷ��
        /// </summary>        
        WaitConfirm = 2,
        /// <summary>
        /// �Ѿ�ȷ��
        /// </summary>
        HasConfirm = 3,

        /// <summary>
        /// �Ѿ���ס
        /// </summary>
        HasCheckedIn = 4
    }


    /// <summary>
    /// СͼƬ��Ĭ�ϸ߶�
    /// </summary>
    public enum SmallSize
    {
        /// <summary>
        /// ��
        /// </summary>
        Height = 200,

        /// <summary>
        /// ��
        /// </summary>
        Width = 200
    }


    public enum BlockType
    {
        /// <summary>
        /// �������
        /// </summary>
        CertificateHonor = 1,
        /// <summary>
        /// ���ڶ�ԭ
        /// </summary>
        CompanyIntroduce =2,
        /// <summary>
        /// ��ϵ����
        /// </summary>
        ContactUs =3,

        /// <summary>
        /// ����֧��
        /// </summary>
        TechnicSupport = 4,

        /// <summary>
        /// ���⽻��
        /// </summary>
        ForeignCommunion = 5,
        /// <summary>
        /// ����
        /// </summary>
        CommonwealActive = 6,

        /// <summary>
        ///  �Ļ�����
        /// </summary>
        CultureLive = 7,

        /// <summary>
        /// ��ҵ�Ļ�
        /// </summary>
        CorporationCulture = 8,

        /// <summary>
        /// ��������
        /// </summary>
        QualityControl = 9 ,

        /// <summary>
        /// �о�����
        /// </summary>
        ResearchDevelopment =10
    }

    /// <summary>
    /// ������Ϣ������
    /// </summary>
    public enum LeaveMsgKeyType
    { 
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        Product = 1,
        /// <summary>
        /// ��������
        /// </summary>
        Order  =2,
        /// <summary>
        /// ϵͳ����
        /// </summary>
        System = 3,
    }


    /// <summary>
    /// ������Ϣ������
    /// </summary>
    public enum LeaveMsgHaveNew
    {
        /// <summary>
        /// û������Ϣ
        /// </summary>
        NoBodyNew=0,
        /// <summary>
        /// ����������Ϣ
        /// </summary>
        SellerHaveNew = 1,
        /// <summary>
        /// ���������Ϣ
        /// </summary>
        BuyerHaveNew = 2,
        /// <summary>
        /// ���߶�������Ϣ
        /// </summary>
        AllNew = 3,
    }


    /// <summary>
    /// ��Ʒ״̬
    /// </summary>
    public enum ProductStatus
    { 
        /// <summary>
        /// ������Ʒ
        /// </summary>
        New =0,
        /// <summary>
        /// �ϼܲ�Ʒ
        /// </summary>
        Up =1,
        /// <summary>
        /// �¼ܲ�Ʒ
        /// </summary>
        Down =2
    }

    /// <summary>
    /// ��Ԫ�ж�
    /// </summary>
    public enum DualisticJudge
    {
        /// <summary>
        /// ��
        /// </summary>
        No = 0,
        /// <summary>
        /// ��
        /// </summary>
        Yes = 1
    }


    /// <summary>
    /// �������ɾ�̬ҳ��
    /// </summary>
    public enum RunType
    {
        /// <summary>
        /// ��Ʒ
        /// </summary>
        Product = 1,
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        ProductType = 2,
        /// <summary>
        /// ����
        /// </summary>
        News = 3,
        /// <summary>
        /// ��������
        /// </summary>
        NewsType = 4,
        /// <summary>
        /// ����
        /// </summary>
        Issue = 5,
        /// <summary> 
        /// ����
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
    /// ��ͨ״̬
    /// </summary>
    public enum OpenStatus
    {
        /// <summary>
        /// ���뿪ͨ
        /// </summary>
        Application = 0,

        /// <summary>
        /// ��������ҳ��ֻ��ʾ�������ľƵ극��
        /// </summary>
        Approvaled = 1,

        /// <summary>
        /// �ܾ�
        /// </summary>
        Refused = 2,

    }

    /// <summary>
    /// ���� ״̬��1=�н��,0�����,2=�ѽ��
    /// </summary>
    public enum QuestionStatus
    {
        /// <summary>
        /// �����
        /// </summary>
        WaitSolved = 0,
        /// <summary>
        /// �н��
        /// </summary>
        HasReply = 1,
        /// <summary>
        /// �ѽ��
        /// </summary>
        HasSolved = 2,

    }
    /// <summary>
    /// ��������
    /// </summary>
    public enum QuestionType
    { 
        ע������=0,
        ��Ʊ=1,
        ��ͨ=2,
        ס��=3,
        ��ʳ=4,
        ����=100,
    }
    /// <summary>
    /// ������
    /// </summary>
    public enum DiggType
    { 
        ViewTimes=1,

        Ding = 2
    }

    /// <summary>
    /// ע���û�����
    /// </summary>
    public enum ResUserType
    {
        OrdinaryUser = 1,
        HireCarUser = 2,
        RestaurantUser = 3,
        HotelUser = 4,
        /// <summary>
        /// �ֻ��û�
        /// </summary>
        WapUser=5,
        SupperJingQqAdmin  = 6,
        SupperAdmin  = 7

    }


    public enum CommentType
    { 
        �Ƶ�=1,
        ����=2,
        ����=3,
        ����=4,
        ����=5,        
    }


    public enum HotelRefType
    { 
        Location =0,
        ZhuNa =1
    }
}
