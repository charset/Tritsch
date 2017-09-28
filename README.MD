OURCHAT 设计说明书
01. P2P通讯
    图片、语音等大对象的传输使用P2P。不考虑NAT穿透。
	此P2P是为点对点通讯，并不是广义上的peer 2 peer。
	考虑使用0MQ通讯。

	发送者:
		var client = new RequestSocket($"tcp://{Util.Find(targetGuid).LastLogonIP}:12553");
		client.Connect();
		client.Send(message);
		var reply = client.Receive();

02. 服务器通讯
    使用0MQ进行通讯

03. 通讯原语
    1)  消息定义
	Message: Source, Target, Proxy, Data
	Source: Sendor GUID, Is Group
	Target: Target GUID, Is Group
	Data: Send Time, Time Expired, Receipt Required, Message ID, Message Type, Body
	Body: Length, Content

	2)  Membership定义
	Member: Member Info
	    A dictionary contains <string, string>.
		Member ID, Member Name, Department */*/*/* -> Department Info( Level 0|1|2|3 ), Levels
		Last Login IP, Successfully Login Count, Portrait, Nick Name
		Member Credential: Password

	3)  Group定义
	Group: List<Member>, List(0) is the maintainer of the group. Group must be at least 2 members.

	4)  Chat History
	Dictionary<MessageID, Content> Save to [Member(GUID)].xml. Images, voices may encoded to base64.

	5)  MessageType详解
	Message.Content中包含的值会根据MessageType具体解析.
	MT_GROUP_FLAG 代表这个消息是群发的, 注意有些消息只允许P2P发送.
	为了注记会将这些消息标记为MT_*_GROUP_开头.

	MT_CODE_FLAG 所有在MT_CODE_FLAG内的值都代表一种特定的语言, 应当以语言高亮器显示.
	客户端可以将本消息显示为一个语言图标, 并提供一个手型鼠标提示, 点开后使用窗体展示.
	    [因为Java穷途末路了, 所以给他一个0x0FFF的值.]
	Content使用UTF-8编码的字符串, 不支持消息转义.

	MT_MEMBER_FLAG 传递有关用户相关消息.
	`MT_MEMBER_INVITE` Content = <MemberInfo>
	如果发起者是一个群, 则Content = Group, List<MemberInfo>

	`MT_MEMBER_INVITE_REPLY` Content = Reference Message ID

	`MT_MEMBER_REMOVE`

	`MT_MEMBER_REMOVE_REPLY`

	`MT_MEMBER_GROUP_MODIFY` Content = Dictionary<Key, Value>

	`MT_MEMBER_INFO` Content = GUID

	`MT_MEMBER_INFO_REPLY` Content = <MemberInfo>

04. 显示控件
    使用一个FlowLayoutPanel来承载一个ChatUI, 自定义的控件.
	ChatUI由一个TableLayoutPanel组成, 由PictureBox, RichTextBox, 占位空间 组成.
	用来模拟左边对齐和右边对齐这种微信样式.
	如左边对齐就是 PictureBox[固定宽度], RichTextBox[75%宽度], 空间[25%宽度],
	右边对齐就是 空间, RichTextBox, PictureBox. 宽度同上.
