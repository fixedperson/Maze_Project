using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanController : MonoBehaviour
{
    Animator animator;
    
    public float walkSpeed;
    public float cameraRotationLimit;
    public Camera theCamera; 
    
    private float cameraRotation;
    private Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraRotation();
        CharacterRotation();
        
        Animation();
    }
    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");  
        float moveZ = Input.GetAxisRaw("Vertical");  
        Vector3 moveH = transform.right * moveX; 
        Vector3 moveV = transform.forward * moveZ; 

        Vector3 velocity = (moveH + moveV).normalized * walkSpeed; 

        rigidbody.MovePosition(transform.position + velocity * Time.deltaTime);
    }

    private void CameraRotation()  
    {
        float rotationX = Input.GetAxisRaw("Mouse Y"); 
        float cameraX = rotationX * 2;
        
        cameraRotation -= cameraX;
        cameraRotation = Mathf.Clamp(cameraRotation, -cameraRotationLimit, 70);

        theCamera.transform.localEulerAngles = new Vector3(cameraRotation, 0f, 0f);
    }

    private void CharacterRotation()
    {
        float rotationY = Input.GetAxisRaw("Mouse X");
        Vector3 characterY = new Vector3(0f, rotationY, 0f) * 2;
        
        rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(characterY));
    }

    void Animation()
    {
        GetComponent<Animator>().SetBool("forward", false);
        GetComponent<Animator>().SetBool("back", false);
        if (Input.GetKey(KeyCode.W))
        {

            GetComponent<Animator>().SetBool("forward",true);
            GetComponent<Animator>().SetBool("back", false);
            // transform.Translate(transform.forward * Time.deltaTime);
            //GetComponent<Rigidbody>().AddForce(transform.forward * moveForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetBool("back", true);
            GetComponent<Animator>().SetBool("forward", false);
            // transform.Translate(-transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("back", true);
            GetComponent<Animator>().SetBool("forward", false);
            // transform.Translate(-transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("back", true);
            GetComponent<Animator>().SetBool("forward", false);
            // transform.Translate(transform.right * Time.deltaTime);
        }
    }
<<<<<<< Updated upstream
=======
    
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
>>>>>>> Stashed changes
}
