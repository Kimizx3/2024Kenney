using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] public Texture2D CursorTexture;
    [SerializeField] public Texture2D HoverTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    void Start()
    {
        // Setup Mouse Visibility
        DefaultCursorSetup();
    }
    
    void Update()
    {
        // Update Mouse Detection if hit collider
        
        // Double Click to Open Files
        
    }

    public void DefaultCursorSetup()
    {
        Vector2 HotSpot = new Vector2(CursorTexture.width / 4, CursorTexture.height / 4);
        Cursor.SetCursor(CursorTexture,HotSpot,cursorMode);
    }
    
    public void HoverCursorSetup()
    {
        Vector2 HotSpot = new Vector2(CursorTexture.width / 4, CursorTexture.height / 4);
        Cursor.SetCursor(HoverTexture,HotSpot,cursorMode);
    }

    
}
