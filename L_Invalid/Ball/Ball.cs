namespace L_Invalid.Ball
{
    abstract class Ball
    {
        public string ModelName { get; set; }
        public string BodyMaterial { get; set; }
        public int Circumference { get; set; }
        public int BounceHeight { get; set; }
    }
}
