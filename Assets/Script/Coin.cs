using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    public int nb_coin = 0;
    public int Time = 0;
    public TMP_Text CoinCounter;

    void Update()
    {
        CoinCounter.SetText(nb_coin.ToString());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin"  && Time == 0) {
            Time = 1;
            nb_coin += 1;
            Destroy(other.gameObject);
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);
        Time = 0;
    }
}