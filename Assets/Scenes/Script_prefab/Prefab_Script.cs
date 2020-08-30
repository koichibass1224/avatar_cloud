using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Prefab_Script : MonoBehaviour
{
 
    // 初期化
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("Cube");
 
        // プレハブを元にオブジェクトを生成する
        GameObject instance = (GameObject)Instantiate(obj,
        new Vector3(5.0f, 0.0f, 0.0f),
        Quaternion.identity);

        //Instantiate(A,B,C)とした時、
        //A：第1引数(original)・・・ コピー対象の既存オブジェクト
        //B：第2引数(position)・・・新規オブジェクトの位置
        //C：第3引数(rotation)・・・新規オブジェクトの向き
    }

}

