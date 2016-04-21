using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Define;

public class EMUIManager : MonoBehaviour
{
	public static EMUIManager root;

	public List<EMUIEntity> m_UIEntity;
	public Dictionary<int, EMUIEntity> m_UIEntityDic;

	// Use this for initialization
	void Awake () 
	{
		root = this;

		OnInit ();
	}

	void OnInit ()
	{
		if(m_UIEntityDic == null)
		{
			m_UIEntityDic = new Dictionary<int, EMUIEntity>();
		}

		foreach(EMUIEntity uiEntity in m_UIEntity)
		{
			if(uiEntity!= null)
			{
				uiEntity.OnInit();

				if(uiEntity.GetUIType() == (int)EMGameProcess.NULL)
					continue;

				if(m_UIEntityDic.ContainsKey(uiEntity.GetUIType()))
					continue;

				m_UIEntityDic.Add(uiEntity.GetUIType(), uiEntity);
			}
		}
	}

	public EMUIEntity GetUIEntity ( EMGameProcess p_UIType )
	{
		if(m_UIEntityDic.ContainsKey((int)p_UIType))
		{
			return m_UIEntityDic[(int)p_UIType];
		}
		return null;
	}

	public void SetActive ( EMGameProcess p_UIType, bool p_IsActive )
	{
		EMUIEntity uiEntity = GetUIEntity (p_UIType);
		if(uiEntity != null)
		{
			uiEntity.SetActive(p_IsActive);
		}
	}

	public void Show ( EMGameProcess p_UIType )
	{
		EMUIEntity uiEntity = GetUIEntity (p_UIType);
		if(uiEntity != null)
		{
			uiEntity.SetActive(true);
		}
	}

	public void OnReset ( EMGameProcess p_UIType )
	{
		EMUIEntity uiEntity = GetUIEntity (p_UIType);
		if(uiEntity != null)
		{
			uiEntity.OnReset();
		}
	}

	public void OnResetExcept ( EMGameProcess p_UIType )
	{
		foreach(EMUIEntity uiEntity in m_UIEntity)
		{
			if(uiEntity != null)
			{
				if(uiEntity.Equals(p_UIType) == false)
					uiEntity.OnReset();
			}
		}
	}

	public void OnResetAll ()
	{
		foreach(EMUIEntity uiEntity in m_UIEntity)
		{
			if(uiEntity != null)
			{
				uiEntity.OnReset();
			}
		}
	}
}
