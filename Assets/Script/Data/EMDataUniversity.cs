using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EMDataUniversity
{
	public int	ID	;
	public int	GradeNameId	;
	public int	NameId	;
	public int	Gold	;
	public int	Stress	;
	public int	Patience	;
	public int	Math	;
	public int	GLanguage	;
	public int	Language	;
	public int	Common	;
	public int	ExpJop	;
	public int	ExpStudy	;
	public int	ExpRest	;
	public int	EndingType	;

	public EMDataUniversity (EMDataUniversity orgData)
	{
		ID = orgData.ID ;
		GradeNameId = orgData.GradeNameId ;
		NameId = orgData.NameId ;
		Gold = orgData.Gold ;
		Stress = orgData.Stress ;
		Patience = orgData.Patience ;
		Math = orgData.Math ;
		GLanguage = orgData.GLanguage ;
		Language = orgData.Language ;
		Common = orgData.Common ;
		ExpJop = orgData.ExpJop ;
		ExpStudy = orgData.ExpStudy ;
		ExpRest = orgData.ExpRest ;
		EndingType = orgData.EndingType ;
	}
}