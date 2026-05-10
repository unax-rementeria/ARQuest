using System.Collections;
using UnityEngine;

public class cubeMoveFlechas : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 direction;


    int[] ints = new int[] {-90, 0, 90, 180};



    void Start()
    {
        int randValue = Random.Range(0, ints.Length);
        int value = ints[randValue];
        float direction = Random.Range(-10.0f,10.0f);
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0.0f,direction,value);
        morir();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // void OllisionEnter(Collision collision)
    // {
    //     Destroy(gameObject);       
    // }

    IEnumerator morir()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("destruido");
        Destroy(gameObject);
    }

}
