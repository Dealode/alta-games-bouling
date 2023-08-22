namespace CodeBase.Infrastructure.StaticData
{
    public interface IStaticDataService
    {
        string sphereMainAssetPath { get; }
        string sphereParticleAssetPath { get; }
        string finishAssetPath { get; }
        string letAssetPath { get; }
    }
}