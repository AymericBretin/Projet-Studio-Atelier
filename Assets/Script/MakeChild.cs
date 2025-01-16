using UnityEngine;

public class MakeChild : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.transform.SetParent(this.transform);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
       other.transform.SetParent(null);
    }
}
