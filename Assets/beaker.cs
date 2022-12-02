using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class beaker : MonoBehaviour
{
    public GameObject explodefx;
    List<string> beakerChemicals = new List<string>();
    List<string> soidumExplodion = new List<string>();
    List<string> rustRxn = new List<string>();
    List<string> oxogeyprodRxn = new List<string>();
    List<string> sulfarExplodeRxn = new List<string>();
    List<string> gasleak = new List<string>();
   

    // List<List<string>> reactionLists = new List<List<string>>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started");
        soidumExplodion.Add("water");
        soidumExplodion.Add("sodium");

        sulfarExplodeRxn.Add("water");
        sulfarExplodeRxn.Add("sulfur");

        oxogeyprodRxn.Add("water");
        oxogeyprodRxn.Add("peroxide");

        rustRxn.Add("water");
        rustRxn.Add("iodine");

        gasleak.Add("iodine");
        gasleak.Add("sulfur");

    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        chemtype tube;
        other.gameObject.TryGetComponent<chemtype>(out tube);
        if (tube != null)
        {
            beakerChemicals.Add(tube.type);
            Debug.Log($"add tube {tube.type}");

            if (beakerChemicals.Count == 2)
            {
                Debug.Log($"you have 2 chemicals ");
                foreach (var item in beakerChemicals)
                {
                    Debug.Log($"{item}");
                }
                MakeReaction();
                beakerChemicals.Clear();

            }
            tube.gameObject.SetActive(false);

        }
    }

    public void MakeReaction()
    {

        if (IsRxn(soidumExplodion))
        {
            Debug.Log($"explode");
            explode();
            reset();

        }
        else if (IsRxn(sulfarExplodeRxn))
        {
            Debug.Log($"explode");

            explode();
            reset();
        }
        else if (IsRxn(oxogeyprodRxn))
        {
            Debug.Log($"o2");

            reset();
        }
        else if (IsRxn(rustRxn))
        {
            Debug.Log($"rust");
            changecolor(Color.yellow);
        }else if (IsRxn(gasleak))
        {
            Debug.Log($"gassss");
            gas();
        }
        else
        {
            Debug.Log($"no rxn occur");


        }
    }
    public bool IsRxn(List<string> rxn)
    {
        return beakerChemicals.Intersect(rxn).Count() == rxn.Count();
    }
   
    void explode()
    {
        Instantiate(explodefx, transform.position, transform.rotation);
    }
    void gas()
    {

    }
    
    void changecolor(Color mixcolor)
    {
        Debug.Log($"color changed to {mixcolor} ");
    }

    void reset()
    {
        Debug.Log($"Reset has been called");
    }
}
