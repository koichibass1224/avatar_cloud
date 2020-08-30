using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;


// public class GamePlaying
public class GameResultandPlay_3 : MonoBehaviour
{
    [SerializeField] private Text stringText;//stringText.text = //のみ可能
    // [SerializeField] private string stringText;//stringText = //のみ可能
    // [SerializeField] private string str;


    // void Start () {
    // // str = "strtest";
    // string str = "20";
    // // public void SetString(string str){
        
    //     //「SCORE」というキーで、Int値の「20」を保存
    //     // PlayerPrefs.SetInt("SCORE", 20);
    //     PlayerPrefs.SetString("TEXT", str);
    //     // PlayerPrefs.SetString("TEXT", "str");
    //     PlayerPrefs.Save();

    //     //「SCORE」というキーで保存されているInt値を読み込み
    //     string resultText = PlayerPrefs.GetString("TEXT");
    //     Debug.Log(resultText);
    //     // stringText.text = resultText;
    // }

//JSON test
    public class JsonObject{
        public string name;
        public int id;
    }

    // void Start () {
    // string json = "{ \"id\": 100, \"name\": \"テストアイテム\", \"description\": \"説明だよ\" }";
    public void TestJson(string json){

        JsonObject jsonObject = JsonUtility.FromJson<JsonObject>(json);
        stringText.text = "Name" + jsonObject.name + "; Age:" + jsonObject.id;
    }

}
// }