using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropzone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{
	
	public void OnPointerEnter(PointerEventData eventData){
		//Debug.Log("Entered"+ gameObject.name);
		if(eventData.pointerDrag == null)
		return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d !=null){
			d.placeholderParent = this.transform;
		}
	}

	public void OnPointerExit(PointerEventData eventData){
		//Debug.Log("Exited"+ gameObject.name);
		if(eventData.pointerDrag == null)
		return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d !=null){
			d.placeholderParent = d.parentToReturnTo;
		}
	}

	public void OnDrop(PointerEventData eventData){
		Debug.Log(eventData.pointerDrag.name + "Droped on"+ gameObject.name);

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if (d != null){
			d.parentToReturnTo = this.transform;
		}
	}
}

