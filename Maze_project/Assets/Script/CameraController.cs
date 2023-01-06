using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float hSpeed = 2;
    public float vSpeed = 2;

    public float hAngle; 
    public float vAngle;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("HumanMale_Character_Free");
        transform.position = new Vector3(
            player.transform.position.x+0.05f,
            player.transform.position.y+1.75f,
            player.transform.position.z+0.05f
            );
    }

    // Update is called once per frame
    void Update()
    {
        float h = hSpeed * Input.GetAxis("Mouse X");
        float v = -vSpeed * Input.GetAxis("Mouse Y");
        // transform.Rotate(v, h, 0);
        
        hAngle = hAngle + h * hSpeed;
        vAngle = vAngle + v * vSpeed;
        vAngle = Mathf.Clamp(vAngle, -70, 30);

        transform.rotation = Quaternion.Euler(vAngle, 
            transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        // transform.Rotate(v, 0, 0);
        transform.Rotate(Vector3.up, h, Space.World);
    }
}
