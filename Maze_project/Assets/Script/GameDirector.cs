using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject timerText;
    public GameObject pointText;
    public float time = 0f;
    public int point = 10000;
    
    // Start is called before the first frame update
    void Start()
    {
       /* this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");*/
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString();  
    }

    public void DesPoint()
    {
        if (point > 0)
        {
            point -= 100/2;
        }
        else if(point <= 0) 
        { 
            point = 0;
        }
    }
}
