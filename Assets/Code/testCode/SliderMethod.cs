using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderMethod : MonoBehaviour {
    public Slider sd;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnValuechanged() {
        text.text = "当前的值为" + sd.value;
    }
}
