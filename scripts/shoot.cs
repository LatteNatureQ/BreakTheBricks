using UnityEngine;

public class shoot : MonoBehaviour {
    
    public GameObject build;
    public float speed = 5;
	// Use this for initialization
	void Start () {
        Debug.Log("start ok");
	}
	
	// Update is called once per frame
	void Update () {
        //判断鼠标左键是否按下
        if (Input.GetMouseButtonDown(0))
        {
            //实例化小球
            GameObject b = GameObject.Instantiate(build, transform.position, transform.rotation);
            Rigidbody rgb = b.GetComponent<Rigidbody>();
            rgb.velocity = transform.forward * speed;
        }
        Debug.Log("Update ok");
	}
}
