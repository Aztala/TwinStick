using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayCS : MonoBehaviour {

    private const int buffersize = 1000;
    private ReplayKeyFrame[] keyFrames = new ReplayKeyFrame[ buffersize ];
    private Rigidbody rb;
    private GameManager gm;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gm.isRecording)
        {
            Record();
        }
        else
        {
            playback();
        }
    }

    void Record()
    {
        rb.isKinematic = false;
        int frame = Time.frameCount % buffersize;
        float time = Time.time;
       // print( "Writting frame :" + frame );

        keyFrames[ frame ] = new ReplayKeyFrame( time, transform.position, transform.rotation );
    }
    void playback()
    {
        rb.isKinematic = true;
        int frame = Time.frameCount % buffersize;
        //print("reading frame: " + frame);
        transform.position = keyFrames[ frame ].position;
        transform.rotation = keyFrames[ frame ].rotation;
    }
}
//Used for storing keyframe of a replay.
public struct ReplayKeyFrame
{
    public float time;
    public Vector3 position;
    public Quaternion rotation;
    public ReplayKeyFrame(float _time, Vector3 _pos, Quaternion _rot)
    {
        time = _time;
        position = _pos;
        rotation = _rot;
    }
}
