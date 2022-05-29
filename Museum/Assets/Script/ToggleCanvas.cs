using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    [SerializeField] GameObject _canvasOld;
    [SerializeField] GameObject _canvasNew;
    public void OpenNewCanvas(){
        _canvasOld.SetActive(false);
        _canvasNew.SetActive(true);
    }
}
