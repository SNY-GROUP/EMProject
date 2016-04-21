using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessHomeShopping : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessHomeShopping] OnAwake");
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessHomeShopping] OnEnter");
		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		return true;
	}

	public override bool OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessHomeShopping] OnExit");
		return true;
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
	}
}
