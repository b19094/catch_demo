using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    public GameObject prefabObj;

    int tmp = 0;
    float cnt = 0.0f;

    // 初期化
    void Start()
    {

    }

    public void OnClick()
    {
        string number;
        tmp++;

        number = tmp.ToString();

        // プレハブを元にオブジェクトを生成する
        GameObject obj = Instantiate(prefabObj, new Vector3(-22.5f, 5.0f, 0.0f + cnt), Quaternion.Euler( 0, 180, 0));

        GameObject child = obj.transform.Find("Canvas").gameObject;

        child.transform.Find("Text").GetComponent<Text>().text = "File" + number;

        cnt = cnt + 0.5f;
        if (cnt > 1.0f)
        {
            cnt = -1.0f;
        }
    }
}