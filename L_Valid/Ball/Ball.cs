using System.Drawing;

namespace L_Valid.Ball
{
    class Ball
    {
        public string ModelName { get; set; }
        public string BodyMaterial { get; set; }
        public int Circumference { get; set; }
        public int BounceHeight { get; set; }

        public virtual int Size { get; set; }
    }
}
