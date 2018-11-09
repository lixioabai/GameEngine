using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 异步加载过渡场景
/// </summary>
public class LoadingSync : MonoBehaviour {

    //public Slider Prograss;
    private AsyncOperation async_Operation;
    public Text PrograssImg;
    void Start()
    {
        StartCoroutine(LoadScene());
    }

	void Update () 
    {
       // Prograss.value = async_Operation.progress;
        PrograssImg.text= ((async_Operation.progress)*100).ToString()+"%";

    }

    IEnumerator LoadScene()
    {
        async_Operation = SceneManager.LoadSceneAsync(AppConfig.SceneName);
        yield return async_Operation;
    }
}
