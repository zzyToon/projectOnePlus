
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectInit : MonoBehaviour {
    //获取当前屏幕宽高
    private int screenWidth;
    private int screenHight;
    //获取content和scrollbar组件
    public GameObject content;
    public GameObject scrollBar;
    public void Awake()
    {
        //SetContentSize();
        //SetGridSize();
        gridAdaptation();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gridAdaptation() {
        /*
         * 1.初始化cell，为cell加载内容，获取cell数量
         * 获取屏幕宽度
         * 屏幕宽度 - scrollbar宽度 即为content宽度
         * 设置cell宽高
         * 设置content宽高
         * 5.content高度 = (cell高度 + spacing) * [cell数量 / 每行cell数量]（向上取整） - spacing
         * 6.向上取整函数：Mathf.Ceil(num);
        */

        //此处应为初始化cell函数
        //设置content宽度
        screenWidth = Screen.width;
        content.GetComponent<RectTransform>().sizeDelta = new Vector2(screenWidth - scrollBar.GetComponent<RectTransform>().rect.width, screenWidth);
        Debug.Log(content.GetComponent<RectTransform>().sizeDelta.x);

        //设置cell宽高
        var grid = content.GetComponent<GridLayoutGroup>();
        var rect = content.GetComponent<RectTransform>().rect;
        grid.cellSize = new Vector2((rect.width - grid.spacing.x * 4) / 5, (rect.width - grid.spacing.y * 4) / 5);
       
        Debug.Log(rect.width);
        Debug.Log(grid.cellSize.x);
        Debug.Log(grid.cellSize.x * 5 + grid.spacing.x * 4);

        //设置content高度
        content.GetComponent<RectTransform>().sizeDelta = new Vector2(rect.width, (grid.cellSize.x + grid.spacing.x) * Mathf.Ceil((float)content.GetComponent<RectTransform>().childCount / 5) - grid.spacing.x);
        //content.GetComponent<RectTransform>().sizeDelta = new Vector2(rect.width, grid.cellSize.x * Mathf.Ceil((float)content.GetComponent<RectTransform>().childCount / 5));
       
        
        Debug.Log(content.GetComponent<RectTransform>().childCount); 
    }
    /*
    public void SetContentSize()
    {
        screenWidth = Screen.width;
        screenHight = Screen.height;
        Debug.Log("screen width is:" + screenWidth + "screen hight is:" + screenHight);
        content.GetComponent<RectTransform>().sizeDelta = new Vector2(screenWidth - scrollBar.GetComponent<RectTransform>().rect.width, screenHight);
        Debug.Log("content width is:" + content.GetComponent<RectTransform>().rect.width + "content hight is:" + content.GetComponent<RectTransform>().rect.height);

    }

    public void SetGridSize() 
    {
        var grid = content.GetComponent<GridLayoutGroup>();
        var rect = content.GetComponent<RectTransform>().rect;
        grid.cellSize = new Vector2((rect.width - grid.spacing.x*4) / 5, (rect.width - grid.spacing.y*4) / 5);
    }
    */
    
    
}
