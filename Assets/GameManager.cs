using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	#region STATIC VARIABLES
	public static string userData;
	#endregion

	//STATIC FUNCTION
	public static void OpenScene(string sceneToLoad)
	{
		Application.LoadLevel(sceneToLoad);
	}
}
