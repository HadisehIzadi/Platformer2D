using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public ParticleSystem bloodParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Bullet"){
        Debug.Log("OnCollisionEnter2D");
        Instantiate(bloodParticleSystem, transform.position, Quaternion.identity);
        Destroy(col.gameObject);



        Destroy(gameObject, 0.1f);
     


        
    	
    	}
    }
}
