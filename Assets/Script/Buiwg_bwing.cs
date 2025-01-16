using System.Collections;
using UnityEngine;

public class Buiwg_bwing : MonoBehaviour
{
    public float throwForce = 10f;
    private bool canJump = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canJump)
        {
            canJump = false;
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                StartCoroutine(ApplyBounce(rb));
            }
        }
    }

    private IEnumerator ApplyBounce(Rigidbody2D rb)
    {
        transform.localScale = new Vector3(1.5f, 1.2f, 1.5f);
        Vector2 throwDirection = Vector2.up;
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.5f);
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        canJump = true;
    }
}
