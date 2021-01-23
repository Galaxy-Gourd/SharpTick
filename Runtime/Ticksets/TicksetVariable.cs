namespace GGSharpTick
{
    public class TicksetVariable : TicksetBase
    {
        #region Constructor

        public TicksetVariable(TicksetConfigData data, TickVariable t)
        {
            TicksetData = data;
            tick = t;
        }

        #endregion Constructor
        
        
        #region Tick

        /// <summary>
        /// Iterates through and ticks every ITickable assigned to this tickset.
        /// </summary>
        public override void Tick(float delta)
        {
            base.Tick(delta);
            foreach (var tickClient in _current)
            {
                var obj = (ITickClientVariable) tickClient;
                obj.Tick(delta);
            }
        }

        #endregion
    }
}