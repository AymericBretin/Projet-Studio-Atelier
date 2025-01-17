using UnityEngine;

public class StockValue : MonoBehaviour
{
    public bool Lang = false;
    public int TotalCoin = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lang = true;
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
