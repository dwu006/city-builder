using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // Start is called before the first frame update
    public void playGame() {
        //Debug.Log("This is a log message.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Debug.Log("This is a log message.");
    }
}
