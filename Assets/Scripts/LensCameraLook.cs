using UnityEngine;
using System.Collections;

public class LensCameraLook : MonoBehaviour {
    public Camera mainCam;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(transform.position + mainCam.transform.rotation * Vector3.forward, mainCam.transform.rotation * Vector3.up);
	}
}
