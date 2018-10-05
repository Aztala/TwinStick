using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool isRecording = true;


	// Use this for initialization
	void Start () {
		
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
	}
}
