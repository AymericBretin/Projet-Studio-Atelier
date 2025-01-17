using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BossDamage : MonoBehaviour
{
    public Boss boss;
    public bool canDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canDamage = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (canDamage == true && other.gameObject.tag == "Box") {
            boss.BossDamage();
            Destroy(other.gameObject);
            StartCoroutine(MyCoroutine());
        }
    }

    public IEnumerator MyCoroutine() 
    {
        canDamage = false;
        yield return new WaitForSeconds(0.5f);
        canDamage = true;
    }
}
