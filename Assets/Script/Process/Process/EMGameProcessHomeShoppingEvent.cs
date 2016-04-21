using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessHomeShoppingEvent : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessHomeShoppingEvent] OnAwake");
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessHomeShoppingEvent] OnEnter");
		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		return true;
	}

	public override bool OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessHomeShoppingEvent] OnExit");
		return true;
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
	}
}
