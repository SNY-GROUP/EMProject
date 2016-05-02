using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ComLib;
using Define;

public class EMGameManager : Singleton<EMGameManager>
{
	private EMDataMgr m_DataMgr = new EMDataMgr();
	private Dictionary<int, ComFSMEntity<EMDataMgr>> m_ProcessDic;
	private ComFSMEntity<EMDataMgr> m_CurProcess = null;

	public EMGameProcess GetCurProcess ()
	{
		if(m_DataMgr != null)
		{
			return m_DataMgr.GetProcess();
		}
		return EMGameProcess.NULL;
	}

	private bool Equals ( EMGameProcess p_Process )
	{
		Debug.Log (string.Format("Equals? {0}, {1}", GetCurProcess () ,p_Process));
		if (GetCurProcess () == p_Process)
			return true;

		return false;
	}

	public bool OnInit ()
	{
		OnRegister ();

		m_DataMgr.OnInit ();

		foreach(ComFSMEntity<EMDataMgr> fsm in m_ProcessDic.Values)
		{
			fsm.OnAwake(m_DataMgr);
		}

		return true;
	}

	public void OnStart ()
	{
#if _Sample_
		SetSampleProcess ();
		return;
#endif
		SetStartProcess ();
	}

	private void OnRegister ()
	{
		if(m_ProcessDic == null)
		{
			m_ProcessDic = new Dictionary<int, ComFSMEntity<EMDataMgr>>();
		}

		m_ProcessDic.Add ((int)EMGameProcess.SAMPLE, new EMGameProcessSample ());
		m_ProcessDic.Add ((int)EMGameProcess.START, new EMGameProcessStart ());
		m_ProcessDic.Add ((int)EMGameProcess.SIMULATION, new EMGameProcessSimulation ());
		m_ProcessDic.Add ((int)EMGameProcess.TITLE, new EMGameProcessTitle ());
		m_ProcessDic.Add ((int)EMGameProcess.INTRO, new EMGameProcessIntro ());
		m_ProcessDic.Add ((int)EMGameProcess.LOBBY, new EMGameProcessLobby ());
		m_ProcessDic.Add ((int)EMGameProcess.LOBBY_USER_STATE, new EMGameProcessLobbyUserState ());
		m_ProcessDic.Add ((int)EMGameProcess.LOBBY_SCHEDULE_INFO, new EMGameProcessLobbyScheduleInfo ());
		m_ProcessDic.Add ((int)EMGameProcess.LOBBY_SCHEDULE_PLAY, new EMGameProcessLobbySchedulePlay ());
		m_ProcessDic.Add ((int)EMGameProcess.LOBBY_SCHEDULE_PLAY_EVENT, new EMGameProcessLobbySchedulePlayEvent ());
		m_ProcessDic.Add ((int)EMGameProcess.HOMESHOPPING, new EMGameProcessHomeShopping ());
		m_ProcessDic.Add ((int)EMGameProcess.HOMESHOPPING_EVENT, new EMGameProcessHomeShoppingEvent ());
		m_ProcessDic.Add ((int)EMGameProcess.FINISH, new EMGameProcessFinish ());
	}

	private void SetSampleProcess ()
	{
		ChangeProcess (EMGameProcess.SAMPLE);
	}

	private void SetStartProcess ()
	{
		ChangeProcess (EMGameProcess.START);
	}

	public void ChangeProcess ( EMGameProcess p_Process )
	{
		if (Equals (p_Process))
			return;

		if(m_ProcessDic.ContainsKey((int)p_Process) == false)
		{
			Debug.Log (string.Format("[ChangeProcess] this process ({0}) is not found!", p_Process.ToString()));
			return;
		}

		if(m_CurProcess != null)
		{
			m_CurProcess.OnExit(m_DataMgr);
		}
		m_CurProcess = m_ProcessDic [(int)m_DataMgr.SetProcess(p_Process)];

		m_CurProcess.OnEnter (m_DataMgr);
		EMUIManager.root.Show (GetCurProcess());

		EMUIManager.root.OnResetExcept (GetCurProcess());
	}

	public void OnDestroy ()
	{
		OnRelease ();

		m_CurProcess = null;
		m_ProcessDic = null;
		Instance = null;
	}

	public void OnRelease ()
	{
		if(m_ProcessDic != null)
		{
			m_ProcessDic.Clear();
		}
	}

	public void OnUpdate ()
	{
		if(m_CurProcess != null)
		{
			m_CurProcess.OnProcess(m_DataMgr);
		}
	}

	public void OnGUI ()
	{
		if(GUI.Button(new Rect(310, 10, 70, 70), "Back"))
		{
			SetSampleProcess();
		}

		if(m_CurProcess != null)
		{
			m_CurProcess.OnGUI(m_DataMgr);
		}
	}
}