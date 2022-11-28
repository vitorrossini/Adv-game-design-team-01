using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    public float rotationZ;
    public float speed = 1f;
    private Movement movement;

    public void Start()
    {
        movement = GameObject.Find("Player").GetComponent<Movement>();
        rotationZ = gameObject.transform.rotation.z;
    }
    
    public void Update()
    {
        TurnIt();
    }

   
   public void TurnIt()
    {
        if (Input.GetButton("Rotate") && movement.GetComponent<Movement>().onTurnPlat == true)
        {
            
            Debug.LogError("yeah you can turn");



            rotationZ -= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            rotationZ = Mathf.Clamp(rotationZ, -90, 90);

            transform.rotation = Quaternion.Euler(0, 0, rotationZ);


        }
      

    }
   





}
