using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class type_writer_lvl_2 : MonoBehaviour
{
    public string[] tab;
    string text;
    public bool lang = true;
    TMP_Text uiText;
    public float delai = 0.2f;
    AudioSource audio;
    public Show_button_for_choice_scene show_button_for_choice_scene;

    void Awake()
    {
        GameObject saveObject = GameObject.Find("Save");
        StockValue saveScript = saveObject.GetComponent<StockValue>();
        lang = saveScript.Lang;
        audio = GetComponent<AudioSource>();
        uiText = GetComponent<TMP_Text>();
        if (lang == true)
            text = tab[0];
        if (lang == false)
            text = tab[1];
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
