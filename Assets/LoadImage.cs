using UnityEngine;
using System.Collections;
using System.IO;

public class LoadImage : MonoBehaviour {
    public GameObject image;


	// Use this for initialization
	void Start () {
        image = new GameObject();
        image.AddComponent<SpriteRenderer>();
        //image.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("Assets/Resources/cavalos.png");
        image.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("gato", typeof(Sprite));
        //Texture2D texture = LoadPNG("cavalos.png");
        //image.AddComponent<RenderTexture>();
        //image.GetComponent<RenderTexture>().material.mainTexture = texture;



    }

    public static Texture2D LoadPNG(string filePath)
    {

        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            print("Ficheiro existe");
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
