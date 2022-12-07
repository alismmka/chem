using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Seqeditor : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;
    public TMP_Text Customtxtref;
    public TMP_Text Oritxtref;


    public void ShowKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    public void CloseKeyboard()
    {
        keyboard.active = false;
    }

    public void savetxt()
    {
        Oritxtref.text = Customtxtref.text;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Customtxtref != null && keyboard!=null)
        Customtxtref.text = keyboard.text;
    }
}
