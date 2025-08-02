using UnityEngine;

public class test : MonoBehaviour
{
    private string myMassage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("hello");
        
    }

    // Update is called once per frame
    void Update()
    {
        return 0;
    }
    
    public class test(string massage)
    {
        this.myMassage = massage;
    }

    public string ReturnMassage()
    {
        return this.myMassage;
    }
}
