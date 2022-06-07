using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pay : MonoBehaviour
{
    [SerializeField] TMP_InputField _cardNumber;
    [SerializeField] TMP_InputField _nameOnCard;
    [SerializeField] TMP_InputField _year;
    [SerializeField] TMP_InputField _securityCode;
    [SerializeField] TMP_Dropdown _month;
    [SerializeField] GameObject _canvasCard;
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _error;
    [SerializeField] GameObject _error1;
    [SerializeField] GameObject _error2;
    [SerializeField] GameObject _error3;
    [SerializeField] Transform _contentContainer;
    public void pay()
    {
        bool valid = true;

        if (_cardNumber.text.Length < 1)
        {
            valid = false;
            _error.SetActive(true);
        } else _error.SetActive(false);

        if (_nameOnCard.text.Length < 1)
        {
            valid = false;
            _error1.SetActive(true);
        }
        else _error1.SetActive(false);

        if (_year.text.Length < 1)
        {
            valid = false;
            _error2.SetActive(true);
        }
        else _error2.SetActive(false);

        if (_securityCode.text.Length < 1)
        {
            valid = false;
            _error3.SetActive(true);
        }
        else _error3.SetActive(false);


        if (valid) 
        { 
            EditItem editItem = _contentContainer.GetComponentInChildren<EditItem>();
            //_contentContainer.DetachChildren(); //bug: detaches template item
            EditItem.s_totalCartCost = 0;
            editItem.UpdateTotalCost();
            //Debug.Log(_contentContainer.transform.childCount);
            for (int i = 1; i < _contentContainer.transform.childCount; i++)
            {
                //Debug.Log("Destroying: "+_contentContainer.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text);
                Destroy(_contentContainer.GetChild(i).gameObject);

            }
        }

        _canvasCard.SetActive(!valid);
        _canvas.SetActive(valid);
    }
}
