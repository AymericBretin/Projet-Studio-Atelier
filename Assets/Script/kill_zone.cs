using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_area : MonoBehaviour
{
    public GameObject Check_point;
    public GameObject Player;
    public Animator deathScreen;
    public AudioSource deathSound;
    public PlayerMovement playerMovement;
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (deathScreen != null)
            {
                deathScreen.SetBool("Start", true);
                deathSound.Play();
                playerMovement.canMove = false;
            }
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.02f);
        if (deathScreen != null)
            deathScreen.SetBool("Start", false);
        Player.transform.position = new Vector3 (Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
        if (deathScreen != null)
        {
            yield return new WaitForSeconds(3);
            playerMovement.canMove = true;
        }
    }
}