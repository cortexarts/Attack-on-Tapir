using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    [SerializeField]
    Scene SceneToLoad;

	// Use this for initialization
	public void StartGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame() {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
