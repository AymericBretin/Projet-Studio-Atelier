using UnityEngine;

public class StartAnim : MonoBehaviour
{
    public Animator anim;
    public string Name;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop()
    {
        anim.SetBool(Name, true);
        Debug.Log("Start Animation");
    }
}
