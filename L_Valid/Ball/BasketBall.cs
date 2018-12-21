using System;

namespace L_Valid.Ball
{
    class BasketBall : Ball
    {
        public override int Size
        {
            get
            {
                if (Circumference > 750 && Circumference < 780)
                {
                    return 7;
                }

                if (Circumference > 724 && Circumference < 737)
                {
                    return 6;
                }

                //...

                throw new ArgumentException("It's not a ball");
            }
        }

        public override bool IsNormalElasticity
        {
            get
            {
                if (BounceHeight > 60)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
