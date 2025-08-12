using UnityEngine;


public class ParallaxEffecto : MonoBehaviour
{
    public Transform camara;
    public float factor;
    private float inicioX;
    private float anchoSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inicioX = transform.position.x;
        anchoSprite = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        float temp = (camara.position.x * (1 - factor));
        float dist = (camara.position.x * factor);
        transform.position = new Vector3(inicioX + dist, transform.position.y, transform.position.z);
        if (temp > inicioX + anchoSprite) inicioX += anchoSprite;
        else if (temp < inicioX - anchoSprite) inicioX -= anchoSprite;

    }
}
