using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
      //call exit game function
      doExitGame();
    }
    // this simple function will quit the application, it is tied to the "quit game" button on the unity editor
    void doExitGame()
     {
    Application.Quit();
}
}
