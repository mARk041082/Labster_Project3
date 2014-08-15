using UnityEngine;
using System.Collections;

public class LevelTwo : MonoBehaviour {
	public GUIText userValue;
	public string levelToLoad;
	// Use this for initialization
	void OnGUI(){
		if(GUI.Button(new Rect(10,125,150,50), "Restore Saved Data")){
			userValue.text=GameManager.userData;	
		}
		
		if(GUI.Button(new Rect(Screen.height/2,500,150,50), "Restart")){
			Application.LoadLevel(levelToLoad);	
		}
	}
}
