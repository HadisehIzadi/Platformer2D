using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	[Header("Audios")]
	AudioSource audioSource;
	public AudioClip[] gameMusics;
	
	
	public static SoundManager instance;
	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
		
		audioSource = GetComponent<AudioSource>();
		
		
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void playWalkSound()
	{
		audioSource.PlayOneShot(gameMusics[0], 0.2f);
	}
    
    public void playScoreSound()
	{
		audioSource.PlayOneShot(gameMusics[1], 0.2f);
	}

    
    public void playGameOverSound()
	{
		audioSource.PlayOneShot(gameMusics[2], 0.2f);
	}
    
    
    public void PlayCatchSound()
    {
    	audioSource.PlayOneShot(gameMusics[3], 0.2f);
    }
    
    public void PlayAttackSound()
    {
    	audioSource.PlayOneShot(gameMusics[4], 0.2f);
    }
}
