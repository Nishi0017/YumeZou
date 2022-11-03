using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    private int n = 2;
    private float timer = 0.0f;

    private void Update()
    {
        if (n == 0)
        {
            timer += Time.deltaTime;
            if (timer > 60.0f)
                SceneManager.LoadScene("SampleScene");
        }

    }
    public void resetGame()
    {
        n--;
    }
}
