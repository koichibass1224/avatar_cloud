using UnityEngine;
using UnityEngine.UI;

// public class GamePlaying
public class GameResultandPlay_2 : MonoBehaviour
{
    [SerializeField] private Text stringText;//stringText.text = //のみ可能
    // [SerializeField] private string stringText;//stringText = //のみ可能
    // [SerializeField] private string str;

    // [SerializeField] private Text resultText;//stringText.text = //のみ可能

    // void Start () {
    // // str = "strtest";
    // string str = "21";
    public void SetString(string str){

        // stringText = "String:" + str; //stringの受け取り
        // stringText.text = str.ToString();
        stringText.text = str;
        

        //「SCORE」というキーで、Int値の「20」を保存
        // PlayerPrefs.SetInt("SCORE", 20);
        PlayerPrefs.SetString("TEXT", str);
        // PlayerPrefs.SetString("TEXT", "str");
        PlayerPrefs.Save();

         //「SCORE」というキーで保存されているInt値を読み込み
        string resultText = PlayerPrefs.GetString("TEXT");
        Debug.Log(resultText);
        stringText.text = resultText;
    }
//   void FixedUpdate(){
//         //「SCORE」というキーで保存されているInt値を読み込み
//         string resultText = PlayerPrefs.GetString("TEXT");
//         Debug.Log(resultText);
//         stringText.text = resultText;
//     }
}
// }