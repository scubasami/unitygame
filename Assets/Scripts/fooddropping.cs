using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class fooddropping : MonoBehaviour {
    public GameObject foodUp;
    public GameObject foodDown;
    public CircleCollider2D fishbowl;
    public float lifetime;
  


    private void FixedUpdate () {
       if (Input.GetButton("feed"))
            {
            GameObject bullet = Instantiate(foodUp, transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D gameObjectsRigidBody = bullet.GetComponent<Rigidbody2D>();
            gameObjectsRigidBody.mass = 5; 

            gameObjectsRigidBody.AddForce(transform.forward * 10);

            Destroy(bullet, lifetime);

        
        }
        if (Input.GetButton("shrink"))
        {
            GameObject bullet = Instantiate(foodDown, transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D gameObjectsRigidBody = bullet.GetComponent<Rigidbody2D>();
            gameObjectsRigidBody.mass = 5;

            gameObjectsRigidBody.AddForce(transform.forward * 10);

            Destroy(bullet, lifetime);

        }
    }
    private void LateUpdate()
    {
        transform.position = fishbowl.bounds.ClosestPoint(transform.position);
    }

  

}
