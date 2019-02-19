using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParChild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Find("Cube").Rotate(1, 0, 0);
        this.transform.parent.Rotate(1, 0, 0);
	}
}
