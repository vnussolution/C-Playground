namespace CSharp_Playground {

    class VolumneButton : ICommand {

        IElectronicDevice device;

        public VolumneButton (IElectronicDevice device) {
            this.device = device;
        }

        public void Execute () {
            device.VolumeUp ();
        }

        public void Undo () {
            device.VolumeDown ();
        }
    }
}