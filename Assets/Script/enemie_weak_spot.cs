using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemie_weak_spot : MonoBehaviour
{
    public GameObject Enemie;
    public Animator anim;
    public BoxCollider2D box;
    public bool dead = false;
    public float throwForce = 10f;
    public bool jump = true;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && jump == true)
        {
            jump = false;
            box.enabled = false;
            dead = true;
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            Vector2 throwDirection = new Vector2(0, 0.5f).normalized;
            rb.AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
            StartCoroutine(MyCoroutine());
        }
    }

    public IEnumerator MyCoroutine() {
        anim.SetBool("Dead", true);
        yield return new WaitForSeconds(0.5f);
        GameObject.Destroy (Enemie);
    }
}
