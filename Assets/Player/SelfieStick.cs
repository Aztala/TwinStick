using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfieStick : MonoBehaviour {

    private GameObject player;
    private Vector3 armRotation;

    public float panSpeed = 10f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<Player>().gameObject;
        armRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        armRotation.y += Input.GetAxis("RVert") * panSpeed;
        armRotation.x += Input.GetAxis("RHoriz") * panSpeed;
        transform.position = player.transform.position;
        transform.rotation = Quaternion.Euler( armRotation );
	}
}
