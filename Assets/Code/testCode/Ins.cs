using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ins : MonoBehaviour {
    public Transform prefab;
	// Use this for initialization
    public void Awake() {
        int i = 0;
        while (i < 5) {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
            i++;
        }
    }
    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
