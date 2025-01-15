using UnityEngine;

public class ChangeSprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite sprite;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        spriteRenderer.sprite = sprite;
    }
}
