using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessLobbySchedulePlay : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessLobbySchedulePlay] OnAwake");
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessLobbySchedulePlay] OnEnter");
		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		return true;
	}

	public override bool OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessLobbySchedulePlay] OnExit");
		return true;
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
	}
}
