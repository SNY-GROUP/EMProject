using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EMDataAdvertisement
{
	public int	ID	;
	public int	EventType	;
	public int	LevelType	;
	public int	EventNameId	;
	public int	EventInfoId	;
	public int	EventBuyInfoId	;
	public int	SaleMin	;
	public int	SaleMax	;
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
	public int	probabilityGroupID	;

	public EMDataAdvertisement (EMDataAdvertisement orgData)
	{
		ID = orgData.ID ;
		EventType = orgData.EventType ;
		LevelType = orgData.LevelType ;
		EventNameId = orgData.EventNameId ;
		EventInfoId = orgData.EventInfoId ;
		EventBuyInfoId = orgData.EventBuyInfoId ;
		SaleMin = orgData.SaleMin ;
		SaleMax = orgData.SaleMax ;
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
		probabilityGroupID = orgData.probabilityGroupID ;
	}
}