using UnityEngine;
using System.Collections;
using Define;

public class EMUIEntity : MonoBehaviour 
{
	public bool m_ActiveOnInit = false;
	public EMGameProcess m_UIType = EMGameProcess.NULL;
	public EMGameProcess[] m_IgnoredReset;

	public int GetUIType ()
	{
		return (int)m_UIType;
	}

	public void OnInit ()
	{
		SetActive (m_ActiveOnInit);
	}

	public void SetActive ( bool p_IsActive )
	{
		gameObject.SetActive (p_IsActive);
	}

	public void Show ()
	{
		SetActive (true);
	}

	private bool CheckIgnoredReset ()
	{
		foreach( EMGameProcess process in m_IgnoredReset )
		{
			if(EMGameManager.Instance.GetCurProcess() == process)
				return true;
		}
		return false;
	}

	public virtual void OnReset ()
	{
		if(CheckIgnoredReset() == false)
		{
			SetActive (false);
		}
	}
}
