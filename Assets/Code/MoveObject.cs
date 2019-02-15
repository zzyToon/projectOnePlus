using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public float speed = 0.1F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    Vector3 MyScreenPointToWorldPoint(Vector3 ScreenPoint,Transform target)
    {
        //1 得到物体在主相机的xx方向
        Vector3 dir = (target.position - Camera.main.transform.position)  ;
        //2 计算投影 (计算单位向量上的法向量)
        Vector3 norVec= Vector3.Project(dir, Camera.main.transform.forward);
        //返回世界空间
        return Camera.main.ViewportToWorldPoint
            (
               new Vector3(
                   ScreenPoint.x/Screen.width,
                   ScreenPoint.y/Screen.height,
                   norVec.magnitude
               )
            );
        
    }
 
    Vector3 startPos;
    Vector3 endPos;
    Vector3 offset;
 
    private void OnMouseDown()
    {
        //记录起始位置
        //因为我们的物体cube所处的是世界空间 鼠标是屏幕空间
        //需要将鼠标的屏幕空间转换成世界空间
        startPos = MyScreenPointToWorldPoint(Input.mousePosition, transform);
    }
 
    private void OnMouseDrag()
    {
        endPos = MyScreenPointToWorldPoint(Input.mousePosition, transform);
        //计算偏移量
        offset = endPos - startPos;
        //让cube移动
        transform.position += offset;
        //这一次拖拽的终点变成了下一次拖拽的起点  
        startPos = endPos;
    }

}
