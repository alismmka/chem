using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class beaker : MonoBehaviour
{
    public GameObject explodefx;
    public GameObject gasfx;
    public GameObject o2fx;
    public GameObject norxfx;

    public Animator fillanim;

    public Gamemanager manref;


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

        oxogeyprodRxn.Add("flame");
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

            fillanim.SetBool("1", true);

            if (beakerChemicals.Count == 2)
            {
                fillanim.SetBool("2", true);

                Debug.Log($"you have 2 chemicals ");
                foreach (var item in beakerChemicals)
                {
                    Debug.Log($"{item}");
                }
                MakeReaction();
                beakerChemicals.Clear();

            }
           // tube.gameObject.SetActive(false);

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
            o2out();
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
            reset();

        }
        else
        {
            Debug.Log($"no rxn occur");
            Instantiate(norxfx, transform.position, transform.rotation);


        }
    }
    public bool IsRxn(List<string> rxn)
    {
        return beakerChemicals.Intersect(rxn).Count() == rxn.Count();
    }
   
    void explode()
    {
        Instantiate(explodefx, transform.position, transform.rotation);
        if(manref.phase==1)
        {
            manref.objective = true;
        }
    }
    void gas()
    {
        Instantiate(gasfx, transform.position, transform.rotation);
        if (manref.phase == 2)
        {
            manref.objective = true;
        }
    }
    void o2out()
    {
        Instantiate(o2fx, transform.position, transform.rotation);
        if (manref.phase == 3)
        {
            manref.objective = true;
        }
    }
    
    void changecolor(Color mixcolor)
    {
        Debug.Log($"color changed to {mixcolor} ");
    }

    void reset()
    {
        fillanim.SetBool("1", false);
        fillanim.SetBool("2", false);
        Debug.Log($"Reset has been called");
    }
}
