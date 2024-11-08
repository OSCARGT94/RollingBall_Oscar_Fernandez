using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceFx, audioSourceFx2, audioSourceFx3, audioSourceFx4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReproducirSonido(AudioClip clip)
    {
        audioSourceFx.PlayOneShot(clip);
        audioSourceFx2.PlayOneShot(clip);
        audioSourceFx3.PlayOneShot(clip);
        audioSourceFx4.PlayOneShot(clip);
    }
}
