// ---------- TVRemote.cs ----------

namespace CSharp_Playground {
    class TVRemote {
        // Now we are modeling the action of
        // picking up the remote with our hand
        public static IElectronicDevice GetDevice () {
            return new Television ();
        }
    }
}