using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Type_writer : MonoBehaviour
{
    string text;
    public bool lang = true;
    TMP_Text uiText;
    public float delai = 0.05f;
    AudioSource audio;
    public Show_button_for_choice_scene show_button_for_choice_scene;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
        uiText = GetComponent<TMP_Text>();
        text = uiText.text;
        if (lang == true)
            text = "Je relie deux rives et traverse l’eau, mon nom évoque le métal utilisé pour me construire. Où dois-tu aller pour poursuivre ton aventure ?";
        if (lang == false)
            text = "I link two shores and cross the water, my name evokes the metal used to build me. Where must you go to continue your adventure ?";
        uiText.text = null;
    }

    public void call()
    {
        StartCoroutine(wait_start_call());
    }

    IEnumerator wait_start_call()
    {
        yield return new WaitForSeconds(0.5f);
        audio.Play();
        StartCoroutine(showLetter());
    }
    
    IEnumerator showLetter()
    {
        for (int i = 0; i <= text.Length; i++) {
            uiText.text = text.Substring(0, i);
            if (i == text.Length) {
                show_button_for_choice_scene.show_button();
                audio.Stop();
            }
            yield return new WaitForSeconds(delai);
        }
    }
}
