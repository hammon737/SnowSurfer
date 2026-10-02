using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] private ParticleSystem hitEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == layerIndex)
        {
            hitEffect.Play();
            Invoke("ReloadScene", restartDelay);
        }

    }
        void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }

}
