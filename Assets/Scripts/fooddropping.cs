using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fooddropping : MonoBehaviour {
    public GameObject projectile;
    public GameObject projectile2;
    

    private void FixedUpdate () {
        if (Input.GetButton("feed"))
            {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
        }
        if (Input.GetButton("shrink"))
        {
            GameObject bullet = Instantiate(projectile2, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
        }
    }
  
}
