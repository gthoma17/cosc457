using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided: ", gameObject);
        Destroy(this.gameObject);
        Application.LoadLevel(Application.loadedLevel);
    }
}