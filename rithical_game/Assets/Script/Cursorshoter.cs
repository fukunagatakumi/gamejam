using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursorshoter : MonoBehaviour
{
    public Texture2D cursor;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 hotspot = cursor.texelSize * 0.5f;
        Cursor.SetCursor(cursor, hotspot,CursorMode.ForceSoftware);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
