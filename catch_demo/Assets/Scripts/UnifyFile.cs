using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnifyFile : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject addBox;
    public GameObject pushBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {

        addBox.SetActive(false);
        pushBox.SetActive(true);
        Canvas.SetActive(false);
    }

}
