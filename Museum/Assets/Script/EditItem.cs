using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EditItem : MonoBehaviour
{
    [SerializeField] TMP_InputField  _itemCount;
    [SerializeField] Image  _image;
    [SerializeField] TextMeshProUGUI _itemCost;
    [SerializeField] TextMeshProUGUI _totalCartCostText;
    int _unitPrice;
    int _units;
    int _oldCost=0;
    static int s_totalCartCost=0;

    public void PlusOnClick()
    {
        _units += 1;
        UpdateItemCount();
        UpdateTotalCost();
    }
    public void MinusOnClick()
    {
        if (_units > 1)
        {
            _units -= 1;
        }
        UpdateTotalCost();
        UpdateItemCount();
    }
    public void DeleteImage()
    {
        _units = 0;
        UpdateTotalCost();
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

    public void UpdateTotalCost()
    {
        int newCost = _units * _unitPrice;
        s_totalCartCost += newCost - _oldCost;
        _itemCost.SetText("Cost: " + newCost + "€");
        _totalCartCostText.SetText("Total Cost: " + s_totalCartCost.ToString() + "\u20AC");
        _oldCost = newCost;
    }

    public void UpdateItemCount()
    {
        _itemCount.text = _units.ToString();
    }

    public void addUnits(int units)
    {
        _units += units;
    }

    public void OnEditItemCount()
    {
        Debug.Log(_itemCount.text);
        int newCount = int.Parse(_itemCount.text);
        if (newCount < 1)
        {
            _units = 1;
            _itemCount.text = _units.ToString();
        }
        else
            _units = newCount;
        UpdateTotalCost();
    }
}
