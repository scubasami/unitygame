using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public CircleCollider2D fishbowl;
    
    

    

    // Update is called once per frame
    void Update()
    {
        
        
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            transform.position = fishbowl.bounds.ClosestPoint(position); 
           
        

    }
   
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "foodUp")
            {
                gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.1f);
                
            }
             Debug.Log("food colliding");
        }
    


}
