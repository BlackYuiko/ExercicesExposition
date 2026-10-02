using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public void OpenPause()
	{
		gameObject.SetActive(true);
		Time.timeScale = 0f;
	}
	public void ClosePause()
	{
		gameObject.SetActive(false);
		Time.timeScale = 1f;
	}
	public void ResetGame()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Game");
	}
	public void Quit()
	{
		Application.Quit();
		Debug.Log("Application quitted");
	}
}
