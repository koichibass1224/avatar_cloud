using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;


// public class GamePlaying
public class GameResultandPlay : MonoBehaviour
{
    [SerializeField] private Text stringText;//stringText.text = //のみ可能
    // [SerializeField] private string stringText;//stringText = //のみ可能
    [SerializeField] private string str;

    // [SerializeField] private Text resultText;//stringText.text = //のみ可能

    // void Start () {
    // // str = "strtest";
    // string str = "20";
    public void SetString(string str){

        // stringText = "String:" + str; //stringの受け取り
        // stringText.text = str.ToString();
        // stringText.text = str;
        
        //「SCORE」というキーで、Int値の「20」を保存
        // PlayerPrefs.SetInt("SCORE", 20);
        PlayerPrefs.SetString("TEXT", str);
        // PlayerPrefs.SetString("TEXT", "str");
        PlayerPrefs.Save();

        //「SCORE」というキーで保存されているInt値を読み込み
        string resultText = PlayerPrefs.GetString("TEXT");
        Debug.Log(resultText);
        stringText.text = resultText;
        // stringText.text = resultText.ToString();//でない。
    }

// [Serializable]
public class Item
{
    public int id;
    public string name;
    public string description;
}

string itemJson = "{ \"id\": 100, \"name\": \"テストアイテム\", \"description\": \"説明だよ\" }";

void Start(){
Item item = JsonUtility.FromJson<Item>(itemJson);

Debug.Log("item id " + item.id);
Debug.Log("item name " + item.name);
Debug.Log("item description " + item.description);
}

// public void Start(){
// string serialisedItemJson = JsonUtility.ToJson(item);
// Debug.Log("serialisedItemJson " + serialisedItemJson);
// }

}
// }