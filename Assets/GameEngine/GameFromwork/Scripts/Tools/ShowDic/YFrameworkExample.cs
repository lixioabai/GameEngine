// ========================================================
// Des：
// Author：yeyichen
// CreateTime：06/06/2018 14:50:53
// Version：v 1.0
// ========================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YFrameworkExample : MonoBehaviour
{

    #region 可序列化字典

    [System.Serializable]
    public class SerializableDictionaryExample : SerializableDictionary<int, float> { }

    public SerializableDictionaryExample dic;

    #endregion



    
}
