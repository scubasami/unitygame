using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fooddropping : MonoBehaviour {
    public GameObject projectile;
    public GameObject projectile2;
    public CircleCollider2D fishbowl;
    public float lifetime;


    private void FixedUpdate () {
       if (Input.GetButton("feed"))
            {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D gameObjectsRigidBody = bullet.GetComponent<Rigidbody2D>();
            gameObjectsRigidBody.mass = 5; 

            gameObjectsRigidBody.AddForce(transform.forward * 10);


            if (gameObject.name == "foodUp(Clone)")
            {
                Destroy(gameObject, lifetime);
            }
        }
        if (Input.GetButton("shrink"))
        {
            GameObject bullet = Instantiate(projectile2, transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D gameObjectsRigidBody = bullet.GetComponent<Rigidbody2D>();
            gameObjectsRigidBody.mass = 5;

            gameObjectsRigidBody.AddForce(transform.forward * 10);
        }
    }
    private void LateUpdate()
    {
        transform.position = fishbowl.bounds.ClosestPoint(transform.position);
    }

  

}
