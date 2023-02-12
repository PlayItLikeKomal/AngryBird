using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    
    public void startbutton(string start)
    {
        SceneManager.LoadScene(start);
     

    }
   
    public void quit_game()
    {
        Application.Quit();   
    }

}
