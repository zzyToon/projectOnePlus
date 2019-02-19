using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BNUOthobj : MonoBehaviour {

    public GameObject otherObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Test test = otherObject.GetComponent<Test>();
        test.doSomething();
	}
}
