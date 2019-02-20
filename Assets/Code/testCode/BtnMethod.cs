using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMethod : MonoBehaviour {
    public GameObject gameObj;
    private int counter = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (counter % 2 == 0)
        {
            gameObj.SetActive(true);
        }
        else {
            gameObj.SetActive(false);
        }
	}

    public void OnClick()
    {
        counter++;
    }
}
