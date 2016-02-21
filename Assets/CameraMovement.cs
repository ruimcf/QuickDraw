using UnityEngine;
using System.Collections;
using System;

public class CameraMovement : MonoBehaviour {
    public Camera cam;
    public DrawLine linhas;
    public int x;
    public int y;
    private int j;
    private int i;
    // Use this for initialization
    private void Start()
    {
        x = 800;
        y = 480;
        linhas = this.GetComponent<DrawLine>();

        //Camera.main.orthographicSize = x / 16;
        //transform.position = new Vector3((-5 * x / 8)+(i*x/8), (5 * y / 8)-(j*y/8), -10);
        // Test invoke the method "TestPrintTime" 5 times, once per second
        StartCoroutine(InvokeMethod(MoveCamera, 2, 64));
    }


    private void MoveCamera()
    {
        GameObject novo = new GameObject();
        novo.AddComponent<LineRenderer>().SetWidth(5, 5);
        linhas.countList.Add(0);
        linhas.lineList.Add(novo);

        int a = -350 + (i * 100);
        int b = 210 - (j*60);
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
        GameObject.Find("ObjectiveImage").GetComponent<Renderer>().enabled = false;

        transform.position = new Vector3(0, 0, -10);
        Camera.main.orthographicSize = 240;

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
