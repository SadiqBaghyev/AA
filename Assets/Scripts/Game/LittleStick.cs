using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LittleStick : MonoBehaviour
{
    

     Rigidbody2D rb;
    
   

    private float stickSpeed = 25f;
    public bool areCanMove;

    public GameObject Manager;
    
    private void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
       
        rb = GetComponent<Rigidbody2D>();
        

    }

    private void Update()
    {
        if (areCanMove == false)
        {
            rb.MovePosition(rb.position + Vector2.up * 15 * stickSpeed * Time.deltaTime);
           
        }
      
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TurningCircle")
        {
            //SetParent - ChildObject
            transform.SetParent(collision.transform);
            areCanMove = true;
           

        }

        if (collision.gameObject.tag == "LittleCircleTagg")
        {
           
           Manager.GetComponent<FinishManager>().FinishGame();
                
        }
    }

}
