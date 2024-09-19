using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeController : MonoBehaviour
{
    private AudioSource m_audioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        // PlayOnAwakeでは後付けされたSEがならないのでPlay()
        m_audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // 効果音が終わったら消える
        if (m_audioSource.isPlaying) return;

        Destroy(gameObject);
    }
}
