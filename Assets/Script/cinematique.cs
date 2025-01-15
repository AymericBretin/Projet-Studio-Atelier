using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cinematique : MonoBehaviour
{
    public Animator Mario_Move;
    public Animator Mario_Anim;
    public Animator Vortex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cinematique_Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cinematique_Start()
    {
        Mario_Move.SetBool("Start", true);
        Mario_Anim.SetBool("Start", true);
        StartCoroutine(MyCoroutine());
    }

    public IEnumerator MyCoroutine() 
    {  
        yield return new WaitForSeconds(3);
        Vortex.SetBool("Start", true);
        yield return new WaitForSeconds(3);
        Mario_Anim.SetBool("Chokbar", true);
        yield return new WaitForSeconds(7);
        Mario_Anim.SetBool("Idle", true);
        Mario_Move.SetBool("Chockbar", true);
    }
}
