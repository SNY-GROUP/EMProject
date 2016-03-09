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

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return; }
		if (!int.TryParse (metaData [i++], out CategoryType))	{
		Debug.LogError (string.Format("[Error] row : {0}, CategoryType", row)); return; }
		if (!int.TryParse (metaData [i++], out LevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelType", row)); return; }
		if (!int.TryParse (metaData [i++], out Schedule_NameID))	{
		Debug.LogError (string.Format("[Error] row : {0}, Schedule_NameID", row)); return; }
		if (!int.TryParse (metaData [i++], out Schedule_InfoID))	{
		Debug.LogError (string.Format("[Error] row : {0}, Schedule_InfoID", row)); return; }
		if (!int.TryParse (metaData [i++], out UseType))	{
		Debug.LogError (string.Format("[Error] row : {0}, UseType", row)); return; }
		if (!int.TryParse (metaData [i++], out UseVaule))	{
		Debug.LogError (string.Format("[Error] row : {0}, UseVaule", row)); return; }
		if (!int.TryParse (metaData [i++], out OpenType))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenType", row)); return; }
		if (!int.TryParse (metaData [i++], out OpenValue))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenValue", row)); return; }
		if (!int.TryParse (metaData [i++], out GainGold))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainGold", row)); return; }
		if (!int.TryParse (metaData [i++], out GainHp))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainHp", row)); return; }
		if (!int.TryParse (metaData [i++], out GainPatience))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainPatience", row)); return; }
		if (!int.TryParse (metaData [i++], out GainMath))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainMath", row)); return; }
		if (!int.TryParse (metaData [i++], out Gain_GLanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, Gain_GLanguage", row)); return; }
		if (!int.TryParse (metaData [i++], out Gain_Language))	{
		Debug.LogError (string.Format("[Error] row : {0}, Gain_Language", row)); return; }
		if (!int.TryParse (metaData [i++], out GainCommon))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainCommon", row)); return; }
		if (!int.TryParse (metaData [i++], out GainJop))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainJop", row)); return; }
		if (!int.TryParse (metaData [i++], out GainPrivate))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainPrivate", row)); return; }
		if (!int.TryParse (metaData [i++], out GainRest))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainRest", row)); return; }
	}
}

public class EMDataSchedule : MonoBehaviour
{
	public List<EMDataScheduleStruct> prefabData = new List<EMDataScheduleStruct>();
}