using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class EMDataStringStruct
{
	public int	ID	;
	public string	Text	;
	public int	Size	;

	public EMDataStringStruct ()
	{}


	public EMDataStringStruct (EMDataStringStruct orgData)
	{
		Copy(orgData) ;
	}

	public void Copy (EMDataStringStruct orgData)
	{
		ID = orgData.ID ;
		Text = orgData.Text ;
		Size = orgData.Size ;
	}

	public void SetData (int row, params string[] metaData)
	{
		int i = 0;
		if (!int.TryParse (metaData [i++], out ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return; }
		Text = metaData[i++] ;

		if (!int.TryParse (metaData [i++], out Size))	{
		Debug.LogError (string.Format("[Error] row : {0}, Size", row)); return; }
	}
}

public class EMDataString : MonoBehaviour
{
	public List<EMDataStringStruct> prefabData = new List<EMDataStringStruct>();
}