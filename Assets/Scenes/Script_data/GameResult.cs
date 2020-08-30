using UnityEngine;

// public class GameResult
public class GameResult : MonoBehaviour
{
    void Start () {
        //「SCORE」というキーで保存されているInt値を読み込み
        int resultScore = PlayerPrefs.GetInt("SCORE");
        Debug.Log("保存されている点数：" + resultScore);
    }
}