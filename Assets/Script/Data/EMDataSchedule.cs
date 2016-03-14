using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataScheduleStruct
{
	public int	ID	;
	public int	CategoryType	;
	public int	LevelType	;
	public int	Schedule_NameID	;
	public int	Schedule_InfoID	;
	public int	UseType	;
	public int	UseVaule	;
	public int	OpenType	;
	public int	OpenValue	;
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

	public EMDataScheduleStruct ()
	{}


	public EMDataScheduleStruct (EMDataScheduleStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataScheduleStruct orgData)
	{
		ID = orgData.ID ;
		CategoryType = orgData.CategoryType ;
		LevelType = orgData.LevelType ;
		Schedule_NameID = orgData.Schedule_NameID ;
		Schedule_InfoID = orgData.Schedule_InfoID ;
		UseType = orgData.UseType ;
		UseVaule = orgData.UseVaule ;
		OpenType = orgData.OpenType ;
		OpenValue = orgData.OpenValue ;
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
	}
}

public class EMDataSchedule : MonoBehaviour
{
	public List<EMDataScheduleStruct> prefabData = new List<EMDataScheduleStruct>();
}