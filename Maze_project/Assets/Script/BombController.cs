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
            // Vector3 direction = Camera.main.transform.forward; // ī�޶󿡼� ������ ����Ű�� ��
            // bomb.GetComponent<HumanController>().Shoot(direction * 1000);
            // // ���� ���� �� ������ ������ ������, ������ ���� = ���� ��������� Shoot�� 

        }

    }
}
