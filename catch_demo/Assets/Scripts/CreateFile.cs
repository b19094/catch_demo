using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateFile : MonoBehaviour
{
    public Text firstInfo;
    public GameObject Button;
    public GameObject Canvas;


    public GameObject prefabObj;
    int tmp;
    float cnt = 0.0f;
    int t = 0;


    public List<GameObject> list_cloneFile_ = new List<GameObject>();

    List<string> fileList = new List<string>();


    // 初期化
    void Start()
    {
        


    }

    public void OnClick()
    {
        List<string> fileList = new List<string>
        {
            "Attack.cs", "Field.cs", "Enemy.cs", "Hero.cs"
        };

        if (t < 4)
        {
            // プレハブを元にオブジェクトを生成する
            GameObject obj = Instantiate(prefabObj, new Vector3(-22.5f, 5.0f, 0.0f + cnt), Quaternion.Euler(0, 180, 0));

            GameObject child = obj.transform.Find("Canvas").gameObject;

            obj.name = fileList[t];

            child.transform.Find("Text").GetComponent<Text>().text = fileList[t];

            cnt = cnt + 0.5f;
            if (cnt > 1.0f)
            {
                cnt = -1.0f;
            }
        }
        if(t == 3)
        {
            firstInfo.text = "「Attack.cs」と「Hero.cs」を\n" +
                                "Addしてください";

            Button.SetActive(false);
            Canvas.SetActive(true);

        }

        t++;
    }
}
