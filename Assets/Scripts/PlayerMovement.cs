using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public CircleCollider2D fishbowl;
    public BoxCollider2D shape; 
    

    

    // Update is called once per frame
    void Update()
    {
        
        
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            transform.position = fishbowl.bounds.ClosestPoint(position);

       /* if (shape.isTrigger)
        {
            Debug.Log("This Collider2D can be triggered");
        }
        else if (!shape.isTrigger)
        {
            Debug.Log("This Collider2D cannot be triggered");
        }

    */
    }
      


  
  
   
    


}
