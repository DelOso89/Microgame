using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moviemiento : MonoBehaviour
{
    public float impulsespeed =4f;
    public float rotationspeed=8f;
    Rigidbody rb;
    Vector2 ThrustDireccion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation= Input.GetAxis("Horizontal")*rotationspeed*Time.deltaTime;
        float thrust =Input.GetAxis("Vertical")*impulsespeed*Time.deltaTime;
        
        ThrustDireccion= transform.right;
        transform.Rotate(Vector3.forward, rotation*-1);
        rb.AddForce(ThrustDireccion*thrust);
        // Para que la nave no se salga de la camara y aparezca en el borde opuesto
        Vector3 posicion=transform.position;
        if(posicion.x>=12f)
        {
            posicion.x=-11.8f;
            transform.position=posicion;
        }
        else if(posicion.x <= -12f)
        {
            posicion.x=11.8f;
            transform.position=posicion;
        }
        if(posicion.y>=6.4f)
        {
            posicion.y=-4.2f;
            transform.position=posicion;
        }else if (posicion.y<=-4.4f)
        {
            posicion.y=6.2f;
            transform.position=posicion;
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
