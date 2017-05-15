using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(string sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
}
