namespace VL.Devices.Ultraleap
{

    public static class UltraleapHelper
    {

        private static readonly Dictionary<LeapHint, String> LeapHintLookup;

        static UltraleapHelper()
        {

            // https://docs.ultraleap.com/api-reference/tracking-api/group/group___hints.html
            //Group Hints

            //Hints a client may pass to the server to influence hand tracking settings and behaviour.
            //Some hints will represent an “Axis” (e.g.application type) where values are mutually exclusive.But other hints may not be explicitly on an axis (e.g.user is typing on a virtual keyboard and microgestures) but may not be actually compatible.
            //Some hints values will only be supported when the hand tracking service has a Hyperion license.These will be indicated in the hint documentation below. (Requests for unlicensed hints will be ignored)
            //Over time supported hints will be added and removed(unknown values will be ignored). 


            //LEAP_HINT_HAND_ON_OBJECT

            //    Requested using “hand_on_object”.
            //    Hand tracking is being used while holding objects(Hyperion license required)
            //    Optimises hand tracking where hands are occluded by objects being held.Achieves higher performance in these situations at the cost of more general tracking performance e.g.Mixed and Augmented Reality.
            //    To confirm this hint is available the application can check for the presence of the Hyperion “Hyperion” feature flag.

            //LEAP_HINT_MICROGESTURES

            //    Requested using “microgestures”.
            //    Hand tracking is for being used for Microgestures(Hyperion license required)
            //    Optimises the hand tracking for small, finer movements for user navigation and control.
            //    To confirm this hint is available the application can check for the presence of the “Hyperion” feature flag.

            //LEAP_HINT_FAST_HAND_MOTION
            //    Requested using “fast_hand_motion”.
            //    Tracked hands are expected to be moving quickly.
            //    The system will optimise for hands that move quickly at the cost of using more resources(CPU, camera bandwidth, memory and power)

            //LEAP_HINT_HIGH_HAND_FIDELITY
            //    Requested using “high_hand_fidelity”.
            //    Hand position accuracy is very important.
            //    Increases the fidelity and responsiveness of hand tracking at the expense of compute resources (CPU, camera bandwidth, memory and power). Attempts to match available system resources will be made, however, callers should take steps to maintain sufficient application resources.

            //LEAP_HINT_LOW_RESOURCE_USAGE

            //    Requested using “low_resource_usage”.
            //    Minimising resource usage(CPU, camera bandwidth, memory and power) is very important.
            //    The system will minimise resource usage at the cost of hand tracking quality. Using this hint to avoid OS throttling on a resource-constrained system might produce the best hand tracking experience.
            //    LEAP_HINT_HIGH_BACKGROUND_ILLUMINATION

            // LEAP_HINT_HIGH_BACKGROUND_ILLUMINATION

            //    Requested using “high_background_illumination”.
            //    Hand tracking is running in an environment with a high level of illumination, for an IR camera system it’s only the IR illumination the is relevant.
            //    The system will optimise to track hands more reliably in these challenging conditions with a possible costs of latency, CPU and power.
            //    LEAP_HINT_BALANCED

            // LEAP_HINT_BALANCED

            //    Requested using “balanced”.
            //    Default tracking where there is no preference set.This mode is enabled on service restart.

            //LEAP_HINT_USER_INPUT

            //    Requested using “user_input”.
            //    Optimises hand predictions for user input into menus, keyboards or navigation panels.

            //LEAP_HINT_APP_IMMERSIVE

            //    Requested using “app_immersive”.
            //    Application Type Axis: Hand tracking is being used by an immersive application, i.e.VR
            //    LEAP_HINT_APP_PASSTHROUGH

            //    Requested using “app_passthrough”.
            //    Application Type Axis: Hand tracking is being used by an application using passthrough, i.e.AR

            //LEAP_HINT_ULTRA_PERFORMANCE_MODE

            //    Requested using “ultra_performance_mode”.
            //    Hint: Increases the fidelity and responsiveness of hand tracking at the expense of compute resources.
            //    Attempts to match available system resources may be made However, callers should take steps to maintain sufficient application resources”

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