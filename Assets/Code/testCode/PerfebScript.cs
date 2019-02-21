using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfebScript : MonoBehaviour {

    public GameObject Perfeb;
	// Use this for initialization
	void Start () {
        Instantiate(Perfeb, new Vector3(0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
