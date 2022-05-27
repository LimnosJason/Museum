using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnEditEndCardInfo : MonoBehaviour
{
    [SerializeField] GameObject _error;
    [SerializeField] TMP_InputField _inputField;
    public void OnEditEnd()
    {
        _error.SetActive(_inputField.text.Length < 1);
    }
}
