using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

    public Vector3 currentposition;
    public Vector3 DistanceFromBall;
    public GameObject ball;
	// Use this for initialization
	void Start () {
        Vector3 ballpos;
        ball = GameObject.Find( "RollerBall" );
        ballpos = ball.transform.position;
        currentposition = this.transform.position;
        DistanceFromBall = currentposition - ballpos;
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void LateUpdate()
    {
        this.transform.position = DistanceFromBall + ball.transform.position;
    }
}
