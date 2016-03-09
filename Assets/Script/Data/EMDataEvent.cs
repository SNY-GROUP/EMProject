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

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return; }
		if (!int.TryParse (metaData [i++], out EventType))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventType", row)); return; }
		if (!int.TryParse (metaData [i++], out LevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelType", row)); return; }
		if (!int.TryParse (metaData [i++], out EvenTName))	{
		Debug.LogError (string.Format("[Error] row : {0}, EvenTName", row)); return; }
		if (!int.TryParse (metaData [i++], out EventInfo))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventInfo", row)); return; }
		if (!int.TryParse (metaData [i++], out EventBuyInfo))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventBuyInfo", row)); return; }
		if (!int.TryParse (metaData [i++], out SaleMin))	{
		Debug.LogError (string.Format("[Error] row : {0}, SaleMin", row)); return; }
		if (!int.TryParse (metaData [i++], out SaleMax))	{
		Debug.LogError (string.Format("[Error] row : {0}, SaleMax", row)); return; }
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
		if (!int.TryParse (metaData [i++], out probabilityGroupID))	{
		Debug.LogError (string.Format("[Error] row : {0}, probabilityGroupID", row)); return; }
	}
}

public class EMDataEvent : MonoBehaviour
{
	public List<EMDataEventStruct> prefabData = new List<EMDataEventStruct>();
}