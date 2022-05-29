using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvas : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasNew;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            DisableCanvas();
        }
    }       
    void Awake(){
        DisableCanvas();
    }

    public void DisableCanvas(){
        _canvasNew.SetActive(false);
        _canvas.SetActive(true);
    }
    public void CancelOnClick()
    {
        _canvas.SetActive(true);
        _canvasNew.SetActive(false);
    }

}
