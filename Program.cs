/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 2/1/2019
 * Time: 2:28 AM
 */
using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal APRatio = (decimal).67;
            for(decimal i=0; i<=200; i++)
            {
                Console.WriteLine("Armor:{0,-6} DamRed:{1,-10} EHP:{2,-5}", i, Math.Round(DamageReduction(i, APRatio), 5), EffectiveHP(i, APRatio));
            }

            Console.ReadKey(true);
        }

        private static object EffectiveHP(decimal i, decimal APRatio)
        {
            decimal Value = ((decimal)1 - (DamageReduction(i, APRatio)));
            if(Value <= 0) { return "Infinity"; }
            return Math.Round(100 / (Value));
        }

        private static decimal DamageReduction(decimal armor, decimal APRatio)
        {
            if (armor <= 0) { return 0; }
            if (armor <= 100) { return ((1-APRatio)*(armor*(decimal).75)/100); }
            return (1-APRatio)*((decimal)-.0025*armor - 100/armor + 2);
        }
    }
