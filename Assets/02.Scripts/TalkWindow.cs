using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TalkWindow : MonoBehaviour
{
    public string sceneName;
    public GameObject Panel_;

    public void StayPlayer()
    {
        Panel_.SetActive(false);
    }

    public void OnButtonClick()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("isLoadFile", 0);

        SceneManager.LoadSceneAsync(sceneName);
        Debug.Log(sceneName + "로 이동합니다.");
    }
}
