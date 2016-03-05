using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EMDataAdCondition
{
	public int	ID	;
	public int	AppearMin	;
	public int	AppearMax	;
	public int	CoolTimeMin	;
	public int	CoolTimeMax	;
	public int	CorrectCntMin	;
	public int	CorrectCntMax	;

	public EMDataAdCondition (EMDataAdCondition orgData)
	{
		ID = orgData.ID ;
		AppearMin = orgData.AppearMin ;
		AppearMax = orgData.AppearMax ;
		CoolTimeMin = orgData.CoolTimeMin ;
		CoolTimeMax = orgData.CoolTimeMax ;
		CorrectCntMin = orgData.CorrectCntMin ;
		CorrectCntMax = orgData.CorrectCntMax ;
	}
}