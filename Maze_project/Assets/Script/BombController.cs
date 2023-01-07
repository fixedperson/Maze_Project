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
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("Launch the bomb");
            // GameObject bomb = Instantiate(bombPrefab);
            // bomb.transform.position = Camera.main.transform.position;
            // /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Vector3 direction = ray.direction;
            // */
            // Vector3 direction = Camera.main.transform.forward; // 카메라에서 정면을 가리키게 함
            // bomb.GetComponent<HumanController>().Shoot(direction * 1000);
            // // 벡터 넣을 때 방향은 정해져 있지만, 벡터의 길이 = 힘을 정해줘야함 Shoot을 

        }

    }
}
