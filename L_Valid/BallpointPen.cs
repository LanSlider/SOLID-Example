using System.Collections.Generic;

namespace L_Valid
{
    class BallpointPen : Pen
    {        
        public override Dictionary<string, string> GetAllPenCompositionModels()
        {
            return new Dictionary<string, string>()
            {
                { "BodyModel", this.BodyModel },
                { "CapModel", this.CapModel },
                { "RefillModel", this.RefillModel }
            };
        }
    }
}
