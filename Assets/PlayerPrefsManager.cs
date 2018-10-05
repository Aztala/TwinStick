using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFF_KEY = "difficulty";
    const string LEVEL_UNLOCK = "lvl_unlock";
	const float volume = 1.0f;
	const float diff = 1.0f;




	#region Master Volume
	public static void SetMasterVolume(float vol)
	{
		if (vol >= 0f && vol <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, vol);
		} else {
			Debug.LogError ("Master Volume Invalid Range must be between 0 and 1 current : " + vol);
		}
	}
	public static float GetMasterVolume()
	{
		/*if (PlayerPrefs.GetFloat(MASTER_VOLUME_KEY)) {*/
			float vol = PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
			return vol;
		/*} else {
			Debug.LogError ("Master Volume Was not set yet");
			float currentVolume = GameObject.Find ("MusicManager").GetComponent<AudioSource> ().volume;
			Debug.LogException ("Master Volume as been set to : "+ currentVolume + " as default level!");
			SetMasterVolume(currentVolume);
			return currentVolume;
		}*/
	}
	#endregion 
	#region Difficulty
	public static void SetDifficulty(float difficulty)
	{
		if (difficulty >= 1f && difficulty <= 3f)
		{
			PlayerPrefs.SetFloat (DIFF_KEY, difficulty);
		}
		else
		{
			Debug.LogError("Difficulty is in an invalid range must be between 1 and 3 current : " + difficulty);
		}
	}
	public static float GetDifficulty()
	{
		float difficulty = PlayerPrefs.GetFloat (DIFF_KEY);
		return difficulty;
	}
	#endregion 
}
