using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beaker : MonoBehaviour
{
    public GameObject chem1;
    public GameObject chem2;
    public GameObject explodefx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chem1.GetComponent<chemtype>().type == "water" && chem2.GetComponent<chemtype>().type == "sulfur")
        {
            explode();
            reset();
        }

        if (chem1.GetComponent<chemtype>().type == "water" && chem2.GetComponent<chemtype>().type == "peroxide")
        {
            reset();
        }

        if (chem1.GetComponent<chemtype>().type == "water" && chem2.GetComponent<chemtype>().type == "iodine")
        {
            changecolor(Color.yellow);
        }

        }

    void explode()
    {
        Instantiate(explodefx, transform.position, transform.rotation);
    }
    void boil()
    {

    }
    void freeze()
    {

    }
    void changecolor(Color mixcolor)
    {

    }

    void reset()
    {
        chem1 = null;
        chem2 = null;
    }
}
