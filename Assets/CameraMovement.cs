using UnityEngine;
using System.Collections;
using System;

public class CameraMovement : MonoBehaviour {
    public Camera cam;
    public int x;
    public int y;
    private int j;
    private int i;
    // Use this for initialization
    private void Start()
    {
        x = Screen.width;
        y = Screen.height;
        print(x + " " + y);
        Camera.main.orthographicSize = x / 16;
        //transform.position = new Vector3((-5 * x / 8)+(i*x/8), (5 * y / 8)-(j*y/8), -10);
        // Test invoke the method "TestPrintTime" 5 times, once per second
        StartCoroutine(InvokeMethod(MoveCamera, 1, 64));
    }


    private void MoveCamera()
    {
        int a = (-5 * x / 8) + (i * x / 8) + (2*x/8);
        int b = (5 * y / 8) - (j * y / 8) - (2*y/8);
        print("A mover camera para: " + a + " " + b);
        transform.position = new Vector3(a, b, -10);
    }


    public IEnumerator InvokeMethod(Action method, float interval, int invokeCount)
    {
        for (j=0; j < 8; j++)
        {
            for (i = 0; i < 8; i++)
            {
                method();


            
                yield return new WaitForSeconds(interval);
            }
        }

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0));
        }
    }
}
