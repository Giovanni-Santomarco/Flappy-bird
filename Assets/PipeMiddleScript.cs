using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //it is going to search for the first gameObject in the hierarchy with the tag, Logic.
        //then it will look through that object's components to find a script of the class LogicScript,
        //and if it finds one, it will put that in our reference slot.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
