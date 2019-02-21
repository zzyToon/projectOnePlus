using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {
    public GameObject cube;
    public GameObject Perfeb;
    private float lastDis = 0;
    private float camDis = -20;
    public float scaleDump = 0.1f;

    void Awake()
    {
        Instantiate(Perfeb, new Vector3(0, 0, 0), Quaternion.identity);
    }
	// Use this for initialization
	void Start () {
        cube = GameObject.FindWithTag("Cap");
        Debug.Log(cube.name);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                cube.transform.Rotate(Vector3.right, Input.GetAxis("Mouse Y"), Space.World);
                cube.transform.Rotate(Vector3.up, -1 * Input.GetAxis("Mouse X"), Space.World);
            }
        }
        else if (Input.touchCount > 1)
        {
            Touch t1 = Input.GetTouch(0);
            Touch t2 = Input.GetTouch(1);
            if (t2.phase == TouchPhase.Began)
            {
                lastDis = Vector2.Distance(t1.position, t2.position);
            }
            else if(t1.phase == TouchPhase.Moved && t2.phase == TouchPhase.Moved)
            {
                float dis = Vector2.Distance(t1.position, t2.position);
                if (Mathf.Abs(dis - lastDis) > 1)
                {
                    camDis += (dis - lastDis) * scaleDump;
                    camDis = Mathf.Clamp(camDis, -40, -5);
                    lastDis = dis;
                }
            }
        }
    }
        void LateUpdate(){
            this.transform.position = new Vector3(0,0,camDis);
        }
        /*void OnGUI()
        {

        }*/
}
