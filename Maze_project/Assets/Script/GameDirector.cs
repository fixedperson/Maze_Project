using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject timerText;
    public GameObject pointText;
    public static float time = 0f;
    public static int point = 10000;
    public static int countBomb = 0; 

    // Start is called before the first frame update
    void Start()
    {
        /* this.timerText = GameObject.Find("Time");
         this.pointText = GameObject.Find("Point");*/
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text = point.ToString();
    }

    public void DesPoint()
    {
        if (point > 0)
        {
            point -= 100;
            countBomb++;
        }
        else if (point <= 0)
        {
            point = 0;
        }

    }


}