using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
	public GameObject pausePanel;
	public GameObject exitPanel;
	public GameObject settingPanel;
	public GameObject winningPanel;
	// Start is called before the first frame update
	void Start()
	{
        
	}

	// Update is called once per frame
	void Update()
	{
        
	}
    
	public  void Pause()
	{
		pausePanel.SetActive(true);
		Time.timeScale = 0f;
	}
    
	public void Resume()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive(false);
		settingPanel.SetActive(false);
		exitPanel.SetActive(false);
	}
	
	
	public void exit()
	{
		pausePanel.SetActive(false);
		exitPanel.SetActive(true);
		
	}
	
	public void setting()
	{
		settingPanel.SetActive(true);
		Time.timeScale = 0f;
	}
	
	public void Restart()
	{
		Time.timeScale = 1f;
		int levelNumber = PlayerPrefs.GetInt("levelNumber" , 1);
		SceneManager.LoadScene(levelNumber -1 );
	}
	 
	
	IEnumerator Win()
	{
		yield return new WaitForSeconds(0.5f);
	//	Time.timeScale = 0f;
		winningPanel.SetActive(true);
	}
}
