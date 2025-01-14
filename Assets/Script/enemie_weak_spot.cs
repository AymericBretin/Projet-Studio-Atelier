using UnityEngine;

public class enemie_weak_spot : MonoBehaviour
{
    public GameObject Enemie;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Destroy (Enemie);
        }
    }
}
