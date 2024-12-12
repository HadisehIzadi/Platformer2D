using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSelection : MonoBehaviour
	
{
	public GameObject[] weaponsOnBag;
	public GameObject shootButton;
	public SoundManager soundManaer;
	//public GameObject FingerHint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void Gun1taken()
    {
    	PlayerPrefs.SetInt("canShoot" , 1);
    	shootButton.SetActive(true);
    	PlayerPrefs.SetInt("GunNumber" , 1);
    	this.gameObject.SetActive(false);
    	weaponsOnBag[0].SetActive(true);
    	soundManaer.PlayCatchSound();
    //	FingerHint.SetActive(false);
    }
    
    void OnMouseDown()
    {
        Debug.Log($"Obstacle {gameObject.name} clicked!");
        Gun1taken();
    }

    
}
