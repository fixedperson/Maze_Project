using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "wall")
        {
            GetComponent<Rigidbody>().isKinematic = true;

            Destroy(collision.gameObject);
            //원 OnCollisionEnter의 메소드 오버라이딩 하는 방식임 
            //Rigidbody 자체가 갖고 있는 것 
            Destroy(gameObject);
            GetComponent<ParticleSystem>().Play();
        }
    }
}
