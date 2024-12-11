using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public GameObject pausePanel;
	public GameObject exitPanel;
	public GameObject settingPanel;
	
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
}
