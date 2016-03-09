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

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out Id))	{
		Debug.LogError (string.Format("[Error] row : {0}, Id", row)); return; }
		if (!int.TryParse (metaData [i++], out LevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelType", row)); return; }
		if (!int.TryParse (metaData [i++], out GradeNameId))	{
		Debug.LogError (string.Format("[Error] row : {0}, GradeNameId", row)); return; }
		if (!int.TryParse (metaData [i++], out UniversityNameId))	{
		Debug.LogError (string.Format("[Error] row : {0}, UniversityNameId", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionGold))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionGold", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionHp))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionHp", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionPatience))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionPatience", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionMath))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionMath", row)); return; }
		if (!int.TryParse (metaData [i++], out Condition_GLanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, Condition_GLanguage", row)); return; }
		if (!int.TryParse (metaData [i++], out Condition_Language))	{
		Debug.LogError (string.Format("[Error] row : {0}, Condition_Language", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionCommon))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionCommon", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionJop))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionJop", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionPrivate))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionPrivate", row)); return; }
		if (!int.TryParse (metaData [i++], out ConditionRest))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionRest", row)); return; }
		if (!int.TryParse (metaData [i++], out EndingType))	{
		Debug.LogError (string.Format("[Error] row : {0}, EndingType", row)); return; }
	}
}

public class EMDataUniversity : MonoBehaviour
{
	public List<EMDataUniversityStruct> prefabData = new List<EMDataUniversityStruct>();
}