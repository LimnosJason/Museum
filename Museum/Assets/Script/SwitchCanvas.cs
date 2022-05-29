using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCanvas : MonoBehaviour
{
    [SerializeField] GameObject _cartButton;
    [SerializeField] GameObject _helpButton;
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasCart;
    [SerializeField] GameObject _canvasHelp;
   void Update(){
        if(Input.GetKeyDown(KeyCode.H)){
            HelpOnClick();
        }
        if(Input.GetKeyDown(KeyCode.K)){
            CartOnClick();
        }
    } 
    public void CartOnClick()
    {
        _canvas.SetActive(false);
        _canvasCart.SetActive(true);
    }

    public void HelpOnClick()
    {
        _canvas.SetActive(false);
        _canvasHelp.SetActive(true);
    }
}
