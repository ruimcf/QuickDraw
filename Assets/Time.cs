using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
    public Text texto;
    float tempo = 100;

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        tempo -= UnityEngine.Time.deltaTime;

    }
    void onGUI()
    {
        
    }
}
