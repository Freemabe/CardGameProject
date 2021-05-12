using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeTabScript : MonoBehaviour
{
   public GameObject cardGalleryFrame;
   public GameObject activeFrame;

   public void OnClick()
   {
   		cardGalleryFrame.GetComponent<GalleryFrameController>().SwitchActiveFrame(activeFrame);
   }

}
