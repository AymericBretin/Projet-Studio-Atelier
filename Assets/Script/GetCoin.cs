using UnityEngine;
using TMPro;

public class GetCoin : MonoBehaviour
{
    StockValue saveScript;
    public TMP_Text CoinCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject saveObject = GameObject.Find("Save");
        saveScript = saveObject.GetComponent<StockValue>();
    }

    // Update is called once per frame
    void Update()
    {
        CoinCounter.SetText(saveScript.TotalCoin.ToString());
    }
}
