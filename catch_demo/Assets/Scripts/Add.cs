using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    string fileName;

    public GameObject attackFalse;
    public GameObject attackTrue;
    public GameObject heroFalse;
    public GameObject heroTrue;
    public GameObject Canvas;

    bool attack = false;
    bool hero = false;

    // 初期化
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        fileName = collision.gameObject.name;

        if(fileName == "Attack.cs")
        {
            attack = true;
        }
        if (fileName == "Hero.cs")
        {
            hero = true;
        }

        AttackBool();
        HeroBool();

        if (attack == true && hero == true)
        {
            Canvas.SetActive(true);
        }

    }

    void OnCollisionExit(Collision other)
    {
        fileName = other.gameObject.name;

        if (fileName == "Attack.cs")
        {
            attack = false;
        }
        if (fileName == "Hero.cs")
        {
            hero = false;
        }

        AttackBool();
        HeroBool();

    }

    void AttackBool()
    {
        if (attack == true)
        {
            attackFalse.SetActive(false);
            attackTrue.SetActive(true);

        }
        else
        {
            attackFalse.SetActive(true);
            attackTrue.SetActive(false);
        }
        
    }

    void HeroBool()
    {
        if (hero == true)
        {
            heroFalse.SetActive(false);
            heroTrue.SetActive(true);

        }
        else
        {
            heroFalse.SetActive(true);
            heroTrue.SetActive(false);
        }

    }
}