using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vec : MonoBehaviour {
    public Vector3 position = new Vector3();
    public GameObject gameObj;
	// Use this for initialization
	void Start () {
        position = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
        gameObj.transform.Translate(position);
	}
}
