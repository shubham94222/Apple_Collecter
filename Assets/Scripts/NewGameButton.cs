using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
}
