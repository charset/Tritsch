OURCHAT ���˵����
01. P2PͨѶ
    ͼƬ�������ȴ����Ĵ���ʹ��P2P��������NAT��͸��
	��P2P��Ϊ��Ե�ͨѶ�������ǹ����ϵ�peer 2 peer��
	����ʹ��0MQͨѶ��

	������:
		var client = new RequestSocket($"tcp://{Util.Find(targetGuid).LastLogonIP}:12553");
		client.Connect();
		client.Send(message);
		var reply = client.Receive();

02. ������ͨѶ
    ʹ��0MQ����ͨѶ

03. ͨѶԭ��
    1)  ��Ϣ����
	Message: Source, Target, Proxy, Data
	Source: Sendor GUID, Is Group
	Target: Target GUID, Is Group
	Data: Send Time, Time Expired, Receipt Required, Message ID, Message Type, Body
	Body: Length, Content

	2)  Membership����
	Member: Member Info
	    A dictionary contains <string, string>.
		Member ID, Member Name, Department */*/*/* -> Department Info( Level 0|1|2|3 ), Levels
		Last Login IP, Successfully Login Count, Portrait, Nick Name
		Member Credential: Password

	3)  Group����
	Group: List<Member>, List(0) is the maintainer of the group. Group must be at least 2 members.

	4)  Chat History
	Dictionary<MessageID, Content> Save to [Member(GUID)].xml. Images, voices may encoded to base64.

	5)  MessageType���
	Message.Content�а�����ֵ�����MessageType�������.
	MT_GROUP_FLAG ���������Ϣ��Ⱥ����, ע����Щ��Ϣֻ����P2P����.
	Ϊ��ע�ǻὫ��Щ��Ϣ���ΪMT_*_GROUP_��ͷ.

	MT_CODE_FLAG ������MT_CODE_FLAG�ڵ�ֵ������һ���ض�������, Ӧ�������Ը�������ʾ.
	�ͻ��˿��Խ�����Ϣ��ʾΪһ������ͼ��, ���ṩһ�����������ʾ, �㿪��ʹ�ô���չʾ.
	    [��ΪJava��;ĩ·��, ���Ը���һ��0x0FFF��ֵ.]
	Contentʹ��UTF-8������ַ���, ��֧����Ϣת��.

	MT_MEMBER_FLAG �����й��û������Ϣ.
	`MT_MEMBER_INVITE` Content = <MemberInfo>
	�����������һ��Ⱥ, ��Content = Group, List<MemberInfo>

	`MT_MEMBER_INVITE_REPLY` Content = Reference Message ID

	`MT_MEMBER_REMOVE`

	`MT_MEMBER_REMOVE_REPLY`

	`MT_MEMBER_GROUP_MODIFY` Content = Dictionary<Key, Value>

	`MT_MEMBER_INFO` Content = GUID

	`MT_MEMBER_INFO_REPLY` Content = <MemberInfo>

04. ��ʾ�ؼ�
    ʹ��һ��FlowLayoutPanel������һ��ChatUI, �Զ���Ŀؼ�.
	ChatUI��һ��TableLayoutPanel���, ��PictureBox, RichTextBox, ռλ�ռ� ���.
	����ģ����߶�����ұ߶�������΢����ʽ.
	����߶������ PictureBox[�̶�����], RichTextBox[75%����], �ռ�[25%����],
	�ұ߶������ �ռ�, RichTextBox, PictureBox. ����ͬ��.