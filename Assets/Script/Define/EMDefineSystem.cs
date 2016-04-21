using UnityEngine;
using System.Collections;

namespace Define
{
	public enum EMGameProcess
	{
		NULL,
		SAMPLE,
		START,
		SIMULATION,
		TITLE,
		INTRO,
		LOBBY,
		LOBBY_USER_STATE,
		LOBBY_SCHEDULE_INFO,
		LOBBY_SCHEDULE_PLAY,
		LOBBY_SCHEDULE_PLAY_EVENT,
		HOMESHOPPING,
		HOMESHOPPING_EVENT,
		FINISH,
	}

	public enum EMResultType
	{
		SIMULATION,
		EVENT,
		GAME_CLEAR,
		SELECT_UNIVERSITY,
		ENABLE_RETURN,
	}

	public enum EMScheduleType
	{
		STUDY,
		JOB,
		VACATION,
	}
}