using System;
using UnityEngine;
using UnityEngine.EventSystems;
public class shootButton : MonoBehaviour,IUpdateSelectedHandler,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public BulletShooter bulletShooter;
    public SoundManager soundManaer;
    
        // Start is called before the first frame update
        public void OnUpdateSelected(BaseEventData data)
        {
            if (isPressed)
            {
            	bulletShooter.StartCoroutine("Shoot");
            
            }
        }
        public void OnPointerDown(PointerEventData data)
        {
            isPressed = true;
           // player.canAnimate = true;
        }
        public void OnPointerUp(PointerEventData data)
        {
            isPressed = false;
            soundManaer.PlayAttackSound();
         //   player.canAnimate = false;
        }
}
