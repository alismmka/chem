using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public GameObject chemcontained;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<beaker>())
        {
            if(GetComponent<Pouring>().pour == true)
            {
                if (collision.gameObject.GetComponent<beaker>().chem1 != null)
                    collision.gameObject.GetComponent<beaker>().chem1 = chemcontained;
                else
                    collision.gameObject.GetComponent<beaker>().chem2 = chemcontained;
            }
        }
    }
}
