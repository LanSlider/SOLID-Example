using System.Collections.Generic;

namespace L_Valid
{
    class GelPen : Pen
    {
        public string GenRefillModel { get; set; }

        public override Dictionary<string, string> GetAllPenModels()
        {
            return new Dictionary<string, string>()
            {
                { "BodyModel", this.BodyModel },
                { "CapModel", this.CapModel },
                { "GenRefillModel", this.GenRefillModel }
            };
        }
    }
}
