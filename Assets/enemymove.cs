using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public Transform playertran;
    public Vector3 playerdist;
    public float playerdistfloat;
    public float enemyspeed;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        playertran = FindObjectOfType<Player>().transform;
    } 

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPostition = new Vector3(playertran.position.x, this.transform.position.y, playertran.position.z);
        if (playerdistfloat > 6f)
        {
            this.transform.LookAt(targetPostition);
        }
        playerdistfloat = Vector3.Distance(transform.position, playertran.position);

        playerdist = (transform.position - playertran.position).normalized;


        if (playerdistfloat < 6f)
        {
            anim.SetTrigger("attack");
        }
        else
        {
            
            transform.position = Vector3.Lerp(transform.position, targetPostition, Time.deltaTime * enemyspeed);

        }
        
    }
}
