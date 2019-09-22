namespace MXGP.Core.Factories.Contracts
{
    using MXGP.Models.Motorcycles.Contracts;
    //using Models.Motorcycles.Contracts;

    public interface IMotorcycleFactory
    {
        IMotorcycle CreateMotorcycle(string type, string model, int horsePower);
    }
}
