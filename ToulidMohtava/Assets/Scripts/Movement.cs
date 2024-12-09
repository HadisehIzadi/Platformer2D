using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 5f;
	public Animator movementAnimation;
	public bool canAnimate = false;
	public bool hasGravity = true;
	
	 public Rigidbody2D rb;
	 public RuntimeAnimatorController newController;
	 
    // Start is called before the first frame update
    void Start()
    {
        movementAnimation.enabled = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	if(canAnimate == false)
    		movementAnimation.enabled = false;
    	else
    		movementAnimation.enabled = true;
    	
    	
    	if(hasGravity == false)
    	{
			rb.gravityScale = 0f;
			
    	}
    	else
    		rb.gravityScale = 1f;
    	
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Obstacle")
        Debug.Log("OnCollisionEnter2D");
    }
    
    
    
    
    
    public void MoveRight()
    {
    	canAnimate = true;
    	//movementAnimation.enabled = true;
    	transform.position+=new Vector3(speed * Time.deltaTime , 0 , 0 );
    	
    	if(transform.localScale.x < 0 ){
		var newScale = new Vector3(
			                  transform.localScale.x * -1f,
			                  transform.localScale.y,
			                  transform.localScale.z);


    		transform.localScale = newScale;}
    }
    public void MoveLeft()
    {
    	canAnimate = true;
    	transform.position+=new Vector3(-speed * Time.deltaTime , 0 , 0 );
    	
    	if(transform.localScale.x > 0 ){
		var newScale = new Vector3(
			                  transform.localScale.x * -1f,
			                  transform.localScale.y,
			                  transform.localScale.z);


    		transform.localScale = newScale;}
    }
    
    
    
    public void MoveUp()
    {
    	canAnimate = true;
    	Vector3 direction = new Vector3(0, 10*speed * Time.deltaTime, 0);
			rb.velocity = direction * speed;
    	//transform.position+=new Vector3(0, speed * Time.deltaTime  , 0 );
    }
    
    
    
    
    

public void SetAnimator()
{
     movementAnimation.runtimeAnimatorController = newController;
}
}
