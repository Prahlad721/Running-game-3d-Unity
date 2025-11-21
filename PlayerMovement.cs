using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
      public float playerSpeed = 2;
      public float horizontalSpeed = 3;
      public  float rightLimit =5.5f; 
      public  float LeftLimit = -5.5f; 

      [Header("--------Audio---------")]
      public AudioSource sfxSource;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime*playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LeftLimit){
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
        }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
              if(this.gameObject.transform.position.x < rightLimit){
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);

        }
        }

    }
}