using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;
    //public Button Clue1;

    // Start is called before the first frame update
    void Start() {
        currentDisplay = GameObject.Find("displayObject").GetComponent<DisplayImage>();
    }

    public void OnCouponPress() {
    	GameObject.Find("Clue1").gameObject.SetActive(true);
    }

    public void OnRightClickArrow() {
    	currentDisplay.CurrentScene = currentDisplay.CurrentScene + 1;
    	
    	if (currentDisplay.CurrentScene == 1)
        	GameObject.Find("Clue #1").SetActive(true);
        else if (currentDisplay.CurrentScene != 1)
        	GameObject.Find("Clue #1").SetActive(false);
        showOrHideClue();
    }

    public void OnLeftClickArrow() {
    	currentDisplay.CurrentScene = currentDisplay.CurrentScene - 1;
    	if (currentDisplay.CurrentScene == 1)
        	GameObject.Find("Clue #1").SetActive(true);
        else if (currentDisplay.CurrentScene != 1)
        	GameObject.Find("Clue #1").SetActive(false);
    	showOrHideClue();
    }

    private void showOrHideClue() {
		// GetComponent<SpriteRenderer>().sprite == Resources.Load<Sprite>("Sprites/Scene1");

		if (currentDisplay.CurrentScene == 1)
        	GameObject.Find("Clue #1").SetActive(true);
        else if (currentDisplay.CurrentScene != 1)
        	GameObject.Find("Clue #1").SetActive(false);
    }

    // Update is called once per frame
   // void Update() {
        
   //  }
}
