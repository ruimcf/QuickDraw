using UnityEngine;
using System.Collections;
using System.IO;

public class LoadImage : MonoBehaviour {
    public GameObject image;
    public GameObject background;
    public string path = "bulbasaur";


	// Use this for initialization
	void Start () {


        image = new GameObject();
        image.name = "ObjectiveImage";
        image.transform.position = new Vector3(0, 0, 0);
        image.AddComponent<SpriteRenderer>();
        image.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load(path, typeof(Sprite));




    }
}
