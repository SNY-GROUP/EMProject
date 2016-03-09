using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataStateStruct
{
	public int	HP	;
	public int	Patience	;
	public int	Math	;
	public int	Glanguage	;
	public int	Language	;
	public int	Common	;
	public int	Jop	;
	public int	Private	;
	public int	Rest	;
	public long	Gold	;
	public int	Luck	;

	public EMDataStateStruct ()
	{}


	public EMDataStateStruct (EMDataStateStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataStateStruct orgData)
	{
		HP = orgData.HP ;
		Patience = orgData.Patience ;
		Math = orgData.Math ;
		Glanguage = orgData.Glanguage ;
		Language = orgData.Language ;
		Common = orgData.Common ;
		Jop = orgData.Jop ;
		Private = orgData.Private ;
		Rest = orgData.Rest ;
		Gold = orgData.Gold ;
		Luck = orgData.Luck ;
	}

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out HP))	{
		Debug.LogError (string.Format("[Error] row : {0}, HP", row)); return; }
		if (!int.TryParse (metaData [i++], out Patience))	{
		Debug.LogError (string.Format("[Error] row : {0}, Patience", row)); return; }
		if (!int.TryParse (metaData [i++], out Math))	{
		Debug.LogError (string.Format("[Error] row : {0}, Math", row)); return; }
		if (!int.TryParse (metaData [i++], out Glanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, Glanguage", row)); return; }
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
		if (!long.TryParse (metaData [i++], out Gold))	{
		Debug.LogError (string.Format("[Error] row : {0}, Gold", row)); return; }
		if (!int.TryParse (metaData [i++], out Luck))	{
		Debug.LogError (string.Format("[Error] row : {0}, Luck", row)); return; }
	}
}

public class EMDataState : MonoBehaviour
{
	public List<EMDataStateStruct> prefabData = new List<EMDataStateStruct>();
}