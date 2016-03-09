using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataAdvertisementStruct
{
	public int	ID	;
	public int	OpenLevelType	;
	public int	NameID	;
	public int	InfoID	;
	public int	CategoryType	;
	public int	GainStress	;
	public int	GainPatience	;
	public int	GainMath	;
	public int	Gain_GLanguage	;
	public int	Gain_Language	;
	public int	GainCommon	;
	public int	GainJop	;
	public int	GainPrivate	;
	public int	GainRest	;
	public string	FileName	;
	public int	Buy	;
	public int	EventID	;
	public int	OpenType	;
	public int	OpenValue	;

	public EMDataAdvertisementStruct ()
	{}


	public EMDataAdvertisementStruct (EMDataAdvertisementStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataAdvertisementStruct orgData)
	{
		ID = orgData.ID ;
		OpenLevelType = orgData.OpenLevelType ;
		NameID = orgData.NameID ;
		InfoID = orgData.InfoID ;
		CategoryType = orgData.CategoryType ;
		GainStress = orgData.GainStress ;
		GainPatience = orgData.GainPatience ;
		GainMath = orgData.GainMath ;
		Gain_GLanguage = orgData.Gain_GLanguage ;
		Gain_Language = orgData.Gain_Language ;
		GainCommon = orgData.GainCommon ;
		GainJop = orgData.GainJop ;
		GainPrivate = orgData.GainPrivate ;
		GainRest = orgData.GainRest ;
		FileName = orgData.FileName ;
		Buy = orgData.Buy ;
		EventID = orgData.EventID ;
		OpenType = orgData.OpenType ;
		OpenValue = orgData.OpenValue ;
	}

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return; }
		if (!int.TryParse (metaData [i++], out OpenLevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenLevelType", row)); return; }
		if (!int.TryParse (metaData [i++], out NameID))	{
		Debug.LogError (string.Format("[Error] row : {0}, NameID", row)); return; }
		if (!int.TryParse (metaData [i++], out InfoID))	{
		Debug.LogError (string.Format("[Error] row : {0}, InfoID", row)); return; }
		if (!int.TryParse (metaData [i++], out CategoryType))	{
		Debug.LogError (string.Format("[Error] row : {0}, CategoryType", row)); return; }
		if (!int.TryParse (metaData [i++], out GainStress))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainStress", row)); return; }
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
		FileName = metaData[i++] ;

		if (!int.TryParse (metaData [i++], out Buy))	{
		Debug.LogError (string.Format("[Error] row : {0}, Buy", row)); return; }
		if (!int.TryParse (metaData [i++], out EventID))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventID", row)); return; }
		if (!int.TryParse (metaData [i++], out OpenType))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenType", row)); return; }
		if (!int.TryParse (metaData [i++], out OpenValue))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenValue", row)); return; }
	}
}

public class EMDataAdvertisement : MonoBehaviour
{
	public List<EMDataAdvertisementStruct> prefabData = new List<EMDataAdvertisementStruct>();
}