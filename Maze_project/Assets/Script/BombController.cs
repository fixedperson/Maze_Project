using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject particle;
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
            //�� OnCollisionEnter�� �޼ҵ� �������̵� �ϴ� ����� 
            //Rigidbody ��ü�� ���� �ִ� �� 
            GameObject p = Instantiate(particle);
            p.transform.position = gameObject.transform.position;
            Destroy(gameObject);
            GetComponent<ParticleSystem>().Play();
        }
    }
}
