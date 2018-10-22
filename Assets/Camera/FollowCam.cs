using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

    public Vector3 currentposition;
    public Vector3 DistanceFromBall;
    public GameObject ball;
    public GameObject stick;
    private Camera cam;
	// Use this for initialization
	void Start () {
        Vector3 ballpos;
        ball = GameObject.FindGameObjectWithTag("Player");
        stick = GameObject.FindObjectOfType<SelfieStick>().gameObject;
        ballpos = ball.transform.position;
        currentposition = this.transform.position;
        DistanceFromBall = currentposition - ballpos;
        cam = GetComponent<Camera>();
	}
	
    private void LateUpdate()
    {
        cam.transform.LookAt( ball.transform );
        
       // cam.transform.position = stick.transform.position;
        //cam.transform.rotation = stick.transform.rotation  ;
        //this.transform.position = DistanceFromBall + ball.transform.position;
    }
}
