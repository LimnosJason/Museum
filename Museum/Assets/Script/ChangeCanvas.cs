using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvas : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _canvasNew;
    void Update(){
        PauseGame();
        if(Input.GetKeyDown(KeyCode.Escape)){
            CancelOnClick();
        }
    }
    void PauseGame(){
        Time.timeScale = 0;
    }      
    void ResumeGame(){
        Time.timeScale = 1;
    }
    void Awake(){
        CancelOnClick();
    }

    public void CancelOnClick()
    {
        ResumeGame();
        _canvas.SetActive(true);
        _canvasNew.SetActive(false);
    }

}
