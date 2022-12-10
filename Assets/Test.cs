using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //体力
    private int power = 25; //攻撃力
    private int mp = 53;    //魔力(53で初期化)

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた。");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた。");
        //残りのhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数(発展課題)
    public void Magic(int usedmp)
    {
        //残りのmpを確認する
        int restmp = this.mp; //現在のmp
        restmp -= usedmp;     //mp消費後の残りmp

        //mpが足りない場合
        if (restmp < 0)
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        //mpが5以上残っている場合
        else
        {
            //残りのmpを5減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        //要素の個数が5の配列を初期化
        int[] level = { 10, 1, 30, 50, 15 };

        //要素の値を順番に表示
        Debug.Log("!!要素の値を初期化した順に表示!!");
 
        //要素の値を表示する
        for (int i = 0; i < level.Length; i++)
        {
            Debug.Log(level[i]);
        }

        //要素の値を逆順に表示
        Debug.Log("!!要素の値を逆の順番で表示!!");
 
        //要素の値を表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(level[i]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数呼び出し
        lastboss.Attack();

        //防御用の関数呼び出し
        lastboss.Defence(3);

        //魔法用の関数呼び出し(10回まで：攻撃できる、11回以上：攻撃できない）
        Debug.Log("!!魔法用の関数呼び出し!!");

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
