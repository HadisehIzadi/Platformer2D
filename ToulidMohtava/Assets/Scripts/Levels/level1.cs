using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour
{
	public GameObject hand_RightButton;
	public GameObject hand_GunButton;
    // Start is called before the first frame update
    void Start()
    {
    	hand_GunButton.SetActive(false);
    	hand_RightButton.SetActive(true);
    	PlayerPrefs.SetInt("FisrtTouchRightButton" , 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
