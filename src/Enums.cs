namespace VL.Devices.Ultraleap
{
    using Leap;
    using System.ComponentModel;

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

    public enum LeapHint
    {
        [Description("hand_on_object")]
        HandOnObject,
        [Description("microgestures")]
        Microgestures,
        [Description("fast_hand_motion")]
        FastHandMotion,
        [Description("high_hand_fidelity")]
        HighHandFidelity,
        [Description("low_resource_usag")]
        LowResourceUsage,
        [Description("high_background_illumination")]
        HighBackgroundIllumination,
        [Description("balanced")]
        Balanced,
        [Description("user_input")]
        UserInput,
        [Description("app_immersive")]
        AppImmersive,
        [Description("app_passthrough")]
        AppPassthrough,
        [Description("ultra_performance_mode")]
        UltraPerformanceMode
    }

}
