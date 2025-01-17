using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource Sound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Start_Audio()
    {
        Sound.Play();
    }

    public void Stop_Audio()
    {
        Sound.Stop();
    }
}
