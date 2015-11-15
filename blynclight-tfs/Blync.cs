using Blynclight;

namespace blynclight_tfs
{

    public interface IBlynclightController
    {
        int InitBlyncDevices();
        void TurnOnMagentaLight(int deviceIndex);
        void ResetLight(int deviceIndex);
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

        public void TurnOnMagentaLight(int deviceIndex)
        {
            if (this.isControllerInjected)
            {
                this.injected.TurnOnMagentaLight(deviceIndex);
            }
            else
            {
                this.controller.TurnOnMagentaLight(deviceIndex);
            }
        }

        public void ResetLight(int deviceIndex)
        {
            if (this.isControllerInjected)
            {
                this.injected.ResetLight(deviceIndex);
            }
            else
            {
                this.controller.ResetLight(deviceIndex);
            }
        }

    }
}
