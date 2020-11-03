using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float force;
    public GameObject target;
    
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
           
        }
        

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("DeathTrigger"))
        {
            Debug.Log("mort");
        }
    }




}
