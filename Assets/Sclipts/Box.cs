using UnityEngine;

public class Box : MonoBehaviour
{
    FadeSceneLoader FadeSceneLoader;
    [SerializeField] GameObject GameObject;
    private void Start()
    {
        FadeSceneLoader = FindAnyObjectByType<FadeSceneLoader>();
    }
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.B))
        {
            FadeSceneLoader.Instance.Box();
        }
        
    }
}
