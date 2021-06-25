using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;//隐藏鼠标指针
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
