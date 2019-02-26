using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasApresentacao : MonoBehaviour {

    public Transform transformCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            
            transformCamera.position = new Vector3(transformCamera.position.x - 10.5f, transformCamera.position.y + 14.3f, transformCamera.position.z- 10.2f); ;

            transformCamera.Rotate(transformCamera.rotation.x + 8.25f, transformCamera.rotation.y - 99.424f, transformCamera.rotation.z);
        }

    }
}
