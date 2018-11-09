using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Networking;
using System.Text;

public class WebManager : MonoBehaviour {

    string cookie;
    //定义访问JSP登录表单的get方式访问路径
    private string Url = "http://localhost:8080/JQKJWeb/DownLoadModelInfoServlet?";

    void Start ()
    {
        cookie = "";

        //向服务器传递的参数
        string parameter = "";
        parameter += "UserName=" + "111" + "&";
        parameter += "PassWord=" + "222" ;

        //开始传递
        StartCoroutine(login(Url + parameter));
    }
	
	// Update is called once per frame
	void Update () {
	
	}


   

    IEnumerator login(string url)
    {
        WWW www = new WWW(url);
        yield return www;
        //如果发生错误，打印这个错误
        if (www.error != null)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.text);
            //如果服务器返回的是true
            if (www.text.Equals("true"))
            {
                //登陆成功
                print("Login Success!!!");
               
            }
            else
            {
                //否则登录失败
                print("Login Fail...");
            }
        }
      
    }

}
