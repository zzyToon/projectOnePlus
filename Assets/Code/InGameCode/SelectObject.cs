using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour {

    public static void TouchPick()
    {
        if (Input.touchCount != 1)
            return;

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //射线碰撞信息
            RaycastHit hit;
            //射线发射器
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }

    public static Transform MousePick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                //Debug.Log(hit.transform.tag);
                return hit.transform;
            }
            return null;
        }
        return null;
    }
}
