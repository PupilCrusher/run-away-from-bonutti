using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenidenOyna : MonoBehaviour
{
    // Start is called before the first frame update
   public void YenidenOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        hak.kalamHak = 3;
        Time.timeScale = 1;
    }

    // Update is called once per frame
   
}
