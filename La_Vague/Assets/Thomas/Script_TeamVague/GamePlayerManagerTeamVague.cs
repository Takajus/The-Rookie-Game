using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerManagerTeamVague : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Vector3 moveVector;
    public List<GameObject> building;
    public Transform transmax;
    public Transform transmin;
    private Vector3 posbuild;
    public build state;



    public void Start()
    {
        state = build.Replace;
    }

    public void Update()
    {
       
        if(state==build.Replace)
        {
            for(int i=0;i<building.Count;i++)
            {
                posbuild = building[i].transform.position;
                posbuild.y = Random.Range(transmin.position.y, transmax.position.y);
                building[i].transform.position = posbuild;
            }

            state = build.Playing;
        }
    }

    public enum build
    {
        Replace,
        Playing,
    }
}
