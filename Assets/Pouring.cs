using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouring : MonoBehaviour
{
    public ParticleSystem pourfx;
    public float Pourangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Vector3.Angle(Vector3.down,transform.up)>Pourangle)
        {
            pourfx.Play();
        }
        else
        {
            pourfx.Stop();
        }
    }
}
