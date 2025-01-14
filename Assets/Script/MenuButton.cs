using UnityEngine;
using TMPro;

public class MenuButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Sprite[] sprite;
    public SpriteRenderer btnNew;
    public SpriteRenderer btnSett;
    public SpriteRenderer btnExit;
    public bool french;
    public bool english;
    public string frenchWords = "Fermer";
    public string englishWords = "Close";
    public TMP_Text settingString;
    public string frenchSound = "Musique";
    public string englishSound = "Music";
    public TMP_Text SoundString;

    void Start()
    {
        
    }

    public void French()
    {
        btnNew.sprite = sprite[0];
        btnSett.sprite = sprite[1];
        btnExit.sprite = sprite[2];
        settingString.text = frenchWords;
        SoundString.text = frenchSound;
    }

    public void English()
    {
        btnNew.sprite = sprite[3];
        btnSett.sprite = sprite[4];
        btnExit.sprite = sprite[5];
        settingString.text = englishWords;
        SoundString.text = englishSound;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
