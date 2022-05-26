using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChangeCanvas : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasNew;

    public void CancelOnClick()
    {
        _canvas.SetActive(true);
        _canvasNew.SetActive(false);
    }

}
