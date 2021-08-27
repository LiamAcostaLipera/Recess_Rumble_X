using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseScreen : UFEScreen {
	public virtual void GoToMainMenu(){
        UFE.PauseGame(false);
		UFE.StartMainMenuScreen();
		
	}

	public virtual void ResumeGame(){
		UFE.PauseGame(false);
	}

	public void restartscene()
	{
		SceneManager.LoadScene(0);
	}
}
