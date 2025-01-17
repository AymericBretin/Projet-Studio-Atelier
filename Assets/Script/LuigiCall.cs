using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LuigiCall : MonoBehaviour
{
    public string scenename;
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Goto()
    {
        StartCoroutine(MyCoroutine());
    }

    public IEnumerator MyCoroutine() 
    {
        anim.SetBool("Start", true);
        yield return new WaitForSeconds(2.1f);
        SceneManager.LoadScene(scenename);
    }
}
