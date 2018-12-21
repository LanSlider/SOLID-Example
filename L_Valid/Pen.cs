using System.Collections.Generic;

namespace L_Valid
{
    abstract class Pen
    {
        public string BodyModel { get; set; }
        public string CapModel { get; set; }
        public string RefillModel { get; set; }

        public abstract Dictionary<string,string> GetAllPenModels();
    }
}
