using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessLobbyScheduleInfo : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessLobbyScheduleInfo] OnAwake");
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessLobbyScheduleInfo] OnEnter");
		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		return true;
	}

	public override bool OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessLobbyScheduleInfo] OnExit");
		return true;
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
	}
}
