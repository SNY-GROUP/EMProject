using UnityEngine;
using System.Collections;

public class UIButtonMessageChangeProcess : UIButtonMessage
{
	public Define.EMGameProcess m_Process = Define.EMGameProcess.NULL;

	void Awake ()
	{
		target = this.gameObject;
		functionName = "MessageReceiver";
		trigger = Trigger.OnClick;
		includeChildren = false;
	}

	void MessageReceiver ( GameObject p_Object )
	{
		EMGameManager.Instance.ChangeProcess (m_Process);
	}
}
