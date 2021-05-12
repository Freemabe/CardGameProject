using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//https://www.youtube.com/watch?v=AM7wBz9azyU
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	
	public Transform parentToReturnTo = null;
	public Transform placeholderParent = null;


	GameObject placeholder = null;

	public void OnBeginDrag(PointerEventData eventData){
		//Debug.Log("Starting to Drag"+ gameObject.name);
		

		placeholder = new GameObject();
		placeholder.transform.position = this.transform.position;
		placeholder.transform.parent = this.transform.parent;
		placeholder.transform.SetSiblingIndex ( this.transform.GetSiblingIndex() );
		LayoutElement le = placeholder.AddComponent<LayoutElement>();
		le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
		le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
		le.flexibleWidth = 0 ;
		le.flexibleHeight = 0 ;
		
		

		parentToReturnTo = this.transform.parent;
		placeholderParent = parentToReturnTo;
		this.transform.SetParent(this.transform.root);

		GetComponent<CanvasGroup>().blocksRaycasts= false;

		
	}

	public void OnDrag(PointerEventData eventData){
		//Debug.Log("Exited"+ gameObject.name);
		Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //Vector2 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = mousePos;

        if(placeholder.transform.parent != placeholderParent)
        	placeholder.transform.SetParent(placeholderParent);
        
		int newSiblingIndex = placeholderParent.childCount;

		for(int i=0; i<placeholderParent.childCount; i++){
			if(this.transform.position.x < placeholderParent.GetChild(i).position.x){

				newSiblingIndex = i;

				if(placeholder.transform.GetSiblingIndex()< newSiblingIndex){
					newSiblingIndex--;

				}
				break;
			}
		}
       
       placeholder.transform.SetSiblingIndex(newSiblingIndex);
	}

	public void OnEndDrag(PointerEventData eventData){
		//Debug.Log("Stopped Dragging"+ gameObject.name);
		this.transform.SetParent( parentToReturnTo);
		this.transform.SetSiblingIndex( placeholder.transform.GetSiblingIndex() );
		GetComponent<CanvasGroup>().blocksRaycasts = true;

		Destroy(placeholder);
	}
}

