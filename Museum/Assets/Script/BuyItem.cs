using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BuyItem : MonoBehaviour
{
    
    [SerializeField] GameObject _plusButton;
    [SerializeField] GameObject _minusButton;
    [SerializeField] TMP_InputField  _itemCount;

    public void PlusOnClick()
    {
        //var input = gameObject.GetComponent<InputField>();
        //Debug.Log(input.text);
        int numberOfItems =  int.Parse(_itemCount.GetComponent<TMP_InputField>().text);
        numberOfItems+=1;
        _itemCount.GetComponent<TMP_InputField>().text=numberOfItems.ToString();
    }
    public void MinusOnClick()
    {
        int numberOfItems =  int.Parse(_itemCount.GetComponent<TMP_InputField>().text);
        if(numberOfItems>1){
            numberOfItems-=1;
        }
        _itemCount.GetComponent<TMP_InputField>().text=numberOfItems.ToString();
    }
}
