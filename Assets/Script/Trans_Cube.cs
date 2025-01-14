using UnityEngine;

public class Trans_Cube : MonoBehaviour
{
    public On_Off on_Off;
    public Sprite[] Trans;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D box;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        box = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (on_Off.On_Off_Bool == true) {
            spriteRenderer.sprite = Trans[1];
            box.isTrigger = false;
            return;
        }
        if (on_Off.On_Off_Bool == false) {
            spriteRenderer.sprite = Trans[0];
            box.isTrigger = true;
            return;
        }
    }
}
