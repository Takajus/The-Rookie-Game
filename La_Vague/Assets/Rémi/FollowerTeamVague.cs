using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float force;
    public ControlToucheTeamVague control;
    public DecomptTeamVague dec;
    
 
    // Update is called once per frame
    void Update()
    {
        if(dec.last<=0)
        {
            rb.gravityScale = 0.7f;
        if (Input.GetKeyDown(control.down))
        {
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
           
        }
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
