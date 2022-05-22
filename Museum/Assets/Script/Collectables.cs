using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CollectablesText;
    [SerializeField] GameObject CollectButton;
    [SerializeField] GameObject CollectableImage;
    [SerializeField] GameObject Count;
    void Awake(){
        CollectButton.SetActive(false);
    }
    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.C)){
                Destroy(CollectableImage);
                int childs = 5-(getChildren(Count)-2)/2;
                CollectablesText.text="Images : "+ childs +"/5";
                CollectButton.SetActive(false);
            }
        }   
    }
    void OnTriggerExit(Collider other)
    {
        CollectButton.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        CollectButton.SetActive(true);
    }

    public int getChildren(GameObject obj)
    {
        int count = 0;

        for (int i = 0; i < obj.transform.childCount; i++)
        {
            count++;
            counter(obj.transform.GetChild(i).gameObject, ref count);
        }
        return count;
    }

    private void counter(GameObject currentObj, ref int count)
    {
        for (int i = 0; i < currentObj.transform.childCount; i++)
        {
            count++;
            counter(currentObj.transform.GetChild(i).gameObject, ref count);
        }
    }
}
