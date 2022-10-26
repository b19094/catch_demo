using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    public GameObject prefabObj;
    public GameObject prefabToggle;
    public GameObject parent;

    int tmp = 0;
    float cnt = 0.0f;
    float cntToggle = 0.0f;
    float Toggle_y = 0.0f;
    float Toggle_x = 0.0f;

    public List<GameObject> list_cloneFile_ = new List<GameObject>();

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

        list_cloneFile_.Add(obj);

        GameObject toggle = Instantiate(prefabToggle, new Vector3(-160.0f + Toggle_x, 210.0f - Toggle_y, 0.0f), Quaternion.Euler(0, 0, 0));

        toggle.transform.Find("Label").GetComponent<Text>().text = "File" + number;

        toggle.transform.SetParent(this.parent.transform, false);

        cntToggle++;

        if (cntToggle > 9) {
            Toggle_x = Toggle_x + 320.0f;
            cntToggle = 0.0f;
        }

        Toggle_y = 40.0f * cntToggle;

        cnt = cnt + 0.5f;
        if (cnt > 1.0f)
        {
            cnt = -1.0f;
        }
    }
}