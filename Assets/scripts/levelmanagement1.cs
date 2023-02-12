using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanagement1 : MonoBehaviour
{
    private enemy[] noofenemy;


   public void home_button(string home)
    {
        SceneManager.LoadScene(home);
    } 
    void OnEnable()
    {
        noofenemy = FindObjectsOfType<enemy> ();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(enemy enemies in noofenemy)
        {
            if(enemies!=null)
            {
                return;
            }
            
            
        }
        SceneManager.LoadScene("mainmenu");
    }
}
