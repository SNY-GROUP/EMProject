﻿using UnityEngine;
using System.Collections;
using ComLib;

public class EMGameProcessSimulation : ComFSMEntity<EMDataMgr> 
{
	public override bool OnAwake (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessSimulation] OnAwake");
		
		EMSchedulerMgr.Instance.Init ();
		EMSchedulerMgr.Instance.DataSetting_Temp ();
		
		EMSchedulerMgr.Instance.RegisterSchedule (0, EMSchedulerMgr.Instance.GetSchedule (Define.EMScheduleType.JOB, 2000));
		EMSchedulerMgr.Instance.RegisterSchedule (1, EMSchedulerMgr.Instance.GetSchedule (Define.EMScheduleType.STUDY, 1000));
		EMSchedulerMgr.Instance.RegisterSchedule (2, EMSchedulerMgr.Instance.GetSchedule (Define.EMScheduleType.VACATION, 3000));
		
		return true;
	}

	public override bool OnEnter (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessSimulation] OnEnter");

		EMUIManager.root.OnReset (Define.EMGameProcess.SIMULATION);
		EMUIManager.root.SetActive (Define.EMGameProcess.SIMULATION, true);
		EMSchedulerMgr.Instance.StartSimulation ();

		return true;
	}

	public override bool OnProcess (EMDataMgr p_Owner)
	{
		if(EMSystemMgr.Instance.OnUpdate () == false)
		{
			EMGameManager.Instance.ChangeProcess (Define.EMGameProcess.LOBBY_SCHEDULE_PLAY);
		}

		return true;
	}

	public override bool OnExit (EMDataMgr p_Owner)
	{
		Debug.Log ("[EMGameProcessSimulation] OnExit");

		//EMUIManager.root.OnReset (Define.EMGameProcess.SIMULATION);

		//EMUIManager.root.SetActive (Define.EMGameProcess.SIMULATION, false);



		return true;
	}

	public override void OnGUI (EMDataMgr p_Owner)
	{
		/*
		if(GUI.Button (new Rect(10, 10, 70, 70), "Reset"))
		{
			EMGameManager.Instance.ChangeProcess(Define.EMGameProcess.SIMULATION);
		}
		*/
	}

}
