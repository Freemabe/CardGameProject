using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLine : MonoBehaviour
{	

	Vector3 startPosition;
	public LineRenderer line;
	public bool enable = false;


	public void Update()
	{

		if (enable)
		{
				
			Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			startPosition = new Vector3(Camera.main.ScreenToWorldPoint(mousePos).x,Camera.main.ScreenToWorldPoint(mousePos).y,-1);
			line.SetPosition(1,startPosition);
			
			line.positionCount = 2;
			if (Input.GetMouseButtonDown(0)){
				enable=false;
				Destroy(line);	
			}
		}
		

	}

	public void OnClick(){

		if(line == null)
			{
				line = gameObject.AddComponent<LineRenderer>();
			}
		
		enable = true;
		line.SetPosition(0,this.transform.position + new Vector3 (0 ,0, -1));
		Update();
	}
}
