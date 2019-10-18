using UnityEngine;
using System.Collections;

public class ParticlControl : MonoBehaviour
{
    private ParticleSystem particle;
    public buttonScript buttonScript;
    // Use this for initialization
    void Start()
    {
        particle = this.GetComponent<ParticleSystem>();
        particle.Stop();
    }

    void Update()
    {
        if (buttonScript.Particle == true)
        {
            // ここで Particle System を開始します.
            particle.Play();
        }
    }
}
