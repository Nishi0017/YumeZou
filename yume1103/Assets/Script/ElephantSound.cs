using UnityEngine;

public class ElephantSound : MonoBehaviour
{
    public AudioClip elephantVoice;
    public float timeOut = 100.0f;
    public PlaySound PlaySound;
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            int r = Random.Range(0, 10);
            Debug.Log(r);
            if(r == 0)
            {
                PlaySound.PlaySE(elephantVoice);
            }

            timeElapsed = 0.0f;
        }
    }
}