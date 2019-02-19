using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindType : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test test = FindObjectOfType<Test>();
        Debug.Log(test.gameObject.name);
        Test[] tests = FindObjectsOfType<Test>();
        foreach (Test te in tests) {
            Debug.Log(te.gameObject.name);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
