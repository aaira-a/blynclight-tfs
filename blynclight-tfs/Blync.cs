using Blynclight;

namespace blynclight_tfs
{

    public interface IBlynclightController
    {
        int InitBlyncDevices();
        bool TurnOnMagentaLight(int deviceIndex);
        bool ResetLight(int deviceIndex);
    }

    public class BlyncUser
    {
        IBlynclightController controller;

        
        public BlyncUser()
        {
            this.controller = (IBlynclightController) ActualControllerFactory.Create();
        }
        

        public BlyncUser(IBlynclightController injected_controller)
        {
            this.controller = injected_controller;
        }

        public int getConnectedBlyncDevices()
        {
            return controller.InitBlyncDevices();
        }

        public void TurnOnMagentaLight(int deviceIndex)
        {
            this.controller.TurnOnMagentaLight(deviceIndex);
        }

        public void ResetLight(int deviceIndex)
        {
            this.controller.ResetLight(deviceIndex);
        }

    }

    public class ActualControllerFactory
    {
        public static BlynclightController Create()
        {
            return new BlynclightController();
        }
    }
}
