using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public int phase = 1;
    public bool objective;
    public TMP_Text txtref;
    public TMP_Text [] txtcontents;

    //public beaker beakref;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(phase==4)
        {
            winstate();
        }
        if(objective)
        {
            txtref.text = txtcontents[phase-1].text;
            phase++;
            objective = false;
        }
    }

    void winstate()
    {

    }
}
