using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //used to manage different scenes

public class ConnectScript : MonoBehaviour
{//submarine - ble connect
 // Start is called before the first frame update
    public void ConnectGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads next scene in the build
        //SceneManager.LoadScene("Training");
    }
}
