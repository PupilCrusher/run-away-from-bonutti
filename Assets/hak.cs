using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class hak : MonoBehaviour
{
    public static int kalamHak = 3;
    public TextMeshProUGUI hakYazisi;
    public GameObject bitisPaneli;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hakYazisi.text = "Laps : " + kalamHak.ToString();
        if(kalamHak == 0)
        {
            Time.timeScale = 0;
            bitisPaneli.SetActive(true);
        }
    }
}
