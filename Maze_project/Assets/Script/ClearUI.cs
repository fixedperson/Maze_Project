using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearUI : MonoBehaviour
{
    public GameObject score;
    public GameObject time;
    public GameObject bombHit;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        time = GameObject.Find("Time");
        bombHit = GameObject.Find("Bomb Hit");
    }

    // Update is called once per frame
    void Update()
    {
        score.GetComponent<TextMeshProUGUI>().text = "Score : " + GameDirector.point.ToString();
        time.GetComponent<TextMeshProUGUI>().text = "Time : " + GameDirector.time.ToString();
        bombHit.GetComponent<TextMeshProUGUI>().text = "Bomb Hit : " + GameDirector.countBomb.ToString();
    }
}
