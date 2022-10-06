using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    float cnt = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        string trueTag = "File";



        if (other.gameObject.CompareTag(trueTag)) // Tagと変数が同じだったら
        {
            float x = 5.5f;
            float y = 0.85f;
            float z = -8.5f;

            var g = new Vector3(
                x,    //x座標
                y,    //y座標
                z+(int)(cnt/2)  //z座標
                );

            //座標を反映
            other.gameObject.transform.position = g;
            //向きを一定にする
            other.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

            var rb = other.gameObject.GetComponent<Rigidbody>();
            Destroy(rb);

            cnt = cnt - 1.0f;
        }
        else
        {

        }
    }
}
