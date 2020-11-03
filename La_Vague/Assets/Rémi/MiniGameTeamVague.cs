using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGameTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI touche1;
    public TextMeshProUGUI touche2;
    public ControlToucheTeamVague Control;
    public List<KeyCode> listtouche;
    public int set;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AfficheAndSetTouche()
    {
        set=Random.Range(0, listtouche.Count / 2);
        touche1.text = listtouche[set].ToString();
        touche2.text = listtouche[set + listtouche.Count / 2].ToString();
        Control.up = listtouche[set];
        Control.down = listtouche[set+listtouche.Count/2];
    }
}
