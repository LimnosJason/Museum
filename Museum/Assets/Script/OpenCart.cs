using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCart : MonoBehaviour
{
    [SerializeField] GameObject _cartButton;
    [SerializeField] GameObject _helpButton;
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasCart;

    public void CartOnClick()
    {
        _canvas.SetActive(false);
        _canvasCart.SetActive(true);
    }

    public void HelpOnClick()
    {
        //TODO insert help button onClick action
    }
}
