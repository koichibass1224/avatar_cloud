using UnityEngine;

// public class GamePlaying
public class GamePlaying : MonoBehaviour
{
    void Start () {
        //「SCORE」というキーで、Int値の「20」を保存
        PlayerPrefs.SetInt("SCORE", 20);
        PlayerPrefs.Save();
    }
}