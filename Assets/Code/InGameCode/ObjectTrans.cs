using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTrans : MonoBehaviour {

    Transform curObj;
    Transform nextObj;
    bool isChossingObj = false;
	// Use this for initialization
	void Start () {
        curObj = null;
        nextObj = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (SelectObject.MousePick() != null)
        {
            ChoosingObj(SelectObject.MousePick());
        } 
	}

    public void ChoosingObj(Transform obj)
    {

        nextObj = obj;
        DoOutLine();
    }

    void DoOutLine()
    {
        if (isChossingObj == true)
        {
            Debug.Log("CANCLE " + curObj.name);
            Debug.Log("DRAW " + nextObj.name);
            curObj.GetComponent<cakeslice.Outline>().color = 0;
            nextObj.GetComponent<cakeslice.Outline>().color = 1;
            curObj = nextObj;
        }
        else
        {
            Debug.Log("NO CALCLE DRAW " + nextObj.name);
            nextObj.GetComponent<cakeslice.Outline>().color = 1;
            Transform selectedMenu = nextObj.GetChild(0);
            selectedMenu.gameObject.SetActive(true);
            isChossingObj = true;
            curObj = nextObj;
        }
    }
}
