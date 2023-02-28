using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass
{
    //Abstract Factory
    public interface IFeatureFactory
    {
        IRationale GetRationale();
        ICompressor GetCompressor();
    }

    //Abstract Rationale
    public interface IRationale
    {
        public List<int> CalculateParameter();
    }
    // Abstract Compressor
    public interface ICompressor
    {
        public int GetCompressorHandle();
    }
    public class Compressor : ICompressor
    {
        private int _compressorId;
        public Compressor(int id)
        {
            _compressorId = id;

        }
        public int GetCompressorHandle()
        {
            //return the hanlde of compressor based on id
            // get the handle from HW driver using id of compressor
            return _compressorId;

        }
    }

    // Concrete Rationale 1
    public class Rationale_1 : IRationale
    {
        public List<int> CalculateParameter()
        {
            //calculate parameter to be written in EEPROM
          
            return new List<int> { 1, 1, 1, 1 };
        }
    }
    // Concrete Rationale 2
    public class Rationale_2 : IRationale
    {
        public List<int> CalculateParameter()
        {
            return new List<int> { 2, 2, 2, 2 };
        }

    }
    // Concrete Rationale 3
    public class Rationale_3 : IRationale
    {
        public List<int> CalculateParameter()
        {
            return new List<int> { 3, 3, 3, 3 };
        }
    }

    //FeatureFactory_1
    public class FeatureFactory_1 : IFeatureFactory
    {
        private int CompressorId = 1;
        public IRationale GetRationale()
        {
            return new Rationale_1();
        }
        public ICompressor GetCompressor()
        {
            return new Compressor(CompressorId);

        }
    }
    //FeatureFactory_2
    public class FeatureFactory_2 : IFeatureFactory
    {
        private int CompressorId = 2;
        public IRationale GetRationale()
        {
            return new Rationale_2();
        }
        public ICompressor GetCompressor()
        {
            return new Compressor(CompressorId);

        }
    }
    //FeatureFactory_3
    public class FeatureFactory_3 : IFeatureFactory
    {
        private int CompressorId = 3;
        public IRationale GetRationale()
        {
            return new Rationale_3();
        }
        public ICompressor GetCompressor()
        {
            return new Compressor(CompressorId);

        }
    }
    //FeatureFactory_4


    // Feature  class 
    public class Feature
    {
        private IRationale _rationale;
        private ICompressor _compressor;
        private int _compressorHandle;

        public Feature(IFeatureFactory factory)
        {
            _rationale = factory.GetRationale();
            _compressor = factory.GetCompressor();
            _compressorHandle = _compressor.GetCompressorHandle();
        }

        public void WriteToHearingAid()
        {
            var values = _rationale.CalculateParameter();
            Console.WriteLine($"Writing parameter to EEPROM {String.Join("; ", values)}  to Compressor handle. {_compressorHandle}");
        }

    }
    

}
