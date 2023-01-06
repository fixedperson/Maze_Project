using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject Wall;
    public GameObject extWall;
    public int width, depth;

    // Start is called before the first frame update
    void Start()
    {
        width = 30;
        depth = 30;

        for(int i = 0; i <width; i++)
        {
            for( int j = 0; j < depth; j++)
            {
                if(i == width-1 || i == 0 || j == depth-1 || j ==0 )
                {
                    if( (i == 1 && j == 0) || (j ==width-1 &&i == depth-2))
                    { continue; }
                    GameObject gameObject = Instantiate(extWall);
                    gameObject.transform.position = new Vector3(i, 1, j);
                }
                else
                {
                    int seed = Random.Range(0, 3);
                    if (seed == 1 || seed == 2)
                    {
                        GameObject gameObject = Instantiate(Wall);
                        gameObject.transform.position = new Vector3(i, 1, j);
                    }
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
