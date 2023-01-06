using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    Animator animator;
    public float moveForce = 1000;

    private GameObject camara;
    // Start is called before the first frame update
    void Start()
    {
        camara = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("forward", false);
        GetComponent<Animator>().SetBool("back", false);
        if (Input.GetKey(KeyCode.W))
        {

            GetComponent<Animator>().SetBool("forward",true);
            GetComponent<Animator>().SetBool("back", false);
            transform.Translate(transform.forward * Time.deltaTime);
            //GetComponent<Rigidbody>().AddForce(transform.forward * moveForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetBool("back", true);
            GetComponent<Animator>().SetBool("forward", false);
            transform.Translate(-transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("back", true);
            GetComponent<Animator>().SetBool("forward", false);
            transform.Translate(-transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("back", true);
            GetComponent<Animator>().SetBool("forward", false);
            transform.Translate(transform.right * Time.deltaTime);
        }
    }
}
