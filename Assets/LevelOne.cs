using UnityEngine;
using System.Collections;

public class LevelOne : MonoBehaviour {
	public string userInputText = "Enter Scene To Load";
	public string sceneToLoad;
	// Use this for initialization
	void OnGUI () {
		userInputText = GUI.TextField(new Rect(10,90,200,20), userInputText, 25);
		
		if(GUI.Button(new Rect(10,150,100,50), "Save Data")){
			GameManager.userData = userInputText;	
		}
		
		if (GUI.Button(new Rect(10,220,100,50), "Open Scene")){
			GameManager.OpenScene(sceneToLoad);
		}
	}
}
