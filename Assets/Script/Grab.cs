using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool canHold = false;
    public bool Hold = false;
    public Animator anim;
    public GameObject childObject;
    public GameObject parentObject;
    public float throwForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Grab") && Hold == false && canHold == true)
        {
            Hold = true;
            anim.SetBool("Hold", true);
            GrabBox();
            return;
        }
        if (Input.GetButtonDown("Grab") && Hold == true)
        {
            Hold = false;
            anim.SetBool("Hold", false);
            ThrowBox();
            return;
        }
    }

    public void GrabBox()
    {
        if (childObject != null)
        {
            childObject.transform.SetParent(parentObject.transform);
            childObject.transform.localPosition = new Vector3(0, 0.7f, 0);
            Rigidbody2D rb = childObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.simulated = false;
            }
        }
    }

    public void ThrowBox()
    {
        if (childObject != null)
        {
            childObject.transform.SetParent(null);

            Rigidbody2D rb = childObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.simulated = true;

                float direction = Mathf.Sign(parentObject.transform.localScale.x);
                Vector2 throwDirection = new Vector2(direction, 0.5f).normalized;
                rb.AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
            }

            childObject = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box" && Hold == false)
        {
            childObject = other.gameObject;
            canHold = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            canHold = false;
        }
    }
}
