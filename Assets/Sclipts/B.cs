using UnityEngine;

public class B : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += Time.unscaledDeltaTime;

        if (timer > 1f)
        {
            Debug.Log("B:1ïbåoâﬂ");
            timer = 0f;
        }
    }
}
