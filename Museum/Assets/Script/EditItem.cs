using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EditItem : MonoBehaviour
{
    
    [SerializeField] GameObject _plusButton;
    [SerializeField] GameObject _minusButton;
    [SerializeField] TMP_InputField  _itemCount;
    [SerializeField] GameObject  _deleteButton;
    [SerializeField] Image  _image;
    [SerializeField] TextMeshProUGUI _itemName;
    [SerializeField] TextMeshProUGUI _itemCost;
    int _unitPrice;
    int _units;

    public void PlusOnClick()
    {
        _units += 1;
        _itemCount.text = _units.ToString();
        UpdateTotalCost();
    }
    public void MinusOnClick()
    {
        if (_units > 1)
        {
            _units -= 1;
        }
        UpdateTotalCost();
        _itemCount.text = _units.ToString();
    }
    public void DeleteImage()
    {
        Destroy(_image.gameObject);
    }
    
    public void BuyItems()
    {
        
    }

    public void setUnitPrice(int unitPrice)
    {
        _unitPrice = unitPrice;
    }

    public void setUnits(int units)
    {
        _units = units;
    }

    private void UpdateTotalCost()
    {
        _itemCost.SetText("Cost: " + _units * _unitPrice + "€");
    }
}
