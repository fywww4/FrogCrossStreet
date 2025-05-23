using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Debug.Log("You win");

        Score.currentScore += 100;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
