using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.Audio;
using UnityEngine.UI;

public class OnOff : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;

    bool onoff_; //â onoff Ȯ��

    public void AudioControl() //0~100
    {
        float sound = audioSlider.value;

        if (sound == -40f) masterMixer.SetFloat("BGM", -80); //(�Ʊ� ������ string, ���� ��)
        else masterMixer.SetFloat("BGM", sound);
    }

    public void AudioVolume() //on off
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0; //������� ��ü����
    }

    public void WindowOpen(GameObject Window_) //����onoff
    {
        onoff_ = !onoff_; //�� ��ڻ�� �̰� ������ bool ���ٰ� �״ٰ� �۵�
        Window_.SetActive(onoff_);
    }

    public void GameOut() //â�ݱ�
    {
        Application.Quit();
    }
}
