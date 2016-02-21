using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class LoadImage : MonoBehaviour {
    public GameObject image;
    public GameObject background;
    public List<string> lista;
    public string escolhido;


	// Use this for initialization
	void Start () {

        /*foreach (string file in System.IO.Directory.GetFiles(Application.dataPath + "/Resources/", "*.png*", SearchOption.AllDirectories))
        {
            if (file.EndsWith("png"))
            {
                Debug.Log("Adicionado o ficheiro: " + file);
                lista.Add(Path.GetFileNameWithoutExtension(file));
            }
        }*/
        lista.Add("bulbasaur");
        lista.Add("mewtwo");
        lista.Add("pikachu");
        lista.Add("gengar");
        lista.Add("charizard");
        lista.Add("gato");
        if(lista.Count == 0)
        {
            Debug.Log("Fudeu");
        }
        int random = Random.Range(0, lista.Count);
        print(random);
        escolhido = lista[random];
        image = new GameObject();
        image.name = "ObjectiveImage";
        image.transform.position = new Vector3(0, 0, 0);
        image.AddComponent<SpriteRenderer>();
        image.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load(lista[random], typeof(Sprite));




    }
}
