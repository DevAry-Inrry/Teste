using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    //to do: make InputHandler Singleton Class
    //public static InputHandler handler { get; private set; }
    public bool inInteraction { get; private set; }
    
    void Update()
    {
        inInteraction = OnTouchScreen() || OnMouseClick();
    }

    //retorna verdadeiro sempre que o número de toques na tela for maior que 0
    bool OnTouchScreen()
    {
        return Input.touchCount > 0;
    }

    bool OnMouseClick()
    {
        return Input.GetMouseButtonDown(0);
    }
}
