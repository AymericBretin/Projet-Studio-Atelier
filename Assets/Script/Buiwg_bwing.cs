using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buiwg_bwing : MonoBehaviour
{
    public GameObject childObject;
    public float throwForce = 10f;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Box")
        {
            Debug.Log("test");
            childObject = other.gameObject;
            rb = childObject.GetComponent<Rigidbody2D>();
            StartCoroutine(MyCoroutine());
            float direction = Mathf.Sign(childObject.transform.localScale.x);
            Vector2 throwDirection = new Vector2(direction, 0.5f).normalized;
            rb.AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
        }
    }

    public IEnumerator MyCoroutine() {  
        gameObject.transform.localScale = new Vector3(1.5f, 1.2f, 1.5f);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
