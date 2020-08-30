using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JavascriptHook2 : MonoBehaviour
{
    [SerializeField] private Text stringText;


    public void SetString(string str){
        //SetStringの重複ダメ。
        stringText.text = "String:" + str;
    }
    
//JSON test
    public class JsonObject{
        public string name;
        public int age;
    }

        public void TestJson(string json){
        JsonObject jsonObject = JsonUtility.FromJson<JsonObject>(json);

        stringText.text = "Name" + jsonObject.name + "; Age:" + jsonObject.age;
        // stringText.text = jsonObject;
    }


}
