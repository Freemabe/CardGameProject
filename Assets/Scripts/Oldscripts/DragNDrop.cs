using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
	private bool isDragging = false;
	private bool isOverDropZone = false;

	private GameObject dropZone;
	private GameObject startParent;
	public GameObject Canvas;

	private Vector2 startPosition;

	private void Awake()
	{
		Canvas = GameObject.Find("Main Canvas");
	}
    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
        	Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        	Vector2 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        	transform.position = playerPos;
        	transform.SetParent(Canvas.transform, true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    	isOverDropZone = true;
    	dropZone = collision.gameObject;
    	Debug.Log("collision start");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
    	isOverDropZone = false;
    	dropZone = null;
    	Debug.Log("collision end");
    }

    public void StartDrag()
    {
    	startParent = transform.parent.gameObject;
    	startPosition = transform.position;
    	isDragging = true;
    }

    public void EndDrag()
    {
    	isDragging = false;
    	if (isOverDropZone)
    	{
    		transform.SetParent(dropZone.transform, false);
    	}
    	else
    	{
    		transform.SetParent(startParent.transform, false);
    		transform.position = startPosition;
    	}
    }

}	

