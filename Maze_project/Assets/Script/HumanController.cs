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
        public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "wall")
        {
            GetComponent<Rigidbody>().isKinematic = true;

            Destroy(collision.gameObject);
            //원 OnCollisionEnter의 메소드 오버라이딩 하는 방식임 
            //Rigidbody 자체가 갖고 있는 것 
            GetComponent<ParticleSystem>().Play();
        }
    }
}
