using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Movement : MonoBehaviour
{
	public float speed;
	public float jumpSpeed;
	public float shib;
	public Animator movementAnimation;
	
	public bool canAnimate = false;
	public bool hasGravity = true;
	private bool isMovingRight = false;
	private bool isMovingLeft = false;
	public bool canJump = true;
	private bool isGrounded = false;
  
	
	public Rigidbody2D rb;
	public RuntimeAnimatorController newController;
	 public RuntimeAnimatorController walkController;
	public GameObject hand_RightButton;
	public GameObject hand_GunButton;
	public GameObject hint1;
	 
	public TMP_Text coins;
	 
	public int score = 0;
	 
	public GameObject DiePanel;
	// Start is called before the first frame update
	void Start()
	{
		//movementAnimation.enabled = false;
		rb = this.GetComponent<Rigidbody2D>();
		Time.timeScale = 1f;
	}

	// Update is called once per frame
	void Update()
	{
		coins.text = PlayerPrefs.GetInt("score" , 0).ToString();
		
		transform.rotation = Quaternion.Euler(0, 0, 0);
    	
//		if (canAnimate == false)
//			movementAnimation.enabled = false;
//		else
//			movementAnimation.enabled = true;
    	
		if (transform.position.y > 10)
			canJump = false;
		else
			canJump = true;
    	
    	
		if (transform.position.y <= -10f)
			Die();
    	
    	

    	
	}
    
    
    
    
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Obstacle")
			Debug.Log("OnCollisionEnter2D");
    	
		if (col.gameObject.tag == "Ground")
			isGrounded = true;
    	
		if (col.gameObject.tag == "Juwley") {
			score++;
			PlayerPrefs.SetInt("score" , score);
			Debug.Log("Score : " + score);
			Destroy(col.gameObject, 0.05f);
			
			;
		}
	}
    
    
    
    
    
	public void MoveRight()
	{
		canAnimate = true;
		//movementAnimation.enabled = true;
		movementAnimation.runtimeAnimatorController = walkController;
		PlayerPrefs.SetInt("FisrtTouchRightButton", 1);
		hand_GunButton.SetActive(true);
		hand_RightButton.SetActive(false);
		hint1.SetActive(false);
		transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    	
		isMovingRight = true;
		isMovingLeft = false;

    	
		if (transform.localScale.x < 0) {
			var newScale = new Vector3(
				              transform.localScale.x * -1f,
				              transform.localScale.y,
				              transform.localScale.z);


			transform.localScale = newScale;
		}
	}
    
    
    
	public void MoveLeft()
	{
		canAnimate = true;
		transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
		movementAnimation.runtimeAnimatorController = walkController;

		isMovingLeft = true;
		isMovingRight = false;
        
        
		if (transform.localScale.x > 0) {
			var newScale = new Vector3(
				              transform.localScale.x * -1f,
				              transform.localScale.y,
				              transform.localScale.z);


			transform.localScale = newScale;
		}
	}
    
    
    


//	public void MoveUp()
//	{
//		canAnimate = true;
//
//
//		float smoothJump = Mathf.Lerp(rb.velocity.y, jumpSpeed, shib);
//		float directionX = 0f;
//
//
//		if (isMovingRight) {
//			directionX = speed * 0.3f;       
//		} else if (isMovingLeft) {
//			directionX = -speed * 0.3f;
//
//		}
//
//
//		Vector3 direction = new Vector3(directionX, (smoothJump * Time.deltaTime) + smoothJump * 1.2f, 0);
//		rb.velocity = direction;
//
//		if (canJump == false)
//			return;
//		
		
	


public void MoveUp()
{
    // اگر پلیر نمی‌تواند بپرد، تابع خروج کند
    if (!canJump || !isGrounded)
        return;

    // جلوگیری از پرش مجدد
    canJump = false;
    isGrounded = false;

    // تعیین سرعت پرش
    float directionX = 0f;

    if (isMovingRight)
    {
        directionX = speed * 0.3f;
    }
    else if (isMovingLeft)
    {
        directionX = -speed * 0.3f;
    }

    // تنظیم سرعت پرش
    Vector2 jumpVelocity = new Vector2(directionX, jumpSpeed);
    rb.velocity = jumpVelocity*shib;

    // اجازه دوباره برای پرش بعد از برخورد به زمین
    Invoke("EnableJump", 0.5f);
}



private void EnableJump()
{
    canJump = true; // فعال کردن دوباره پرش
}
    
    
    
    

	public void SetAnimator()
	{
		movementAnimation.runtimeAnimatorController = newController;
	}



	void Die()
	{
		Time.timeScale = 0f;
		DiePanel.SetActive(true);
		Debug.Log("Player died");
	}
}
