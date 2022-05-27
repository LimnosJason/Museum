using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InspectItem : MonoBehaviour
{
    
    [SerializeField] GameObject _canvas;

    [SerializeField] GameObject itemDescription;
    [SerializeField] TextMeshProUGUI mainText;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            DisableCanvas();
        }
    }    
    void Awake(){
        DisableCanvas();
    }

    public void EnableCanvas(){
        _canvas.SetActive(true);
        //Debug.Log(itemDescription);
    }
    public void DisableCanvas(){
        _canvas.SetActive(false);
    }

    public void GetText (GameObject textItem){
   //     itemDescription.GetComponent<UnityEngine.UI.Text>().text = textItem.GetComponent<UnityEngine.UI.Text>().text;
        //itemDescription.GetComponent<UnityEngine.UI.Text>().text = "OK";
        if(textItem.name.Contains("TMP"))
            mainText.text = textItem.GetComponent<TextMeshProUGUI>().text;
        else
            mainText.text = textItem.GetComponent<UnityEngine.UI.Text>().text;

    }
}
