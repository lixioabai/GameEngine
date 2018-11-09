using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Testss : MonoBehaviour {

    string Str = "";
    float times;
    public Text text;
     void  Start ()
    {
		Application.runInBackground = true;   
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKey)
        {
            times += Time.deltaTime;
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    Debug.Log(keyCode.ToString());
                    Str = keyCode.ToString();


                }
            }

        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            callSdkApi("OpenApp");
            callSdkApi("BackToUnity");
			StartCoroutine (QuitApp());
        }

       

       

    }

    #region 封装调用
    /// <summary>
    /// 传参调用android定义的方法
    /// </summary>
    /// <param name="apiName">API name.</param>
    /// <param name="args">Arguments.</param>
    private static void callSdkApi(string apiName, params object[] args)
    {
        using (AndroidJavaClass sdkclass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            AndroidJavaObject jo = sdkclass.GetStatic<AndroidJavaObject>("currentActivity");
            jo.Call(apiName, args);
        }
    }

    /// <summary>
    /// 传参调用android定义的方法
    /// </summary>
    /// <param name="apiName">API name.</param>
    /// <param name="args">Arguments.</param>
    private static void callStaticSdkApi(string apiName, params object[] args)
    {
        using (AndroidJavaClass sdkclass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            AndroidJavaObject jo = sdkclass.GetStatic<AndroidJavaObject>("currentActivity");
            jo.CallStatic(apiName, args);
        }
    }
    #endregion



    public void GetAndroidMessage()
    {
        text.text = "打开成功";
        Application.Quit();
    }

     
	IEnumerator QuitApp()
	{
		yield return new WaitForSeconds (2);
		Application.Quit();
	}

  
}
