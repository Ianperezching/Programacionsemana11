using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D _compRigibody;
    public float speedx;
    public int direccionx;
    public int direcciony;
    private SpriteRenderer _CompSpriteRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigibody = GetComponent<Rigidbody2D>();
        _CompSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

    }

    void Update()
    {
        //transform.position = new Vector2(transform.position.x + speedx * Time.deltaTime, 0);
    }
    private void FixedUpdate()
    {
        _compRigibody.velocity = new Vector2(speedx * direccionx, speedx * direcciony);
    }
   public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (direccionx == 1)
            {
                direccionx = -1;
                _CompSpriteRenderer.flipX = true;

            }
            else if (direccionx == -1)
            {
                direccionx = 1;
                _CompSpriteRenderer.flipX = false;
            }

        }
        if(collision.gameObject.tag == "techo")
        {
            if (direcciony==1)
            {
                direcciony = -1;

            }
            else if (direcciony == -1)
            {
                direcciony = 1;
            }
        }
    }
}
