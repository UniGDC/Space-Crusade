using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorChange : MonoBehaviour
{
	public Texture2D cursorTexture;
	public Texture2D cursorTextureDown;
	public Vector2 hotSpot = Vector2.zero;
	public CursorMode cursorMode = CursorMode.Auto;
	// Start is called before the first frame update
	void Start()
    {
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		
    }
	

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButton("Fire1"))
		{
			Cursor.SetCursor(cursorTextureDown, hotSpot, cursorMode);
		}
		else {
			Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		}

	}
}
