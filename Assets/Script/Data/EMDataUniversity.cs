using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataUniversityStruct
{
	public int	Id	;
	public int	LevelType	;
	public int	GradeNameId	;
	public int	UniversityNameId	;
	public int	ConditionGold	;
	public int	ConditionHp	;
	public int	ConditionPatience	;
	public int	ConditionMath	;
	public int	Condition_GLanguage	;
	public int	Condition_Language	;
	public int	ConditionCommon	;
	public int	ConditionJop	;
	public int	ConditionPrivate	;
	public int	ConditionRest	;
	public int	EndingType	;

	public EMDataUniversityStruct ()
	{}


	public EMDataUniversityStruct (EMDataUniversityStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataUniversityStruct orgData)
	{
		Id = orgData.Id ;
		LevelType = orgData.LevelType ;
		GradeNameId = orgData.GradeNameId ;
		UniversityNameId = orgData.UniversityNameId ;
		ConditionGold = orgData.ConditionGold ;
		ConditionHp = orgData.ConditionHp ;
		ConditionPatience = orgData.ConditionPatience ;
		ConditionMath = orgData.ConditionMath ;
		Condition_GLanguage = orgData.Condition_GLanguage ;
		Condition_Language = orgData.Condition_Language ;
		ConditionCommon = orgData.ConditionCommon ;
		ConditionJop = orgData.ConditionJop ;
		ConditionPrivate = orgData.ConditionPrivate ;
		ConditionRest = orgData.ConditionRest ;
		EndingType = orgData.EndingType ;
	}
}

public class EMDataUniversity : MonoBehaviour
{
	public List<EMDataUniversityStruct> prefabData = new List<EMDataUniversityStruct>();
}