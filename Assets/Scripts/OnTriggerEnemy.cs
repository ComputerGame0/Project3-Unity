using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnTriggerEnemy : MonoBehaviour
{
    [SerializeField] float minImpulseForExplosion = 1.0f;
    [SerializeField] GameObject explosionEffect = null;
    [SerializeField] string triggeringTag;
    [SerializeField] float explosionEffectTime = 0.68f;
    [SerializeField] string sceneName;


    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // In 3D, the Collision object contains an .impulse field.
        // In 2D, the Collision2D object does not contain it - so we have to compute it.
        float impulse = collision.relativeVelocity.magnitude * rb.mass;
        Debug.Log(gameObject.name + " collides with " + collision.collider.name
            + " at velocity " + collision.relativeVelocity + " [m/s], impulse " + impulse + " [kg*m/s]");
        if (impulse < minImpulseForExplosion && impulse >1 && collision.collider.tag== triggeringTag)
        {
            StartCoroutine(Explosion());
        }

    }

    IEnumerator Explosion()
    {
        explosionEffect.SetActive(true);
        yield return new WaitForSeconds(explosionEffectTime);
        Destroy(this.gameObject);
        SceneManager.LoadScene(sceneName);
    }

}


