using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScene : MonoBehaviour {
    public GameObject panel;
    public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && panel.activeSelf == false) {
            panel.SetActive(true);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            panel.SetActive(false);
        }
	}
}
