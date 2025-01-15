using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_area : MonoBehaviour
{
    public GameObject Check_point;
    public GameObject Player;
    public Animator deathScreen;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            deathScreen.SetBool("Start", true);
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.02f);
        deathScreen.SetBool("Start", false);
        Player.transform.position = new Vector3 (Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
    }
}