using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool isRecording = true;
    public Text GamePausedText;

    private static float FixedDeltaTime;
    private bool Gamepaused = false;
	// Use this for initialization
	void Start () {
        FixedDeltaTime = Time.fixedDeltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton( "Fire2" ))
        {
            isRecording = false;
        }
        else
        {
            isRecording = true;
        }

        if (Input.GetKeyDown( KeyCode.P ))
        {
            PauseGame();
        }
	}
    public void PauseGame()
    {
        if (Gamepaused == false)
        {
            Gamepaused = !Gamepaused;
            Time.timeScale = 0;
            Time.fixedDeltaTime = 0;
            print( "Game is Paused as : " + Gamepaused );
            GamePausedText.GetComponent<Text>().enabled = true;
        }
        else
        {
            Gamepaused = !Gamepaused;
            Time.timeScale = 1;
            Time.fixedDeltaTime = FixedDeltaTime;
            print( "Game is Paused as : " + Gamepaused );
            GamePausedText.GetComponent<Text>().enabled = false;

        }
    }
}
