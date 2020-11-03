using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouleTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject baby;
    public int nbrcrea;
    public Sprite sprite;
    public GameObject fond;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Createbaby()
    {
        while (nbrcrea > 0)
        {
            GameObject Baby = Instantiate(baby, transform.position, Quaternion.identity);
            Baby.GetComponent<SpriteRenderer>().sprite = sprite;
            /*Baby.GetComponent*/
            nbrcrea -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("DeathTrigger"))
        {
            Createbaby();
        }else if(collision.CompareTag("ChangeColor"))
        {
            fond.GetComponent<SpriteRenderer>().sprite = collision.GetComponent<SpriteRenderer>().sprite;
          
        }
    }

}
