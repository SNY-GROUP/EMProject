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
}

public class EMDataString : MonoBehaviour
{
	public List<EMDataStringStruct> prefabData = new List<EMDataStringStruct>();
}