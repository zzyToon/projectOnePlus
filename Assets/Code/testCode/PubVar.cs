using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubVar : MonoBehaviour {
    public Transform pubTrans;
    private Transform priTrans;
	// Use this for initialization
	void Start () {
        priTrans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(pubTrans.position, priTrans.position) < 10) {
            Debug.Log(pubTrans.position);
        }
	}
}
