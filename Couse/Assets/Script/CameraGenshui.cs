using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class CameraGenshui : MonoBehaviour {

	//private Cameras cam;
	// Use this for initialization
	void Start () {
		//cam = GetComponent<Cameras>();
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion ro = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
		//var vector = Vector3.forward * Distance;
		var vector = Vector3.forward;
		vector  = ro * vector;
		var pos = transform.position - vector;
		this.transform.position = pos;
		this.transform.rotation = ro;
	}
}
