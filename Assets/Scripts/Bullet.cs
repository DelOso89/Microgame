using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float velocidad=10f;
    public float tiempoVida=2f;
    public Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject,tiempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(target * velocidad * Time.deltaTime);

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            IncreaseScore();
            Destroy(collision.gameObject);
            UpdateScore();
            Destroy(gameObject);
            
        }
    }
    private void IncreaseScore()
    {
        Nave.Score++;
        Debug.Log(Nave.Score);
    }
    private void UpdateScore()
    {
        GameObject go =GameObject.FindGameObjectWithTag("Score");
        go.GetComponent<TMP_Text>().text="Puntos : "+ Nave.Score;
    }
}
