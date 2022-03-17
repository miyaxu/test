using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Transform/Follow Transform")]
public class Test : MonoBehaviour
{
    private static Test _instance;
    public static Test Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Start()
    {
        //Object obj = Resources.Load("Cat");
        //GameObject a = Instantiate<GameObject>(obj);
        //a.transform.localScale = new Vector2(2f, 2f);
    }

    public void Hello()
    {
        Debug.Log("Test 123456789");
    }
}
