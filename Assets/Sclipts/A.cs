using UnityEngine;

public class A : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            Debug.Log("A:1ïbåoâﬂ");
            timer = 0f;
        }
    }
}
