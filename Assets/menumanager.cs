using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lvl1()
    {
        SceneManager.LoadScene(1);
    }
    public void lvl2()
    {
        SceneManager.LoadScene(2);
    }

    public void lvl3()
    {
        SceneManager.LoadScene(3);
    }
}
