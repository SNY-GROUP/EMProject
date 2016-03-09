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

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out LevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelType", row)); return; }
		if (!int.TryParse (metaData [i++], out LevelOpenId))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelOpenId", row)); return; }
		if (!int.TryParse (metaData [i++], out StartGold))	{
		Debug.LogError (string.Format("[Error] row : {0}, StartGold", row)); return; }
		if (!int.TryParse (metaData [i++], out Hp))	{
		Debug.LogError (string.Format("[Error] row : {0}, Hp", row)); return; }
		if (!int.TryParse (metaData [i++], out Patience))	{
		Debug.LogError (string.Format("[Error] row : {0}, Patience", row)); return; }
		if (!int.TryParse (metaData [i++], out Math))	{
		Debug.LogError (string.Format("[Error] row : {0}, Math", row)); return; }
		if (!int.TryParse (metaData [i++], out GLanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, GLanguage", row)); return; }
		if (!int.TryParse (metaData [i++], out Language))	{
		Debug.LogError (string.Format("[Error] row : {0}, Language", row)); return; }
		if (!int.TryParse (metaData [i++], out Common))	{
		Debug.LogError (string.Format("[Error] row : {0}, Common", row)); return; }
		if (!int.TryParse (metaData [i++], out Jop))	{
		Debug.LogError (string.Format("[Error] row : {0}, Jop", row)); return; }
		if (!int.TryParse (metaData [i++], out Private))	{
		Debug.LogError (string.Format("[Error] row : {0}, Private", row)); return; }
		if (!int.TryParse (metaData [i++], out Rest))	{
		Debug.LogError (string.Format("[Error] row : {0}, Rest", row)); return; }
		if (!int.TryParse (metaData [i++], out Luck))	{
		Debug.LogError (string.Format("[Error] row : {0}, Luck", row)); return; }
	}
}

public class EMDataLevel : MonoBehaviour
{
	public List<EMDataLevelStruct> prefabData = new List<EMDataLevelStruct>();
}