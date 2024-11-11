namespace VL.Devices.Ultraleap
{

    public static class UltraleapHelper
    {

        private static readonly Dictionary<LeapHint, String> LeapHintLookup;

        static UltraleapHelper()
        {

            // https://docs.ultraleap.com/api-reference/tracking-api/group/group___hints.html
            // https://docs.ultraleap.com/api-reference/unity-api/class/class_leap_1_1_controller.html?highlight=requesthandtrackinghints#function-Leap.Controller.RequestHandTrackingHints           
            LeapHintLookup = new Dictionary<LeapHint, String>
            {
                {LeapHint.HandOnObject, "hand_on_object"},
                {LeapHint.Microgestures, "microgestures"},
                {LeapHint.FastHandMotion, "fast_hand_motion"},
                {LeapHint.HighHandFidelity, "high_hand_fidelity"},
                {LeapHint.LowResourceUsage, "low_resource_usag"},
                {LeapHint.HighBackgroundIllumination, "high_background_illumination"},
                {LeapHint.Balanced, "balanced"},
                {LeapHint.UserInput, "user_input"},
                {LeapHint.AppImmersive, "app_immersive"},
                {LeapHint.AppPassthrough, "app_passthrough"},
                {LeapHint.UltraPerformanceMode, "ultra_performance_mode"}
            };

        }
        
        public static string LookupHint(LeapHint key)
        {            
            return LeapHintLookup[key];
        }
    
    }


}