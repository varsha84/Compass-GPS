namespace Compass
{
    internal class Program
    {
        // Program having tweaking setting of two features
        static void Main(string[] args)
        {
            var featurefactory1 = new FeatureFactory_1();
            var feature1 = new Feature(featurefactory1);
            feature1.WriteToHearingAid();

            var featurefactory2 = new FeatureFactory_2();
            var feature2 = new Feature(featurefactory2);
            feature2.WriteToHearingAid();
          
        }
    }
}