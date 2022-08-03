using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Engel : MonoBehaviour
{
    private static int skor;
    public TextMeshProUGUI skorYazisi,bitisYazisi;
    private void Start()
    {
        skor = 0;
    }

    void Update()
    {
        skorYazisi.text = skor.ToString();
        bitisYazisi.text = "Game Over \n Score : " + skor.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        float xPosition = Random.Range(-7.76f, 7.76f);
        float yPosition = Random.Range(6.5f, 10.5f);
        if (collision.gameObject.tag=="Kontrol_Cubugu")
        {
         
            transform.position = new Vector2(xPosition, yPosition);
            skor += Random.Range(8, 14);
        } else if
          (collision.gameObject.tag=="Karakter")
        {
            transform.position = new Vector2(xPosition, yPosition);
            hak.kalamHak--;
        }
    }

}
