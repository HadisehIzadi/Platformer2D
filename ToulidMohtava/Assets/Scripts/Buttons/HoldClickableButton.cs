

﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoldClickableButton :  MonoBehaviour,IUpdateSelectedHandler,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public Movement player;
    
        // Start is called before the first frame update
        public void OnUpdateSelected(BaseEventData data)
        {
            if (isPressed)
            {
            	player.MoveRight();
            
            }
        }
        public void OnPointerDown(PointerEventData data)
        {
            isPressed = true;
            player.canAnimate = true;
        }
        public void OnPointerUp(PointerEventData data)
        {
            isPressed = false;
            player.canAnimate = false;
        }
}
