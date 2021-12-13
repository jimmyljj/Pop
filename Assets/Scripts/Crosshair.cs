using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private static int width;
    private static int height;
    public Texture2D cursorAim;
   

    void Start()
    {
        //Cursor.SetCursor(cursorAim, new Vector2(Crosshair.width / 2, Crosshair.height / 2), CursorMode.Auto);
        Cursor.SetCursor(cursorAim, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update()
    {
        
    }
}
