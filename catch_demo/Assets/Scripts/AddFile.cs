using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddFile : MonoBehaviour
{
    public GameObject prefabObj;

    int tmp = 0;
    float cnt = 1.0f;
    float x = 0.0f;
    float y = 0.0f;
    float z = 0.0f;

    

    // 初期化
    void Start()
    {

    }

    public void OnClick()
    {
        string number;
        tmp++;

        number = tmp.ToString();

        if (cnt < 9)
        {
            // プレハブを元にオブジェクトを生成する
            GameObject obj = Instantiate(prefabObj, new Vector3(-21.0f - x, 1.4f + y, 13.5f + z), Quaternion.Euler(0, 180, 0));
            var rb = obj.gameObject.GetComponent<Rigidbody>();
            Destroy(rb);

            GameObject child = obj.transform.Find("Canvas").gameObject;

            child.transform.Find("Text").GetComponent<Text>().text = "File" + number;


            if((int)(cnt%4.0f) == 0)
            {
                x = x + 1.0f;

                y = y + 0.3f;
            }

            z = z + 1.0f;
            if (z > 3.0f)
            {
                z = 0.0f;
            }
        }

        cnt = cnt + 1.0f;
        
    }
}