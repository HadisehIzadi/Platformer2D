using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class level1 : MonoBehaviour
{
	public GameObject hand_RightButton;
	public GameObject hand_GunButton;
	public GameObject hand_ShootButon;
	
	public GameObject Player;
	public GameObject Enemy;
	
	public float timeLeft;
	
	public TMP_Text timer;
    // Start is called before the first frame update
    void Start()
    {
    	hand_GunButton.SetActive(false);
    	hand_ShootButon.SetActive(false);
    	hand_RightButton.SetActive(true);
    	PlayerPrefs.SetInt("FisrtTouchRightButton" , 0);
    	PlayerPrefs.SetInt("FisrtShoot" , 0);
    	PlayerPrefs.SetInt("canShoot" , 0);
    	PlayerPrefs.SetInt("levelNumber" , 1);
    	PlayerPrefs.SetInt("score" , 0);
    }

    // Update is called once per frame
    void Update()
    {
    	if (Player != null && Enemy != null){
        float distanceX = Mathf.Abs(Player.transform.position.x - Enemy.transform.position.x);
        if(distanceX <= 10f)
        	ShowHintShoot();
    	}
    	
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			Player.GetComponent<Movement>().Die();
		}
		
	timer.SetText(((int)timeLeft).ToString());

    }
    
    void ShowHintShoot(){
    	Debug.Log("close Enought");
    	hand_ShootButon.SetActive(true);
    	
    	
    }
    
    
}
