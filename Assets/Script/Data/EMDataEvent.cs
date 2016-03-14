using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataEventStruct
{
	public int	ID	;
	public int	EventType	;
	public int	LevelType	;
	public int	EvenTName	;
	public int	EventInfo	;
	public int	EventBuyInfo	;
	public int	SaleMin	;
	public int	SaleMax	;
	public int	GainGold	;
	public int	GainHp	;
	public int	GainPatience	;
	public int	GainMath	;
	public int	Gain_GLanguage	;
	public int	Gain_Language	;
	public int	GainCommon	;
	public int	GainJop	;
	public int	GainPrivate	;
	public int	GainRest	;
	public int	probabilityGroupID	;

	public EMDataEventStruct ()
	{}


	public EMDataEventStruct (EMDataEventStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataEventStruct orgData)
	{
		ID = orgData.ID ;
		EventType = orgData.EventType ;
		LevelType = orgData.LevelType ;
		EvenTName = orgData.EvenTName ;
		EventInfo = orgData.EventInfo ;
		EventBuyInfo = orgData.EventBuyInfo ;
		SaleMin = orgData.SaleMin ;
		SaleMax = orgData.SaleMax ;
		GainGold = orgData.GainGold ;
		GainHp = orgData.GainHp ;
		GainPatience = orgData.GainPatience ;
		GainMath = orgData.GainMath ;
		Gain_GLanguage = orgData.Gain_GLanguage ;
		Gain_Language = orgData.Gain_Language ;
		GainCommon = orgData.GainCommon ;
		GainJop = orgData.GainJop ;
		GainPrivate = orgData.GainPrivate ;
		GainRest = orgData.GainRest ;
		probabilityGroupID = orgData.probabilityGroupID ;
	}
}

public class EMDataEvent : MonoBehaviour
{
	public List<EMDataEventStruct> prefabData = new List<EMDataEventStruct>();
}