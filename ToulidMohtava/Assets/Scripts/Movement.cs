using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MoveRight()
    {
    	transform.position+=new Vector3(speed * Time.deltaTime , 0 , 0 );
    }
    public void MoveLeft()
    {
    	transform.localScale = -1 * transform.localScale;
    	transform.position+=new Vector3(-speed * Time.deltaTime , 0 , 0 );
    }
}
