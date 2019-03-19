using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	//public float X, Y, Z;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if (Input.GetKey(KeyCode.Mouse0))
		{
			transform.Rotate(Vector3.right, Input.GetAxis("Mouse Y"), Space.World);
            transform.Rotate(Vector3.down, Input.GetAxis("Mouse X"), Space.World);
		}
		
	}
}
