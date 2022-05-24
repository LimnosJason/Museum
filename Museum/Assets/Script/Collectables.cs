using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CollectablesText;
    [SerializeField] TextMeshProUGUI BananaSummonText;

    [SerializeField] GameObject CollectButton;
    [SerializeField] GameObject CollectableImage;
    [SerializeField] GameObject Count;

    [SerializeField] AudioSource collectionSound;
    [SerializeField] AudioSource BananaSummonSound;

    [SerializeField] GameObject BananaMan;
    
    bool flag=false;
    bool collect=false;
    void Awake(){
        CollectButton.SetActive(false);
        BananaSummonText.enabled = false;
    }
    public void ClickedCollect(){
        if(flag){
            collect=true;
        }
    }
    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.C)||collect){
                Destroy(CollectableImage);
                collectionSound.Play();
                int childs = 5-(getChildren(Count)-2)/2;
                CollectablesText.text="Tickets : "+ childs +"/5";
                if(childs==5){
                    BananaMan.SetActive(true);
                    BananaSummonSound.Play();
                    BananaSummonText.enabled = true;
                    Destroy(BananaSummonText, 4);
                }
                CollectButton.SetActive(false);
            }
        }   
    }

    void OnTriggerExit(Collider other)
    {
        flag=false;
        CollectButton.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        flag=true;
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
