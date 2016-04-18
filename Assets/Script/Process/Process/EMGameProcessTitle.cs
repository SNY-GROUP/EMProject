using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessTitle : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessTitle] OnAwake");
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessTitle] OnEnter");
		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		return true;
	}

	public override void OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessTitle] OnExit");
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
		
	}
}
