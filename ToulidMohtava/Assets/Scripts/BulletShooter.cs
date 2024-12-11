using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
	public GameObject bulletPrefab;
	
	public Transform bulletSpawner;
	public float bulletSpeed = 10f;
	float scale;
	public GameObject handHint_shoot;
	
	
	// Start is called before the first frame update
	void Start()
	{
        
	}

	// Update is called once per frame
	void Update()
	{
        
	}
    
    
	public void Shoot()
	{
		
		if (PlayerPrefs.GetInt("canShoot", 0) == 1) {
			PlayerPrefs.SetInt("FisrtShoot" , 1);
			handHint_shoot.SetActive(false);
			

			GameObject bullet = Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation);


			Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        
			if (transform.localScale.x > 0)
				scale = 1f;
			else
				scale = -1f;
        	
			if (rb != null) {
				rb.velocity = new Vector2(scale * bulletSpeed, 0);
			}
			Destroy(bullet, 1f);  
		}
	}
}
