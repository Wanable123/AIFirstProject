using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    //abstract classes are never started and are base classes
    public Perception perception;
    public Movement movement;

}
