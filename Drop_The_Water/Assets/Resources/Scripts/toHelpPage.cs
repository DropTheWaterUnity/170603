using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHelpPage : toNextPage {

	private int helpPrevious;
	
	public override void GotoNext() {
		helpPrevious = SceneManager.GetActiveScene().buildIndex;
		int nextScene = helpPrevious + 1;

		if(nextScene<15){
			SceneManager.LoadScene(nextScene);
		}

		Debug.Log("previous : " + previousScene + "	helpPrevious :" + helpPrevious);
	}

	public override void GotoScene(int i) {
		helpPrevious = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(i);
	}

	public override void GoBack() {
		SceneManager.LoadScene(helpPrevious);
	}

	public void GotoSetting() {
		base.GoBack();
		previousScene = settingBack;
	}
}
