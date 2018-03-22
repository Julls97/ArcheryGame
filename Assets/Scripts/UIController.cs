using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public Animator slidePanelWin;

	public void PlayFastGameButton() {
		SceneManager.LoadScene("FastGame");
	}
	public void SettingsButton() {
		SceneManager.LoadScene("SettingsMenu");
	}
	public void ExitButton() {
		SceneManager.LoadScene("Menu");
	}


	public void IsDone() {
		slidePanelWin.enabled = true;
		bool isHidden = slidePanelWin.GetBool("isHidden");
		slidePanelWin.SetBool("isHidden", !isHidden);
	}


	void Start () {
		
	}
	void Update () {
		
	}
}
