using System.Collections;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeSceneLoader : MonoBehaviour
{
    [SerializeField] Image Panel;
    [SerializeField] float fadeSpeed = 1.0f;
    [SerializeField] AudioSource seAudioSource;
    [SerializeField] GameObject Boxprehab;
    public static FadeSceneLoader Instance;
    float timer;
    Color startColor;
    Color endColor;
    float t;
    float k;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(this);
        startColor = Panel.color;
        endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(SceneLoad());
        }
        if(Input.GetKeyUp(KeyCode.E))
        {
            seAudioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 0f;
        }
        if(Input.GetKeyUp(KeyCode.T))
        {
            Time.timeScale = 1f;
        }
    }

    public IEnumerator SceneLoad()
    {
        yield return StartCoroutine(Fadeout());
        yield return SceneManager.LoadSceneAsync(1);
        yield return StartCoroutine(Fadein());
    }
    public IEnumerator Fadeout()
    {
        Panel.enabled = true;
        timer = 0f;
        while (timer < fadeSpeed)
        {
            timer += Time.deltaTime;                        
            t = Mathf.Clamp01(timer / fadeSpeed);  
            Panel.color = Color.Lerp(startColor, endColor, t); 
            yield return null;                                     
        }
        Panel.color = endColor;
    }

    public IEnumerator Fadein()
    {
        Panel.enabled = true;
        timer = 0f;
        while (timer < fadeSpeed)
        {
            timer += Time.deltaTime;
            k = Mathf.Clamp01(timer / fadeSpeed);
            Panel.color = Color.Lerp(endColor, startColor, k);
            yield return null;
        }
        Panel.color = startColor;
    }

    public void Box()
    {
        Instantiate(Boxprehab, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
