using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public void PlayFastGameButton() {
		SceneManager.LoadScene("FastGame");
	}
	public void SettingsButton() {
		SceneManager.LoadScene("SettingsMenu");
	}
	public void ExitButton() {
		SceneManager.LoadScene("Menu");
	}

	void Start () {
		
	}
	void Update () {
		
	}
}
