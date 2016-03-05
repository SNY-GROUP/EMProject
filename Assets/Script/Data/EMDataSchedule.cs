using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EMDataSchedule
{
	public int	ID	;
	public int	CategoryType	;
	public int	NameID	;
	public int	InfoID	;
	public int	UseType	;
	public int	UseVaule	;
	public int	OpenType	;
	public int	OpenValue	;
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

	public EMDataSchedule (EMDataSchedule orgData)
	{
		ID = orgData.ID ;
		CategoryType = orgData.CategoryType ;
		NameID = orgData.NameID ;
		InfoID = orgData.InfoID ;
		UseType = orgData.UseType ;
		UseVaule = orgData.UseVaule ;
		OpenType = orgData.OpenType ;
		OpenValue = orgData.OpenValue ;
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
	}
}