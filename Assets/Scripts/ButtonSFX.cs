using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource buttonsound;

    public AudioClip buttonclick;

    public void onclickSound()
    {
        buttonsound.PlayOneShot(buttonclick);
    }
}
