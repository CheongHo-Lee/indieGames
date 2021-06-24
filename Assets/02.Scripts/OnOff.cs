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
    public GameObject Offimg_;

    public void BGM_AudioControl() //0~100
    {
        float sound = audioSlider.value;

        if (sound == -40f) masterMixer.SetFloat("BGM", -80); //(�Ʊ� ������ string, ���� ��)
        else masterMixer.SetFloat("BGM", sound);
    }

    public void Effect_AudioControl() //0~100
    {
        float sound = audioSlider.value;

        if (sound == -40f) masterMixer.SetFloat("EFFECT", -80); //(�Ʊ� ������ string, ���� ��)
        else masterMixer.SetFloat("EFFECT", sound);
    }

    public void BGM_AudioVolume_0_1(GameObject bar_) //on off
    {
        onoff_ = !onoff_;
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0; //������� ��ü����
        Offimg_.SetActive(onoff_);
        if (this.GetComponent<Toggle>().isOn == enabled)
        {
            bar_.GetComponent<Slider>().value = 0;
        }
        else
        {
            bar_.GetComponent<Slider>().value = -40;
        }

    }

    public void Effect_AudioVolume_0_1(GameObject bar_) //on off
    {
        onoff_ = !onoff_;
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0; //������� ��ü����
        Offimg_.SetActive(onoff_);
        if (this.GetComponent<Toggle>().isOn == enabled)
        {
            bar_.GetComponent<Slider>().value = 0;
        }
        else
        {
            bar_.GetComponent<Slider>().value = -40;
        }
        
    }

    public void WindowOpen(GameObject Window_) //����onoff
    {
        onoff_ = !onoff_; //�� ��ڻ�� �̰� ������ bool ���ٰ� �״ٰ� �۵�
        Window_.SetActive(onoff_);
    }
}
