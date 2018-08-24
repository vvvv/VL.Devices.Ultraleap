using System;
using System.Collections.Generic;
using System.Linq;


namespace LeapOrionVL
{
    public class LeapHelper
    {
        //we flagged Leap.Frame as an immutable type
        //However, Leap.Frame.Deserialize returns void
        //Therefore it cannot be used like the method of an immutable type, so here's the workaround:
        public static Leap.Frame Deserialize(IEnumerable<byte> data, out String errorMessage, out bool error)
        {
            error = false;
            errorMessage = "";
            Leap.Frame frame = new Leap.Frame();
            try
            {
                frame.Deserialize(data.ToArray());
            }
            catch(Exception e)
            {
                error = true;
                errorMessage = e.ToString();
            }
            return frame;
        }

        //public static Leap.Bone GetBone(Leap.Finger finger, BoneType type)
        //{
        //    return finger.Bone((Leap.Bone.BoneType) type);
        //}

        //public static void GetBones(Leap.Finger finger, out Leap.Bone metacarpal, out Leap.Bone proximal, out Leap.Bone intermediate, out Leap.Bone distal)
        //{
        //    metacarpal = finger.Bone((Leap.Bone.BoneType) BoneType.Metacarpal);
        //    proximal = finger.Bone((Leap.Bone.BoneType) BoneType.Proximal);
        //    intermediate = finger.Bone((Leap.Bone.BoneType) BoneType.Intermediate);
        //    distal = finger.Bone((Leap.Bone.BoneType) BoneType.Distal);
        //}

        //public static FingerType GetFingerType(Leap.Finger finger)
        //{
        //    return (FingerType) finger.Type;
        //}

        //public static BoneType GetBoneType(Leap.Bone bone)
        //{
        //    return (BoneType) bone.Type;
        //}
    }

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
        */
        Metacarpal,
        Proximal,
        Intermediate,
        Distal
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
 