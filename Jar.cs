using UnityEngine;
using System.Collections;

public class Jar : MonoBehaviour
{

    private static string JAVA_CLASS_NAME = "com.exampletgl.kaede.mylibrary1126.BuildConfig";
    private static string JAVA_METHOD_NAME = "BuildConfig";

    private static string COROUTINES_NAME = "sleep";
    private static int WAIT_SECOND = 5;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(COROUTINES_NAME);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //「コルーチン」で呼び出すメソッド
    IEnumerator sleep()
    {
        yield return new WaitForSeconds(WAIT_SECOND);
        using (AndroidJavaClass plugin = new AndroidJavaClass(JAVA_CLASS_NAME))
        {
            plugin.CallStatic(JAVA_METHOD_NAME);
        }
    }
}