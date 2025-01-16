using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hide_phone_boutton : MonoBehaviour
{
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        StartCoroutine(ring());
    }

    IEnumerator ring()
    {
        yield return new WaitForSeconds(3.0f);
        audio.Play();
        StartCoroutine(ring());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hide_boutton()
    {
        gameObject.SetActive(false);
        audio.Stop();
    }
}
