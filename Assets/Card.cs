using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

// 변수
//정보

//함수

public class Card : MonoBehaviour
{
   
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
       text.text = Random.Range(0,10).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50, 0); 
    }
}
