using Blynclight;

namespace blynclight_tfs
{

    public interface IBlynclightController
    {
        int InitBlyncDevices();
    }

    // wrapper for controller from sdk/assembly
    public class Blync
    {
        BlynclightController controller;
        IBlynclightController injected;
        bool isControllerInjected = false;
        
        public Blync()
        {
            this.controller = new BlynclightController();
        }

        public Blync(IBlynclightController injected)
        {
            this.injected = injected;
            this.isControllerInjected = true;
        }

        public int getConnectedBlyncDevices()
        {
            if (this.isControllerInjected)
            {
                return this.injected.InitBlyncDevices();
            }
            else
            {
                return this.controller.InitBlyncDevices();
            }
            
        }
    }
}
