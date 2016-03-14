using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataStateStruct
{
	public int	HP	;
	public int	Patience	;
	public int	Math	;
	public int	Glanguage	;
	public int	Language	;
	public int	Common	;
	public int	Jop	;
	public int	Private	;
	public int	Rest	;
	public long	Gold	;
	public int	Luck	;

	public EMDataStateStruct ()
	{}


	public EMDataStateStruct (EMDataStateStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataStateStruct orgData)
	{
		HP = orgData.HP ;
		Patience = orgData.Patience ;
		Math = orgData.Math ;
		Glanguage = orgData.Glanguage ;
		Language = orgData.Language ;
		Common = orgData.Common ;
		Jop = orgData.Jop ;
		Private = orgData.Private ;
		Rest = orgData.Rest ;
		Gold = orgData.Gold ;
		Luck = orgData.Luck ;
	}
}

public class EMDataState : MonoBehaviour
{
	public List<EMDataStateStruct> prefabData = new List<EMDataStateStruct>();
}