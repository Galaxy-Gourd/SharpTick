using GGSharpTick;

namespace GGTests.Tick.Demo
{
    public class DemoFixedTickClientInstanceRegistrationTest : ITickClientFixed
    {
        #region Registration

        public void RegisterTickClient(ITicksetInstance tickset)
        {
            TickSystemTestsInstaller.TestTick.Register(this, tickset);
        }

        public void UnregisterTickClient(ITicksetInstance tickset)
        {
            TickSystemTestsInstaller.TestTick.Unregister(this, tickset);
        }

        #endregion Registration
        
        
        #region Tick

        void ITickClientFixed.Tick(float delta)
        {
            
        }

        #endregion Tick
    }
}