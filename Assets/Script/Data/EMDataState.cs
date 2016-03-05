using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EMDataState
{
	public int	HP	;
	public int	Stress	;
	public int	Patience	;
	public int	Math	;
	public int	Glanguage	;
	public int	Language	;
	public int	Common	;
	public int	ExpJop	;
	public int	ExpStudy	;
	public int	ExpRest	;

	public EMDataState (EMDataState orgData)
	{
		HP = orgData.HP ;
		Stress = orgData.Stress ;
		Patience = orgData.Patience ;
		Math = orgData.Math ;
		Glanguage = orgData.Glanguage ;
		Language = orgData.Language ;
		Common = orgData.Common ;
		ExpJop = orgData.ExpJop ;
		ExpStudy = orgData.ExpStudy ;
		ExpRest = orgData.ExpRest ;
	}
}