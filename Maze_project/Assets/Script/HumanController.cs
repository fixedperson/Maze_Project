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
    public Camera topCamera;
    
    private float cameraRotation;
    private Rigidbody rigidbody;
    public GameObject bombPrefab;

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
        GetComponent<Animator>().SetBool("throw", false);
        Animation();
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Launch the bomb");
            GameObject bomb = Instantiate(bombPrefab);
            bomb.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 1.0f ;
            
            GetComponent<Animator>().SetBool("throw", true);

            /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 direction = ray.direction;
            마우스 커서 방향으로 던지는 것 (Throw the mouse cursor direction) 
             */
            Vector3 direction = Camera.main.transform.forward; // 카메라에서 정면을 가리키게 함 (else throw the camera Forward)


            bomb.GetComponent<BombController>().Shoot(direction * 1000);
            // 벡터 넣을 때 방향은 정해져 있지만, 벡터의 길이 = 힘을 정해줘야함 Shoot을 

        }
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



}
