using UnityEngine;
using System.Collections;

public class Caller : MonoBehaviour
{

    private static string JAVA_CLASS_NAME = "com.example.welcome_tgl.MainActivity";
    private static string JAVA_METHOD_NAME = "MyRecogStart";

    // Use this for initialization
    void Start()
    {
        using (AndroidJavaClass plugin = new AndroidJavaClass(JAVA_CLASS_NAME))
        {
            plugin.CallStatic(JAVA_METHOD_NAME);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}