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
}

public class EMDataAdvertisement : MonoBehaviour
{
	public List<EMDataAdvertisementStruct> prefabData = new List<EMDataAdvertisementStruct>();
}