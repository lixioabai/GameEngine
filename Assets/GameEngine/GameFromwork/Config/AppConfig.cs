﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// APP 配置
/// </summary>
public class AppConfig 
{
    /// <summary>
    /// APP是否是发布版本 0代表未发布 1代表发布
    /// </summary>
    public static int APP_LINE=0;

    public static string SceneName = "";



    public static void LoadingScene(string sceneName)
    {
        SceneName = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }


}
