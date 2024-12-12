using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public ParticleSystem bloodParticleSystem;
	public ParticleSystem starsParticleSystem;
	
	bool isDied;
	int shotCount;
	
    // Start is called before the first frame update
    void Start()
    {
    	isDied = false;
    	shotCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
    	
    		
    }
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Bullet"){
    		shotCount++;
			isDied = true;
			Debug.Log("OnCollisionEnter2D");
			if(shotCount == 1 ){
				Instantiate(bloodParticleSystem, transform.position, Quaternion.identity);
				Instantiate(starsParticleSystem, transform.position, Quaternion.identity);}
        
			Destroy(col.gameObject);



			Destroy(gameObject, 0.1f);
     


        
    	
    	}
    	
    	if(col.gameObject.tag == "Player")
    	{
    		if(PlayerPrefs.GetInt("score" , 0) != 0)
    			PlayerPrefs.SetInt("score" ,  PlayerPrefs.GetInt("score" , 0)-2);
    		
    		Debug.Log("score after touching enemey : " + PlayerPrefs.GetInt("score" , 0));
    	}
    	
    	
    	
    }
}
