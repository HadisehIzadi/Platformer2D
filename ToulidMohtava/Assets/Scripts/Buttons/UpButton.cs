using System;
using UnityEngine;
using UnityEngine.EventSystems;
public class UpButton : MonoBehaviour,IUpdateSelectedHandler,IPointerDownHandler,IPointerUpHandler
{
     public bool isPressed;
    public Movement player;
    
        // Start is called before the first frame update
        public void OnUpdateSelected(BaseEventData data)
        {
            if (isPressed)
            {
            	player.MoveUp();
            
            }
        }
        public void OnPointerDown(PointerEventData data)
        {
            isPressed = true;
            player.hasGravity = false;
            player.canAnimate = true;
        }
        public void OnPointerUp(PointerEventData data)
        {
            isPressed = false;
            player.hasGravity = true;
             player.canAnimate = false;
        }
}
