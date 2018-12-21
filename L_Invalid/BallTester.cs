using System;
using L_Invalid.Ball;

namespace L_Invalid
{
    class BallTester
    {
        public bool CheckBallElasticity(Ball.Ball ball)
        {
            if (ball is BasketBall)
            {
                if (ball.BounceHeight > 60)
                {
                    return true;
                }
            }

            if (ball is RugbyBall)
            {
                if (ball.BounceHeight > 5)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetBallSizeFromCircumference(Ball.Ball ball)
        {
            if (ball is BasketBall)
            {
                if (ball.Circumference > 750 && ball.Circumference < 780)
                {
                    return 7;
                }

                if (ball.Circumference > 724 && ball.Circumference < 737)
                {
                    return 6;
                }

                //...
            }

            if (ball is RugbyBall)
            {
                var rugbyBall = (RugbyBall)ball;
                if (rugbyBall.CircumferenceInShortLength > 58 && rugbyBall.CircumferenceInShortLength < 62 && rugbyBall.CircumferenceInLength > 74 && rugbyBall.CircumferenceInLength < 77)
                {
                    return 5;
                }

                //...
            }

            throw new ArgumentException("It's not a ball");
        }
    }
}
