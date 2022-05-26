using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShoppingCart : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasCart;
    [SerializeField] GameObject _plusButton;
    [SerializeField] GameObject _minusButton;
    [SerializeField] TMP_InputField  _itemCount;

    public void CancelOnClick()
    {
        _canvas.SetActive(true);
        _canvasCart.SetActive(false);
    }

    public void PlusOnClick()
    {
        //var input = gameObject.GetComponent<InputField>();
        //Debug.Log(input.text);
        int numberOfItems =  int.Parse(_itemCount.GetComponent<TMP_InputField>().text);
        Debug.Log(numberOfItems);
         numberOfItems+=1;
        Debug.Log(numberOfItems);
        _itemCount.GetComponent<TMP_InputField>().text=numberOfItems.ToString();
    }
}
