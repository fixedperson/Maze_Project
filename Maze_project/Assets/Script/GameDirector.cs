using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("enter");
        if(collision.gameObject.tag == "end")
        SceneManager.LoadScene("ClearScene");
        else
        {
            Debug.Log(collision.gameObject.name);
        }
    }
}
