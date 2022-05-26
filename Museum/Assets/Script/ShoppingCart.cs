using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingCart : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasCart;
    [SerializeField] GameObject _plusButton;
    [SerializeField] GameObject _minusButton;
    [SerializeField] GameObject _itemCount;

    public void CancelOnClick()
    {
        _canvas.SetActive(true);
        _canvasCart.SetActive(false);
    }

    public void PlusOnClick()
    {
        var input = gameObject.GetComponent<InputField>();
        Debug.Log(input.text);
    }
}
