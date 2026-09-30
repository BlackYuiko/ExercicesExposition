using UnityEngine;

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
	public void Quit()
	{
		Application.Quit();
		Debug.Log("Application quitted");
	}
	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (!gameObject.activeSelf)
			{
				OpenPause();
			}
			else
			{
				ClosePause();
			}
		}
	}
}
