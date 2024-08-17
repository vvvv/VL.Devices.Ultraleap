namespace VL.Devices.Ultraleap
{
    using Leap;


    public enum TrackingMode
    { 
        Desktop = Controller.PolicyFlag.POLICY_DEFAULT,
        HeadMounted = Controller.PolicyFlag.POLICY_OPTIMIZE_HMD,
        Screentop = Controller.PolicyFlag.POLICY_OPTIMIZE_SCREENTOP
    }
    
    
    // used in 'Selectors' to be able to choose from a list (enum)
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
