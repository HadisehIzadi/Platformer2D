using System;
using UnityEngine;
using UnityEngine.EventSystems;
public class shootButton : MonoBehaviour,IUpdateSelectedHandler,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public BulletShooter bulletShooter;
    
        // Start is called before the first frame update
        public void OnUpdateSelected(BaseEventData data)
        {
            if (isPressed)
            {
            	bulletShooter.Shoot();
            
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
         //   player.canAnimate = false;
        }
}
