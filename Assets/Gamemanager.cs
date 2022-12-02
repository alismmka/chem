using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public bool objective1;
    public TMP_Text txtref;
    public TMP_Text txtcontent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(objective1)
        {
            txtref.text = txtcontent.text;
        }
    }
}
