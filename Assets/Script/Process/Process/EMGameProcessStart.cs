﻿using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessStart : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessStart] OnAwake");
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessStart] OnEnter");

		EMGameManager.Instance.ChangeProcess (Define.EMGameProcess.TITLE);

		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		return true;
	}

	public override bool OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessStart] OnExit");
		return true;
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
		
	}
}
