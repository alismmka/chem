using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouring : MonoBehaviour
{
    public bool pour;
    public ParticleSystem pourfx;
    public float Pourangle;
    public float currangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currangle = Vector3.Angle(Vector3.down, transform.up);

     if (Vector3.Angle(Vector3.down,transform.up)>Pourangle)
        {
            pourfx.Play();
            pour = true;
        }
        else
        {
            pourfx.Stop();
            pour = false;

        }
    }
}
