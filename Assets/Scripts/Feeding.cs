using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeding : MonoBehaviour
{
    public GameObject foodup;
    public GameObject shape; 
    private void Update()
    {
       

    }
    private void Feed()
    {
        /*
        if (Input.GetButton("feed"))
        {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.1f);
        }
        if (Input.GetButton("shrink"))
        {
            gameObject.transform.localScale += new Vector3(-0.01f, -0.01f, 0.1f);
        }
        */

    }

    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject == foodup)
        {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.1f);

        }
        Debug.Log("food colliding");
    }


}
