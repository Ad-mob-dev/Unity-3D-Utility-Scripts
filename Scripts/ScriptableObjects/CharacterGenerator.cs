
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Generate Character Data", order = 51)]
public class CharacterGenerator : ScriptableObject
{
    [SerializeField]
    private string PlayerName;
    [SerializeField]
    private Material Material;
    [SerializeField]
    private int Health;
    [SerializeField]
    private float RotationAngle;
    [SerializeField]
    private float ForwardSpeed;


    public string playerName
    {
        get { return PlayerName; }   // get method
        set { PlayerName = value; }  // set method
    }

    public Material material
    {
        get { return Material; }   // get method
        set { Material = value; }  // set method
    }

    public int health
    {
        get { return Health; }   // get method
        set { Health = value; }  // set method

    }
    public float rotationAngle
    {
        get { return RotationAngle; }   // get method
        set { RotationAngle = value; }  // set method
    }
    public float forwardSpeed
    {
       
            get { return ForwardSpeed; }   // get method
            set {ForwardSpeed = value; }  // set method
     }
}
