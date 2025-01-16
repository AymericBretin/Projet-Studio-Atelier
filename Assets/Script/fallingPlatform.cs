using UnityEngine;
using System.Collections;

public class fallingPlatform : MonoBehaviour
{
    private float falling = 0.01f;
    private float destroy = 2f;

    [SerializeField] private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            StartCoroutine(Fall());
    }

    // Update is called once per frame
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(falling);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroy);
    }
}
