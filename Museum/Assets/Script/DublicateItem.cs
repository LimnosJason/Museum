using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DublicateItem : MonoBehaviour
{

    [SerializeField] GameObject _item;
    [SerializeField] Transform m_ContentContainer;

    public void dublicate()
    {
        var newItem = Instantiate(_item);
        newItem.transform.SetParent(m_ContentContainer);
        newItem.transform.localScale = Vector2.one;
    }
}
