using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
 	private int currentScene;
	private int previousScene;

    // public void ChangeScene(string ClueName) {
   	// 	Application.LoadLevel(clueName);
    // }

    // Start is called before the first frame update
    void Start() {
        previousScene = 0;
        currentScene = 1;
        GameObject.Find("Clue1").SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (currentScene != previousScene) {
        	GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Scene"+currentScene.ToString());
        }
        previousScene = currentScene;
		if (GetComponent<SpriteRenderer>().sprite == Resources.Load<Sprite>("Sprites/Scene1"))
        	GameObject.Find("Clue #1").SetActive(true);
        else
        	GameObject.Find("Clue #1").SetActive(false);
    }

       public int CurrentScene {
		get {
			return currentScene;
		} set {
			if (value == 4)
				currentScene = 1;
			else if (value == 0)
				currentScene = 3;
			else
				currentScene = value;
		}
	}
}
