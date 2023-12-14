using UnityEngine;

public class Button_other : MonoBehaviour
{
    public GameObject Object_Open;
    public int int_suicide;

    void Start (){
        PlayerPrefs.DeleteKey("int_suicide");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("add_special"))
        {
        int_suicide = 1;
        PlayerPrefs.SetInt("int_suicide",int_suicide);
        Object_Open.SetActive(false);
        }
    }

    void Update (){
    int_suicide = PlayerPrefs.GetInt("int_suicide");

    }
}
