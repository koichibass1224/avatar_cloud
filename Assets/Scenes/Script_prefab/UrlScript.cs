using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UrlScript : MonoBehaviour, IPointerClickHandler
{
    // public Text url;
    // [SerializeField] private Text url;
    [SerializeField] private string url;
    
    public void OnPointerClick(PointerEventData eventData)
    {
       url = "https://teratail.com/questions/89345";
        // Application.OpenURL("https://teratail.com/questions/89345");
        Application.OpenURL(url);
    }
}
