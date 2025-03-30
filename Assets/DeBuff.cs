using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(BoundsCheck))]                                     // a
public class DeBuff : MonoBehaviour
{
    [Header("Inscribed")]
    // This is an unusual but handy use of Vector2s.                          // b
    [Tooltip("x holds a min value and y a max value for a Random.Range() call.")]
    public Vector2 rotMinMax = new Vector2(15, 90);
    [Tooltip("x holds a min value and y a max value for a Random.Range() call.")]
    public Vector2 driftMinMax = new Vector2(.25f, 2);
    public float lifeTime = 10; // PowerUp will exist for # seconds
    public float fadeTime = 4;  // Then it fades over # seconds

    [Header("Dynamic")]
    public GameObject cube;          // Reference to the PowerCube child
    public Vector3 rotPerSecond;  // Euler rotation speed for PowerCube 
    public float birthTime;     // The Time.time this was instantiated

    private Rigidbody rigid;
    private Material cubeMat;

    void Awake()
    {
        cube = transform.gameObject;
        rigid = GetComponent<Rigidbody>();
        cubeMat = cube.GetComponent<Renderer>().material;

        rigid.velocity = new Vector3(0f,-80f,0f);
        transform.rotation = Quaternion.identity;
        rotPerSecond = new Vector3(Random.Range(rotMinMax[0], rotMinMax[1]),
        Random.Range(rotMinMax[0], rotMinMax[1]),
        Random.Range(rotMinMax[0], rotMinMax[1]));

        birthTime = Time.time;
    }


    void Update()
    {
        cube.transform.rotation = Quaternion.Euler(rotPerSecond * Time.time); // f

        float u = (Time.time - (birthTime + lifeTime)) / fadeTime;              // g
        
        if (u >= 1)
        {
            Destroy(this.gameObject);
            return;
        }
    }

    public void AbsorbedBy(GameObject target)
    {                              // i
        Destroy(this.gameObject);
    }

}