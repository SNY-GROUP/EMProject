using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataLevelStruct
{
	public int	LevelType	;
	public int	LevelOpenId	;
	public int	StartGold	;
	public int	Hp	;
	public int	Patience	;
	public int	Math	;
	public int	GLanguage	;
	public int	Language	;
	public int	Common	;
	public int	Jop	;
	public int	Private	;
	public int	Rest	;
	public int	Luck	;

	public EMDataLevelStruct ()
	{}


	public EMDataLevelStruct (EMDataLevelStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataLevelStruct orgData)
	{
		LevelType = orgData.LevelType ;
		LevelOpenId = orgData.LevelOpenId ;
		StartGold = orgData.StartGold ;
		Hp = orgData.Hp ;
		Patience = orgData.Patience ;
		Math = orgData.Math ;
		GLanguage = orgData.GLanguage ;
		Language = orgData.Language ;
		Common = orgData.Common ;
		Jop = orgData.Jop ;
		Private = orgData.Private ;
		Rest = orgData.Rest ;
		Luck = orgData.Luck ;
	}
}

public class EMDataLevel : MonoBehaviour
{
	public List<EMDataLevelStruct> prefabData = new List<EMDataLevelStruct>();
}