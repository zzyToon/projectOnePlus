﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick() { 
        InputField accNumber = GameObject.Find("AccNumber").GetComponent<InputField>();
        InputField psWord = GameObject.Find("Password").GetComponent<InputField>();
        Debug.Log("账号："+accNumber.text);
        Debug.Log("密码：" + psWord.text);
        if (accNumber.text.Length == 0)
        {
            string accEmpty = "账号不能为空！";
            accEmpty.showAsToast();
        }
        else if (psWord.text.Length == 0) 
        {
            string pswEmpty = "密码不能为空！";
            pswEmpty.showAsToast();
        }
        else
        {
            SceneManager.LoadScene("InGame");
        }
    }
}
