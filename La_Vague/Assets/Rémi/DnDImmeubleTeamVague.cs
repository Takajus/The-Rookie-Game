using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class DnDImmeubleTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    /*public float localScale;*/
    public Vector3 lastMousePosition;
    /*public float posStart;*/
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        /*pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        
        transform.localScale = new Vector3(pos.y-posStart, transform.localScale.y, transform.localScale.z);
        Debug.Log("cc");*/
        Scale(this.gameObject);
    }
    void Scale(GameObject o)
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            o.transform.localScale += ((Input.mousePosition - lastMousePosition) * Time.deltaTime /** scaleSensitivity*/);
            lastMousePosition = Input.mousePosition;
        }
    }

    void OnMouseOver()
    {
      
    }
  
}
