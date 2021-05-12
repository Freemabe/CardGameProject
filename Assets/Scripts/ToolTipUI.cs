using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ToolTipUI : MonoBehaviour
{
	public static ToolTipUI Instance {get; private set;}
	[SerializeField]
	private RectTransform canvasRectTransform;
	[SerializeField]
	private TextMeshProUGUI textMeshPro;
	[SerializeField]
	private RectTransform backgroundRectTransform;

	private RectTransform rectTransform;
	

	private void Awake()
	{	Instance = this;
		rectTransform = transform.GetComponent<RectTransform>();

		HideTooltip();
	}
	private void Update()
	{
		Vector2 anchoredPosition = Input.mousePosition / canvasRectTransform.localScale.x;

      if(anchoredPosition.x + backgroundRectTransform.rect.width > canvasRectTransform.rect.width)
      {
         anchoredPosition.x = canvasRectTransform.rect.width - backgroundRectTransform.rect.width;
      }
      if(anchoredPosition.y + backgroundRectTransform.rect.height > canvasRectTransform.rect.height)
      {
         anchoredPosition.y = canvasRectTransform.rect.height - backgroundRectTransform.rect.height;
      }
      if(anchoredPosition.x< 0)
      {
         anchoredPosition.x = 0;
      }
      if(anchoredPosition.y < 0)
      {
         anchoredPosition.y = 0;
      }

      rectTransform.anchoredPosition = anchoredPosition;

	}
   	private void SetText(string tooltipText)
   	{
   		textMeshPro.SetText(tooltipText);
   		textMeshPro.ForceMeshUpdate();

   		Vector2 textSize = textMeshPro.GetRenderedValues(false);
   		Vector2 paddingSize = new Vector2(8,0);
   		backgroundRectTransform.sizeDelta = textSize + paddingSize;
   	}

   	private void ShowTooltip(string tooltipText)
   	{
   		gameObject.SetActive(true);
   		SetText(tooltipText);
   	}

   	private void HideTooltip()
   	{
   		gameObject.SetActive(false);
   	}

   	public static void ShowTooltip_Static(string tooltipText)
   	{
   		Instance.ShowTooltip(tooltipText);
   	}

   	public static void HideTooltip_Static()
   	{
   		Instance.HideTooltip();
   	}
}
