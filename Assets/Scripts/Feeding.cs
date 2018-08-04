using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeding : MonoBehaviour
{
    public GameObject foodUp;
    public GameObject foodDown;
    public GameObject fish;
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
       
        if (col.gameObject.tag == "foodUp")
        {
            fish.transform.localScale += new Vector3(0.1f, 0.1f, 0f);
            Debug.Log(fish.transform.localScale);
            Destroy(col.gameObject);

        }
        if (col.gameObject.tag == "foodDown")
        {
            fish.transform.localScale += new Vector3(-0.1f, -0.1f, 0f);
            Debug.Log("fooddown");
            Destroy(col.gameObject);

        }
    }


}
