using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//追加

 public class Prefab_Script2 : MonoBehaviour
{
    [SerializeField] private Text numberText; // 追加

    // インスペクタからこのスクリプトにballPrefabをアタッチすることで、変数にballPrefabが格納される
    public GameObject ballPrefab;

// void Start () {
    public void SetNumber(int number){
        numberText.text = "Number:" + number.ToString();
 
        // 10個ランダムな場所にballを生成する
        for(int i = 0; i < number; i++){
        // for(int i = 0; i < 10; i++){
            // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
            GameObject ball = Instantiate(ballPrefab) as GameObject;
            // ランダムな場所に配置する
            //Vector3 --> 引数はx,y,z変数でfloat型
            ball.transform.position = new Vector3(Random.Range(-70,70), 0 ,Random.Range(-70,70));
        }
    }
// }


    // void Start () {
    //     // 10個ランダムな場所にballを生成する
    //     for(int i = 0; i < 10; i++){
    //         // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
    //         GameObject ball = Instantiate(ballPrefab) as GameObject;
    //         // ランダムな場所に配置する
    //         //Vector3 --> 引数はx,y,z変数でfloat型
    //         ball.transform.position = new Vector3(Random.Range(-70,70), 0 ,Random.Range(-70,70));
    //     }
    // }
    
}

