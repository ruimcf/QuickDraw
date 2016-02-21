using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DrawLine : MonoBehaviour
{
    public List<GameObject> lineList = new List<GameObject>();
    public List<int> countList = new List<int>();
    void Start()
    {
        bool supportsMultiTouch = Input.multiTouchEnabled;

        print("MultiTouchSupport : " + supportsMultiTouch);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (lineList.Count == 0)
            {
                GameObject novo = new GameObject();
                novo.AddComponent<LineRenderer>().SetWidth(5, 5);
                countList.Add(0);
                lineList.Add(novo);
            }
            if(lineList.Count > 0) {
                lineList[lineList.Count-1].GetComponent<LineRenderer>().SetVertexCount(++countList[countList.Count - 1]);
                Vector3 mousePos = new Vector3(0, 0, 0);
                mousePos = Input.mousePosition;
                mousePos.z = 1;
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
                lineList[lineList.Count-1].GetComponent<LineRenderer>().SetPosition(countList[countList.Count - 1] - 1, worldPos);
            }

        }
        else {
            if(countList.Count > 0)
            {
                if(countList[countList.Count -1] > 0){
                    GameObject novo = new GameObject();
                    novo.AddComponent<LineRenderer>().SetWidth(5, 5);
                    countList.Add(0);
                    lineList.Add(novo);
                }
            }
        }
    }
}