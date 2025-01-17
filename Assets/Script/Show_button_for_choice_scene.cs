
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_button_for_choice_scene : MonoBehaviour
{
    public GameObject bt1;
    public GameObject bt2;
    public GameObject bt3;

    public GameObject bt4;
    StockValue saveScript;

    void Start()
    {
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.2f);
        bt1.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        bt2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        bt3.SetActive(true);
    }

    public void show_button()
    {
        StartCoroutine(wait());
    }

    public void soluce()
    {
        GameObject saveObject = GameObject.Find("Save");
        saveScript = saveObject.GetComponent<StockValue>();
        if (saveScript.TotalCoin >= 10) {
            saveScript.TotalCoin -= 10;
            bt4.SetActive(false);
        }
    }
}
