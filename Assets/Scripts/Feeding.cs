using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeding : MonoBehaviour
{
    private void Update()
    {
       

        if (Input.GetButton("feed")) {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.1f);
        }
        if (Input.GetButton("shrink"))
        {
            gameObject.transform.localScale += new Vector3(-0.01f, -0.01f, 0.1f);
        }
    }
    


}
