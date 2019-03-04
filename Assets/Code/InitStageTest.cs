using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitStageTest : MonoBehaviour {
    public Transform transform;
    public void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(transform, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
