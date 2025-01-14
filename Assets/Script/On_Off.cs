using UnityEngine;

public class On_Off : MonoBehaviour
{
    public bool On_Off_Bool = false;
    public Sprite[] On;

    public SpriteRenderer spriteRenderer;
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
        if (other.gameObject.tag == "Player" && On_Off_Bool == false)
        {
            spriteRenderer.sprite = On[1];
            On_Off_Bool = true;
            return;
        }

        if (other.gameObject.tag == "Player" && On_Off_Bool == true)
        {
            spriteRenderer.sprite = On[0];
            On_Off_Bool = false;
            return;
        }
    }
}
