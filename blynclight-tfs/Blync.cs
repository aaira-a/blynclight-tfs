using Blynclight;

namespace blynclight_tfs
{

    public interface IBlynclightController
    {
        int InitBlyncDevices();
        bool TurnOnMagentaLight(int deviceIndex);
        bool ResetLight(int deviceIndex);
    }

    public class ConcreteBlync : IBlynclightController
    {

        public int InitBlyncDevices()
        {
            return 6;
        }

        public bool TurnOnMagentaLight(int deviceIndex)
        {
            return true;
        }

        public bool ResetLight(int deviceIndex)
        {
            return true;
        }
    }

    // wrapper for controller from sdk/assembly
    public class Blync
    {
        BlynclightController controller;
        
        
        public Blync()
        {
            this.controller = new BlynclightController();
        }
        

        public Blync(BlynclightController injected_controller)
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


    public class AlternateBlync
    {
        IBlynclightController controller;

        
        public AlternateBlync()
        {
            this.controller = new ConcreteBlync();
        }
        

        public AlternateBlync(IBlynclightController injected_controller)
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
}
