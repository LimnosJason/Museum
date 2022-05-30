using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BuyItem : MonoBehaviour
{
    
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _plusButton;
    [SerializeField] GameObject _minusButton;
    [SerializeField] TMP_InputField  _itemCount;
    [SerializeField] TextMeshProUGUI _itemName;
    [SerializeField] TextMeshProUGUI _itemPrice;
    [SerializeField] GameObject _cartItemTemplate;
    [SerializeField] Transform _contentContainer;
    int _unitPrice;
    int _units = 1;

    public void EnableCanvas(){
        _canvas.SetActive(true);
    }
    public void PlusOnClick()
    {
        //var input = gameObject.GetComponent<InputField>();
        //Debug.Log(input.text);
        _units += 1;
        _itemCount.text= _units.ToString();
        UpdateTotalCost();
    }
    public void MinusOnClick()
    {
        if(_units > 1){
            _units -= 1;
        }
        UpdateTotalCost();
        _itemCount.text= _units.ToString();
    }

    public void setItemName(string newName)
    {
        _itemName.SetText(newName);
    }

    public void setItemPrice(int newPrice)
    {
        _unitPrice = newPrice;
        _units = 1;
        _itemCount.text = _units.ToString();
        _itemPrice.SetText("Total Cost: "+newPrice.ToString()+"€");
    }

    private void UpdateTotalCost()
    {
        _itemPrice.SetText("Total Cost: " + _units*_unitPrice + "€");
    }

    public void OnEndEdit()
    {
        _units=int.Parse(_itemCount.text);
        if (_units < 1) _units = 1;
        UpdateTotalCost();
    }

    public void dublicate()
    {
        var newItem = Instantiate(_cartItemTemplate);
        newItem.transform.SetParent(_contentContainer);
        newItem.transform.localScale = Vector2.one;
        newItem.transform.rotation = _cartItemTemplate.transform.rotation;
        newItem.SetActive(true);
        TextMeshProUGUI[] textArray = newItem.GetComponentsInChildren<TextMeshProUGUI>();
        TextMeshProUGUI itemName = textArray[0];
        TMP_InputField itemCount = newItem.GetComponentInChildren<TMP_InputField>();
        TextMeshProUGUI itemCost = textArray[5];
        itemName.text = _itemName.text;
        itemCount.text = _units.ToString();
        itemCost.text = "Cost: " + _units * _unitPrice + "€";
        EditItem editItem = newItem.GetComponentInChildren<EditItem>();
        editItem.setUnitPrice(_unitPrice);
        editItem.setUnits(_units);
        //Debug.Log(itemName.text);
        //Debug.Log(itemCount.text);
        //Debug.Log(itemCost.text);
    }

    public void AddToCart()
    {
        bool newItem = true;
        TextMeshProUGUI[] items = _contentContainer.GetComponentsInChildren<TextMeshProUGUI>();
        for (int i = 0; i < items.Length; i = i+ 6)
        {
            if(items[i].text == _itemName.text)
            {
                newItem = false;
                EditItem editItem = _contentContainer.GetChild(i / 6 +1).GetComponent<EditItem>();
                editItem.addUnits(_units);
                editItem.UpdateTotalCost();
                editItem.UpdateItemCount();
                break;
            }
        }
        if(newItem)
            dublicate();
        Time.timeScale = 1;
        _canvas.SetActive(false);
    }
}
