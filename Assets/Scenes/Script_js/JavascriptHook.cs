using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JavascriptHook : MonoBehaviour
{
    [SerializeField] private SpriteRenderer circleSpriteRenderer;
    [SerializeField] private Text numberText;
    [SerializeField] private Text stringText;
    // [SerializeField] private Text stringText2;
    // [SerializeField] private Text stringText3;
    //stringText2,3などは使えないぽい。
    //stringTextの連チャンもダメ。

//action test
    public void TintRed(){
        circleSpriteRenderer.color = Color.red;
    }
    public void TintGreen(){
        circleSpriteRenderer.color = Color.green;
    }

//text test
    public void SetNumber(int number){
        numberText.text = "Number:" + number.ToString();
    }
    public void SetString(string str){
        //SetStringの重複ダメ。
        stringText.text = "String:" + str;
    }
    // public void SetString2(string str){
    //     // SetString2,3などもダメ。
    //     stringText2.text = "String:" + str;
    //     // stringText2ダメぽい。
    // }
    // public void SetString3(string str){
    //     // str2ダメっぽい。
    //     stringText.text = "String:" + str;
    // }
    

    private void Update(){
        if(Input.GetKeyDown(KeyCode.T)){
            TintRed();
        }
        if(Input.GetKeyDown(KeyCode.Y)){
            TintGreen();
        }
    }
//JSON test
    public class JsonObject{
        public string name;
        public int age;
    }

    public void TestJson(string json){
        JsonObject jsonObject = JsonUtility.FromJson<JsonObject>(json);
        // stringText2.text = "Name" + jsonObject.name + "; Age:" + jsonObject.age;
        stringText.text = "Name" + jsonObject.name + "; Age:" + jsonObject.age;
    }
}