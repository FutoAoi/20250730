using UnityEngine;

public class A : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            Debug.Log("A:1�b�o��");
            timer = 0f;
        }
    }
}
