using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadDeath : MonoBehaviour
{
    public string SceneName;
    public Animator deathScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            deathScreen.SetBool("Start", true);
            StartCoroutine(PerformAddingWithIntervale());
        }
    }

    IEnumerator PerformAddingWithIntervale()
    {
        yield return new WaitForSeconds( 5 );
        SceneManager.LoadScene(SceneName);
    }
}
