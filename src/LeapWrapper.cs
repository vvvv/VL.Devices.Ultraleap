using System;
using System.Collections.Generic;
using System.Linq;


namespace LeapOrionVL
{
    public enum FingerType
    {
        //original, from Leap API
        /*
        TYPE_THUMB = 0,
        TYPE_INDEX = 1,
        TYPE_MIDDLE = 2,
        TYPE_RING = 3,
        TYPE_PINKY = 4
        */
        Thumb = 0,
        Index = 1,
        Middle = 2,
        Ring = 3,
        Pinky = 4
    }

    public enum BoneType
    {
        //original, from Leap API
        /*
        TYPE_METACARPAL,
        TYPE_PROXIMAL,
        TYPE_INTERMEDIATE,
        TYPE_DISTAL,
        TYPE_INVALID,
        */
        Metacarpal,
        Proximal,
        Intermediate,
        Distal,
        Invalid
    }

    //only used in 'Selectors' to be able to choose from a list (enum)
    public enum HandSide
    {
        Left,
        Right
    }

    public enum RelativePosition
    {
        Frontmost,
        Leftmost,
        Rightmost
    }
} 