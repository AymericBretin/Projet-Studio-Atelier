using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class End_Level : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement playerMovement;
    public Animator swap;

    public Coin coin;
    StockValue saveScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject saveObject = GameObject.Find("Save");
        saveScript = saveObject.GetComponent<StockValue>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            saveScript.TotalCoin += coin.nb_coin;
            playerMovement.canMove = false;g
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.zero;
            anim.SetBool("Victory", true);
            StartCoroutine(MyCoroutine());
        }
    }

    public IEnumerator MyCoroutine() 
    {
        yield return new WaitForSeconds(1);
        swap.SetBool("Start", true);
    }
}
