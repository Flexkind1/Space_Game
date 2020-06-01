using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextInteraktion : MonoBehaviour
{
    // fragt ab ob button gedrückt ist oder nicht 
    private bool showText = false;

    //Wenn die rechte Mousetaste gedrückt wurde, 
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
           
           
        }


    }

    void OnGUI()
    {
        if (showText)
        {
            if(GUI.Button(new Rect(300,50,100,20), "Text"))
                showText = false;
        }
    }
}
